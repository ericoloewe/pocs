const { spawn } = require('child_process')

const cp = spawn("D:\\Codigos\\repositorios\\coke\\vtex-deploy\\node_modules\\chromedriver\\lib\\chromedriver\\chromedriver.exe", [])

cp.stdout.on('data', (data) => console.log(data.toString()))
cp.stderr.pipe(process.stderr)

cp.on('close', console.log)

setTimeout(() => cp.kill(), 10000)