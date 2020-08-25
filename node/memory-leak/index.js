let a = 0
global.b = {}
let val = 9999999999999999999999999

setInterval(() => {
    b[`${a}`] = `${val++}`
    a++
    console.log(Object.keys(b).length)
}, 10)