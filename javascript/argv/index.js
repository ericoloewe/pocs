const _envIndex = process.argv.indexOf('-env'), __envIndex = process.argv.indexOf('--env')
let env = null

if (_envIndex >= 0) {
  env = process.argv[_envIndex + 1]
} else if (__envIndex >= 0) {
  env = process.argv[__envIndex + 1]
}

console.log(env);
