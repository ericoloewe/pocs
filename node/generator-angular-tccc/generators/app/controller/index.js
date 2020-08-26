"use strict";
var Generator = require("yeoman-generator");
var chalk = require("chalk");
var yosay = require("yosay");
var changeCase = require("change-case");

module.exports = Generator.extend({
  init: function () {
    this.configs = this.config.getAll();
  },

  prompting: function () {
    this.promptWelcome();

    return this.prompt([{
      type: "input",
      name: "moduleName",
      message: "What the name of module?",
      default: "app"
    }, {
      type: "input",
      name: "controllerName",
      message: "What the name of controller?"
    }, {
      type: "input",
      name: "dependencies",
      message: "What dependencies do you want to use? (separate with comma [,])",
      default: "$scope"
    }]).then(function (props) {
      this.props = props;
    }.bind(this));
  },

  promptWelcome: function () {
    this.log(yosay(
      "Welcome to tccc angular controller generator!"
    ));
  },

  writing: function () {
    this._writeTemplates();
    this._configureStates(this.props.controllerName);
  },

  _writeTemplates: function () {
    this._writeScriptTemplates();
    this._writeStyleTemplates();
    this._writeViewTemplates();
  },

  _writeScriptTemplates: function () {
    this.fs.copyTpl(
      this.templatePath("tccc-controller.js.tpl"),
      this.destinationPath(this._resolveScriptControllerPath(this.props.controllerName)),
      {
        moduleName: this.props.moduleName,
        controllerName: this.props.controllerName,
        dependencies: this.props.dependencies.split(","),
        utils: {
          changeCase: changeCase
        }
      }
    );
  },

  _writeStyleTemplates: function () {
    this.fs.copyTpl(
      this.templatePath("tccc-controller.scss.tpl"),
      this.destinationPath(this._resolveStyleControllerPath(this.props.controllerName)),
      {
        moduleName: this.props.moduleName,
        controllerName: this.props.controllerName,
        dependencies: this.props.dependencies.split(","),
        utils: {
          changeCase: changeCase
        }
      }
    );
  },

  _writeViewTemplates: function () {
    this.fs.copyTpl(
      this.templatePath("tccc-controller.pug.tpl"),
      this.destinationPath(this._resolveViewControllerPath(this.props.controllerName)),
      {
        moduleName: this.props.moduleName,
        controllerName: this.props.controllerName,
        dependencies: this.props.dependencies.split(","),
        utils: {
          changeCase: changeCase
        }
      }
    );
  },

  _configureStates: function (controllerName) {
    var newState = {};
    var states = this.fs.readJSON(this.configs.PATHS.CONFIGS.APP.STATES);

    newState.name = changeCase.paramCase(controllerName);
    newState.url = "/" + changeCase.paramCase(controllerName);
    newState.controller = changeCase.pascalCase(controllerName) + "Ctl";
    newState.templateUrl = this._resolveTemplateUrlPath(controllerName);

    states[changeCase.constant(controllerName)] = newState;

    this.fs.writeJSON(this.configs.PATHS.CONFIGS.APP.STATES, states);
  },

  _resolveScriptControllerPath: function (controllerName) {
    return this.configs.PATHS.APP.SCRIPTS.CONTROLLERS
      + "/" + changeCase.paramCase(controllerName)
      + ".js";
  },

  _resolveStyleControllerPath: function (controllerName) {
    return this.configs.PATHS.APP.STYLES.CONTROLLERS
      + "/" + changeCase.paramCase(controllerName)
      + ".scss";
  },

  _resolveViewControllerPath: function (controllerName) {
    return this.configs.PATHS.APP.VIEWS.CONTROLLERS
      + "/" + changeCase.paramCase(controllerName)
      + ".pug";
  },

  _resolveTemplateUrlPath: function (controllerName) {
    return this.configs.PATHS.DIST.VIEWS.CONTROLLERS
      + "/" + changeCase.paramCase(controllerName)
      + ".html";
  }
});
