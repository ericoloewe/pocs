const babelRegister = require('babel-register');
const { app } = require('./src/app');
const PORT = process.env.PORT || 3000;

app.listen(PORT, function() {
	console.log('Server listening on port', PORT);
});