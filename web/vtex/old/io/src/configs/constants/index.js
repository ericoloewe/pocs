/**
 * Constants
 */

import { ObjectUtil } from "../../utils";

export class Constants {
  static getLoadedInstance() {
    if (Constants._instance == null) {
      Constants._instance = new Constants();
      Constants._instance.loadAll();
    }

    return Constants._instance;
  }

  loadAll() {
    this.CONSTANTS = {
      GENERAL: require("./general.json")
    }
  }

  static getAll() {
    return Constants.getLoadedInstance().CONSTANTS;
  }

  static getSafe(callback, defaultValue = null) {
    return ObjectUtil.getNullSafe(callback, defaultValue, [Constants.getAll()]);
  }
}

export { Constants as Config }
