const cluster = require('cluster');
const http = require('http');
const numeroDeCPUs = require('os').cpus().length;

function grandeSoma() {
  let soma = 0;

  for (let i = 0; i < 1e10; i++) {
    soma += i;
  }

  return soma;
}

if (cluster.isMaster) {
  rodarPrincipal();
} else {
  rodarWorker();
}

function rodarPrincipal() {
  console.log(`Master ${process.pid} is running`);

  for (let i = 0; i < numeroDeCPUs; i++) {
    cluster.fork();
  }

  cluster.on('exit', (worker, codigo, sinal) => {
    console.log(`Worker ${worker.process.pid} morreu`);
  });
}

function rodarWorker() {
  console.log(`Worker ${process.pid} iniciou`);

  http.createServer((request, response) => {
    response.writeHead(200);
    if (request.url === '/grande-soma') {
      const soma = grandeSoma();
      response.end(`processo ${process.pid} falou oi com soma: ${soma}!`);
    }
    else {
      response.end(`processo ${process.pid} falou oi!`);
    }
  }).listen(3000);
}
