/**
 * Enviroment configuration
 */

export class EnviromentConfiguration {
  static isDev() {
    let env = EnviromentConfiguration._getCurrentEnv();

    return env == null
      || env == "development";
  }

  static isPrd() {
    let env = EnviromentConfiguration._getCurrentEnv();

    return env == "production";
  }

  static _getCurrentEnv() {
    return process.env.NODE_ENV;
  }
}

export { EnviromentConfiguration as EnvConfig };
