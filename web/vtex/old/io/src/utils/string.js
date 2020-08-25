/**
 * Utils > String
 */

export class StringUtil {
  static isEmpty(str) {
    return str == null
      || (typeof (str) === 'string'
        && str.length === 0);
  }
}