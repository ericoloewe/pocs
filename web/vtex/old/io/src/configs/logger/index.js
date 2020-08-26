/**
 * @description logger
 */

import { Config } from "../constants";

const { ENABLED, COMPLEX } = Config.getSafe(c => c.GENERAL.LOG);

export class Logger {
  constructor(actualInstance) {
    this.actualInstance = actualInstance
  }

  log() {
    this._logOfType("log", this._parseToArray(arguments));
  }

  debug() {
    this._logOfType("debug", this._parseToArray(arguments));
  }

  info() {
    this._logOfType("info", this._parseToArray(arguments));
  }

  warn() {
    this._logOfType("warn", this._parseToArray(arguments));
  }

  error() {
    this._logOfType("error", this._parseToArray(arguments));
  }

  _logOfType(type, args) {
    if (ENABLED) {
      let defaultLog = [];

      if (COMPLEX) {
        let instanceName = "Logger";

        if (typeof (this.actualInstance) === "object") {
          instanceName = this.actualInstance.name;
        } else if (typeof (this.actualInstance) === "string") {
          instanceName = this.actualInstance;
        }

        defaultLog = [
          ...defaultLog,
          `${new Date()}: ${type.toUpperCase()}`,
          `${instanceName}:`
        ];
      }

      console[type].apply(console, defaultLog.concat(args));
    }
  }

  _parseToArray(args) {
    const array = [];

    for (let index = 0; index < args.length; index++) {
      array.push(args[index]);
    }

    return array;
  }
}
