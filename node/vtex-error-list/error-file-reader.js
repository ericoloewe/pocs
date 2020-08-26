/**
 * Read Errors From File
 */
const fs = require('fs');

module.exports.readErrorsFromFile = function (file) {
  const reportFile = fs.readFileSync(file);
  const lines = reportFile.toString().split("\n");
  const firstLine = lines.shift().split(";");

  return lines
    .filter(line => typeof (line) === "string" && line.length > 0)
    .map(line => {
      return line.split(";").reduce((p, n, i) => {
        const ACTUAL_PROP = firstLine[i];

        if (ACTUAL_PROP === "Erro" || ACTUAL_PROP === "ErroDetalhe") {
          try {
            p[ACTUAL_PROP] = JSON.parse(n);
          } catch (ex) {
            p[ACTUAL_PROP] = n;
          }
        } else {
          p[ACTUAL_PROP] = n;
        }

        return p;
      }, {});
    });
}
