import * as React from 'react';
import * as ReactDOM from 'react-dom';
import App from './App';
import './index.css';
import registerServiceWorker from './registerServiceWorker';

ReactDOM.render(
  <App />,
  document.getElementById('root') as HTMLElement
);

registerServiceWorker();

const electron = (window as any).require('electron')
const { ipcRenderer } = electron


ipcRenderer.on('ping', (event: any, message: any) => {
  console.info("ping", message) // Prints 'whoooooooh!'
})

ipcRenderer.on('asynchronous-reply', (event: any, message: any) => {
  console.info("asynchronous-reply", message) // Prints 'whoooooooh!'
})

ipcRenderer.send('asynchronous-message', { message: 'congrats' })