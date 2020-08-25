(() => {
  'use strict';

  const App = window.App || {}
  const db = firebase.database()

  class FirebaseService {
    async add(newWord = '') {
      // TODO: add new word to firebase
    }

    async remove(word) {
      // TODO: remove word of firebase
    }

    async search(searchedWord = '') {
      // TODO: take 3 similar words from firebase
      return []
    }
  }

  App.firebaseService = new FirebaseService()
  window.App = App
})()