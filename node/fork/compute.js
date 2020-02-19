console.log(`Worker ${process.pid} started`);

const longComputation = () => {
  let sum = 0;
  for (let i = 0; i < 1e9; i++) {
    sum += i;
  };
  return sum;
};

process.on('message', (msg) => {
  const sum = longComputation();
  process.send(sum);
  console.log(`Worker ${process.pid} finished`);
  process.exit(0);
});