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
      name: "interceptorName",
      message: "What the name of interceptor?"
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
      "Welcome to tccc angular interceptor generator!"
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
      this.templatePath("tccc-interceptor.js.tpl"),
      this.destinationPath(this._resolveScriptInterceptorPath(this.props.interceptorName)),
      {
        moduleName: this.props.moduleName,
        interceptorName: this.props.interceptorName,
        dependencies: this.props.dependencies.split(","),
        utils: {
          changeCase: changeCase
        }
      }
    );
  },

  _resolveScriptInterceptorPath: function (interceptorName) {
    return this.configs.PATHS.APP.SCRIPTS.INTERCEPTORS
      + "/" + changeCase.paramCase(interceptorName)
      + ".js";
  }
});
