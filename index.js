const uri = "mongodb://localhost:27017/db_stg_casasbahia";
const { MongoClient } = require("mongodb");

const client = new MongoClient(uri);

client.connect(err => {
  if (!err) {
    const collection = client.db("db_stg_casasbahia").collection("BuscasPopulares");

    console.log(collection);
  } else {
    console.error("err", err);
  }

  // perform actions on the collection object
  client.close();
});
