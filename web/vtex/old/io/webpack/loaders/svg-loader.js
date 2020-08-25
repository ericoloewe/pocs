/**
 * Webpack SVG loader
 */

export default function SVGLoader(source) {
  // TODO: Made a loader of SVG content
  if (/require(.)+[.]svg/.test(source)) {
  }

  return `module.exports = ${source}`;
}
