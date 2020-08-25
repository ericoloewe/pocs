(() => {
  'use strict';

  const App = window.App || {}
  const searchInputNode = document.getElementById('searchInput')
  const searchResultNode = document.getElementById('searchResult')
  let timeoutId = null

  class SearchComponent {
    constructor() {
      this._bindEvents()
      this._isSavingWord = false
    }

    _bindEvents() {
      searchInputNode.addEventListener('keypress', e => {
        clearTimeout(timeoutId)

        timeoutId = setTimeout(() => {
          if (!this._isSavingWord) {
            this._searchForSearchedWordAndShowAtScreen(e.target.value)
          }
        }, 500)
      })
    }

    _clearSearchResult() {
      while (searchResultNode.hasChildNodes()) {
        searchResultNode.removeChild(searchResultNode.lastChild)
      }
    }

    _createAskForNewWordElementNode(searchedWord) {
      const questionNode = document.createElement('li')
      const createNewWordButtonNode = document.createElement('button')

      questionNode.classList += 'list-group-item'
      questionNode.innerText = `A palavra "${searchedWord}" não existe em nossa base `
      createNewWordButtonNode.classList += 'add-button btn btn-primary'
      createNewWordButtonNode.innerText = 'Criar palavra'
      createNewWordButtonNode.addEventListener('click', e => this._saveNewWord(questionNode, searchedWord))
      questionNode.appendChild(createNewWordButtonNode)

      return questionNode
    }

    _createWordElementNode(word) {
      const wordNode = document.createElement('li')
      const removeWordButtonNode = document.createElement('button')

      wordNode.classList += 'list-group-item'
      wordNode.innerText = word.name
      removeWordButtonNode.classList += 'remove-button btn btn-danger'
      removeWordButtonNode.innerText = 'Remover palavra'
      removeWordButtonNode.addEventListener('click', e => this._removeWord(wordNode, word))
      wordNode.appendChild(removeWordButtonNode)

      return wordNode
    }

    async _removeWord(wordNode, word) {
      this._isSavingWord = true
      wordNode.innerHTML = `Salvando palavra "${word.name}"...`
      wordNode.classList += ' list-group-item-info'

      try {
        await App.firebaseService.remove(word)
        wordNode.innerText = `Palavra "${word.name}" removida com sucesso!`
        wordNode.classList += ' list-group-item-success'
      } catch (ex) {
        wordNode.innerText = `Tivemos problemas ao remover a palavra "${word.name}"`
        wordNode.classList += ' list-group-item-danger'
        console.error('Stack: ', ex)
      }

      setTimeout(() => {
        this._clearSearchResult()
        this._isSavingWord = false
      }, 5000)
    }

    async _saveNewWord(questionNode, searchedWord) {
      this._isSavingWord = true
      questionNode.innerHTML = `Salvando palavra "${searchedWord}"...`
      questionNode.classList += ' list-group-item-info'

      try {
        await App.firebaseService.add(searchedWord)
        questionNode.innerText = `Palavra "${searchedWord}" salva com sucesso!`
        questionNode.classList += ' list-group-item-success'
      } catch (ex) {
        questionNode.innerText = `Tivemos problemas ao salvar a palavra "${searchedWord}"`
        questionNode.classList += ' list-group-item-danger'
        console.error('Stack: ', ex)
      }

      setTimeout(() => {
        this._clearSearchResult()
        this._isSavingWord = false
      }, 5000)
    }

    async _searchForSearchedWordAndShowAtScreen(searchedWord) {
      const words = await App.firebaseService.search(searchedWord)

      if (words.length > 0) {
        this._showWordsAtScreen(words)
      } else {
        this._showAskByNewWord(searchedWord)
      }
    }

    _showAskByNewWord(searchedWord) {
      this._clearSearchResult()
      searchResultNode
        .appendChild(this._createAskForNewWordElementNode(searchedWord))
    }

    _showWordsAtScreen(words) {
      this._clearSearchResult()
      words
        .map(word => this._createWordElementNode(word))
        .forEach(wn => searchResultNode.appendChild(wn))
    }
  }

  App.searchComponent = new SearchComponent()
  window.App = App
})()