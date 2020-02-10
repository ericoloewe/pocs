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
  const promises = [];
  let currentLine = 1;

  await new Promise(resolve => {
    readLineFile.on("line", async term => {
      promises.push(saveTerm(term, collection, currentLine++));
    });

    readLineFile.on("close", async () => {
      await Promise.all(promises);
      resolve();
    });
  });
}

/**
 * @param {string} term
 * @param {import('mongodb').Collection} collection
 * @param {number} currentLine
 */
async function saveTerm(term, collection, currentLine) {
  const parsedTerm = term.trim().toLowerCase();
  const parsedInitial = isNaN(Number(parsedTerm[0])) ? parsedTerm[0] : "0-9";

  await new Promise(resolve => {
    collection.replaceOne(
      { Termo: parsedTerm },
      { Inicial: parsedInitial, Termo: parsedTerm },
      { upsert: true },
      resolve
    );
  });

  process.stdout.write(
    `\rline: ${currentLine}, ${term} => ${parsedTerm} (${parsedInitial})=========================================`
  );
}
