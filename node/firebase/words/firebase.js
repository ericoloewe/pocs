(() => {
  'use strict';

  const App = window.App || {}
  const db = firebase.database()

  class FirebaseService {
    async add(newWord = '') {
      const ISODateTime = new Date().toISOString()
      const newWordRef = db.ref('words/list').push()

      return newWordRef.set({
        name: newWord,
        createdDateTime: ISODateTime
      })
    }

    async remove(word) {
      const { id } = word
      const wordRef = db.ref(`words/list/${id}`)

      return wordRef.remove()
    }

    async search(searchedWord = '') {
      const filterSnapshot = await db.ref('words/list').orderByChild('name').startAt(searchedWord).limitToFirst(3).once('value')
      const word = filterSnapshot.val()
      let result = []

      if (word != null) {
        result = Object.keys(word).map(wordKey => {
          return {
            id: wordKey,
            ...word[wordKey],
          }
        })
      }

      return result
    }
  }

  App.firebaseService = new FirebaseService()
  window.App = App
})()