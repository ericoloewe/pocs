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
      name: "directiveName",
      message: "What the name of directive?"
    }, {
      type: "input",
      name: "dependencies",
      message: "What dependencies do you want to use? (separate with comma [,])",
      default: "$scope"
    }, {
      type: "input",
      name: "controllerDependencies",
      message: "What controller dependencies do you want to use? (separate with comma [,])",
      default: "$scope"
    }]).then(function (props) {
      this.props = props;
    }.bind(this));
  },

  promptWelcome: function () {
    this.log(yosay(
      "Welcome to tccc angular directive generator!"
    ));
  },

  writing: function () {
    this._writeTemplates();
  },

  _writeTemplates: function () {
    this._writeScriptTemplates();
    this._writeStyleTemplates();
    this._writeViewTemplates();
  },

  _writeScriptTemplates: function () {
    this.fs.copyTpl(
      this.templatePath("tccc-directive.js.tpl"),
      this.destinationPath(this._resolveScriptDirectivePath(this.props.directiveName)),
      {
        moduleName: this.props.moduleName,
        directiveName: this.props.directiveName,
        dependencies: this.props.dependencies.split(","),
        utils: {
          changeCase: changeCase
        }
      }
    );
  },

  _writeStyleTemplates: function () {
    this.fs.copyTpl(
      this.templatePath("tccc-directive.scss.tpl"),
      this.destinationPath(this._resolveStyleDirectivePath(this.props.directiveName)),
      {
        moduleName: this.props.moduleName,
        directiveName: this.props.directiveName,
        dependencies: this.props.dependencies.split(","),
        utils: {
          changeCase: changeCase
        }
      }
    );
  },

  _writeViewTemplates: function () {
    this.fs.copyTpl(
      this.templatePath("tccc-directive.pug.tpl"),
      this.destinationPath(this._resolveViewDirectivePath(this.props.directiveName)),
      {
        moduleName: this.props.moduleName,
        directiveName: this.props.directiveName,
        dependencies: this.props.dependencies.split(","),
        utils: {
          changeCase: changeCase
        }
      }
    );
  },

  _resolveScriptDirectivePath: function (directiveName) {
    return this.configs.PATHS.APP.SCRIPTS.DIRECTIVES
      + "/" + changeCase.paramCase(directiveName)
      + ".js";
  },

  _resolveStyleDirectivePath: function (directiveName) {
    return this.configs.PATHS.APP.STYLES.DIRECTIVES
      + "/" + changeCase.paramCase(directiveName)
      + ".scss";
  },

  _resolveViewDirectivePath: function (directiveName) {
    return this.configs.PATHS.APP.VIEWS.DIRECTIVES
      + "/" + changeCase.paramCase(directiveName)
      + ".pug";
  },

  _resolveTemplateUrlPath: function (directiveName) {
    return this.configs.PATHS.DIST.VIEWS.DIRECTIVES
      + "/" + changeCase.paramCase(directiveName)
      + ".html";
  }
});
