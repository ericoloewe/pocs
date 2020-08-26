"use strict";
var Generator = require("yeoman-generator");
var chalk = require("chalk");
var yosay = require("yosay");

module.exports = Generator.extend({
  prompting: function () {
    var prompts = [];

    this.log(yosay(
      "Welcome to tccc angular generator!"
    ));

    prompts = [{
      type: "list",
      name: "action",
      message: "What generator do you want to open?",
      choices: [
        "controller",
        "directive",
        "interceptor",
        "service"
      ]
    }];

    return this.prompt(prompts).then(function (props) {
      this.props = props;

      this._resolveActualAction(this.props.action);
    }.bind(this));
  },

  _resolveActualAction: function (action) {
    switch (action) {
      case "controller": {
        this.composeWith(require.resolve("./controller/index"));
        break;
      }
      case "directive": {
        this.composeWith(require.resolve("./directive/index"));
        break;
      }
      case "interceptor": {
        this.composeWith(require.resolve("./interceptor/index"));
        break;
      }
      case "service": {
        this.composeWith(require.resolve("./service/index"));
        break;
      }
    }
  }
});
