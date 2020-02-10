const uri = "mongodb://localhost:27017/db_stg_casasbahia";
const { MongoClient } = require("mongodb");
const { createReadStream } = require("fs");
const { createInterface } = require("readline");
const path = require("path");

const client = new MongoClient(uri, { useUnifiedTopology: true });

client.connect(async err => {
  if (!err) {
    const collection = client
      .db("db_stg_casasbahia")
      .collection("BuscasPopulares");

    await readFileAndUpdateCollection(path.resolve("teste.txt"), collection);
  } else {
    console.error("err", err);
  }

  // perform actions on the collection object
  client.close();
});

/**
 * @param {string} fileName
 * @param {import('mongodb').Collection} collection
 */
async function readFileAndUpdateCollection(fileName, collection) {
  const fileStream = createReadStream(fileName);
  const readLineFile = createInterface({ input: fileStream });
  let currentLine = 1;
  const promises = [];
  const termsToSave = [];

  await new Promise(resolve => {
    readLineFile.on("line", async term => {
      termsToSave.push(term);
      currentLine++;
      process.stdout.write(
        `\rline: ${currentLine} ${term}=========================================`
      );

      if (termsToSave.length >= 999) {
        promises.push(saveTerms(termsToSave.splice(0), collection));
      }
    });

    readLineFile.on("close", async () => {
      promises.push(saveTerms(termsToSave.splice(0), collection));
      await Promise.all(promises);
      resolve();
    });
  });
}

/**
 * @param {string[]} term
 * @param {import('mongodb').Collection} collection
 */
async function saveTerms(terms, collection) {
  const bulkQuery = terms.map(parseTermsToBulkQuery);

  await new Promise(resolve => collection.bulkWrite(bulkQuery, {}, resolve));
}

function parseTermsToBulkQuery(term) {
  const parsedTerm = term.trim().toLowerCase();
  const parsedInitial = isNaN(Number(parsedTerm[0])) ? parsedTerm[0] : "0-9";

  return {
    replaceOne: {
      filter: { Termo: parsedTerm },
      replacement: { Inicial: parsedInitial, Termo: parsedTerm },
      upsert: true
    }
  };
}
