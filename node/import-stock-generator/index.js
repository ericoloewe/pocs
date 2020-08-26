/**
 * Main file
 */
const fs = require('fs');

const productsFile = fs.readFileSync('./products.txt');
const storesFile = fs.readFileSync('./stores.txt');
const products = productsFile.toString().split("\n");
const stores = storesFile.toString().split(";");
const AMOUNT_OF_PRODUCTS = 30;
let generatedFileData = 'CODIGO_LOJA;SKU;QTDE_TOTAL\n';

generatedFileData += stores.reduce((ps, ns) => `${ps}${products.map(p => p.replace('\r', '')).reduce((pp, np) => `${pp}${ns};${np};${AMOUNT_OF_PRODUCTS}\n`, '')}\n`, '');
// generatedFileData += products.map(p => p.replace('\r', '')).reduce((pp, np) => `${pp}${stores.reduce((ps, ns) => `${ps}${ns};${np};${AMOUNT_OF_PRODUCTS}\n`, '')}`, '');

fs.writeFileSync('./generated.txt', generatedFileData);