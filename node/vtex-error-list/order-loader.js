/**
 * Order loader
 */
const moment = require("moment");
const request = require("request");
const ACCOUNT_NAME = "cokemv";
const API_URL = `https://${ACCOUNT_NAME}.vtexcommercestable.com.br/api`;
const LIST_ORDER_URL = `${API_URL}/oms/pvt/orders`;
const HEADERS = {
  "X-VTEX-API-AppKey": "vtexappkey-cokemv-ZRUXXC",
  "X-VTEX-API-AppToken": "XQNUGQQXDPFWUTYCCSCWSXVGXIYVPCTTJWKIVJHULUDYOCSPWJGXSJAAVHXXRUIAWMNYJQGTLHKYUXSUQIZGVWBAVKMOLJDQMCCBPUGGCNMKYBGXPCHJVBFZLNCYDRIB",
  "Content-Type": "application/json"
};

module.exports.loadOrderByError = function (vtexOrderError) {
  const { Instancia } = vtexOrderError;

  return loadOrderByOrderInstance(Instancia);
}

function loadOrderByOrderInstance(orderInstance) {
  return new Promise((resolve, reject) => {
    request.get({
      url: LIST_ORDER_URL,
      qs: { q: orderInstance },
      headers: HEADERS
    }, (error, response, body) => {
      if (error != null || response.statusCode !== 200) {
        console.error(`There are some error to get order`, response);
        reject(error, response)
      } else {
        resolve(JSON.parse(body), response);
      }
    })
  });
}
