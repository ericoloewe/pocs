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
      name: "serviceName",
      message: "What the name of service?"
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
      "Welcome to tccc angular service generator!"
    ));
  },

  writing: function () {
    this._writeTemplates();
  },

  _writeTemplates: function () {
    this._writeScriptTemplates();
  },

  _writeScriptTemplates: function () {
    this.fs.copyTpl(
      this.templatePath("tccc-service.js.tpl"),
      this.destinationPath(this._resolveScriptServicePath(this.props.serviceName)),
      {
        moduleName: this.props.moduleName,
        serviceName: this.props.serviceName,
        dependencies: this.props.dependencies.split(","),
        utils: {
          changeCase: changeCase
        }
      }
    );
  },

  _resolveScriptServicePath: function (serviceName) {
    return this.configs.PATHS.APP.SCRIPTS.SERVICES
      + "/" + changeCase.paramCase(serviceName)
      + ".js";
  }
});
