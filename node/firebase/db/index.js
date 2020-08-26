const firebaseAdmin = require('firebase-admin')
const serviceAccount = require('./words-fd97b-firebase-adminsdk-nxjp9-4222c895bf.json')
const wordsDictionary = require('./words_dictionary.json')
const words = Object.keys(wordsDictionary)

firebaseAdmin.initializeApp({
  credential: firebaseAdmin.credential.cert(serviceAccount),
  databaseURL: 'https://words-fd97b.firebaseio.com/'
})

const db = firebaseAdmin.database()

// Promise.all(
//   words.map(w => createNewWord(w))
// ).then(words => {
//   console.log("OK")
// })
// createNewWord(words[Math.floor(Math.random() * words.length)])
// readWords()
// filterWords()
// db.ref(`words/filter`).remove()

valTest()

async function valTest() {
  let counter = 0

  setInterval(() => {
    db.ref('counter').set(counter++)

    console.log('interval')
  }, 1000)

  const snapshot1 = await db.ref('counter').once('value')

  setTimeout(async () => {
    const snapshot2 = await db.ref('counter').once('value')

    console.log('timeout', snapshot1.val(), snapshot2.val())
  }, 2000)
}


async function filterWords() {
  const data = await db.ref(`words/list`).orderByChild('name').startAt('a').limitToFirst(2).once('value')

  console.log('startAt', data.val())
}

async function createNewWord(nextWord) {
  const listRef = db.ref(`words/list`).push()
  const ISODateTime = new Date().toISOString()

  listRef.set({
    name: nextWord,
    createdDateTime: ISODateTime
  })
}

async function readWords(params) {
  const data = await db.ref(`words`).once('value')

  console.log('here', data.val())
  db.app.delete()
}


// const itemRefWithKey = db.ref('<some-base>').push()

// itemRefWithKey.set({
//   value: '<some-value>'
// })


// db.ref('<some-base>').once('value', snapshot => {
//   const myData = snapshot.val()
// })

// db.ref('<some-base>/<some-id>').once('value', snapshot => {
//   const mySpecificData = snapshot.val()
// })

// db.ref('<some-base>/<some-id>').remove()