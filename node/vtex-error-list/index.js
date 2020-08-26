/**
 * Main file
 */
const moment = require("moment");
const ProgressBar = require("progress");
const { readErrorsFromFile } = require("./error-file-reader");
const { loadOrderByError } = require("./order-loader");
const { writeXLSX } = require("./xlsx-write");
const inquirer = require('inquirer');

const errors = readErrorsFromFile("./relatorio-erros.csv");
const progressBar = new ProgressBar(':bar :current/:total', { total: errors.length });

Promise.all(errors.map((e, i) => {
  return loadOrderByError(e).then((body, r) => {
    let order = body.list[0];
    let formatedDate = moment(order.creationDate).toDate();

    progressBar.tick();

    return [
      order.orderId, e.Instancia, order.statusDescription, order.clientName, e.ErroDetalhe.clientePfCPF, formatedDate, e.Erro.mensagem
    ];
  }).catch(console.error)
})).then(results => {
  progressBar.terminate();

  results.unshift([
    "Id do pedido", "Instancia", "Status atual", "Nome do cliente", "CPF do cliente", "Data de criação", "Motivo do erro"
  ]);

  writeXLSX(results, 'Problemas com pedidos', "relatorio-final.xlsx");
});
