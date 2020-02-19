const http = require('http');
const { fork } = require('child_process');

console.log(`Master ${process.pid} is running`);

http.createServer((request, response) => {
  if (request.url === '/compute') {
    const compute = fork('compute.js');

    compute.send('start');
    compute.on('message', sum => {
      response.end(`Sum is ${sum}`);
    });
  } else {
    response.end('Ok')
  }
}).listen(3000);
