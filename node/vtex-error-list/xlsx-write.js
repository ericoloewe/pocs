/* require XLSX */
// https://gist.github.com/SheetJSDev/88a3ca3533adf389d13c
const XLSX = require('XLSX');

module.exports.writeXLSX = function (matrix, wsName, fileName, sheetOptions = { dateNF: "DD/MM/YYYY hh:ss:ss" }) {
  const wb = { Sheets: {}, SheetNames: [] };
  const sheets = XLSX.utils.aoa_to_sheet(matrix);

  wb.Sheets[wsName] = sheets;
  wb.SheetNames.push(wsName);

  XLSX.writeFile(wb, fileName);

  return wb;
}
