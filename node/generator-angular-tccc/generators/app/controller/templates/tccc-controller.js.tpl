(function () {
  "use strict";

  /**
   * @description <%= utils.changeCase.sentenceCase(controllerName) %> controller method
   */
  angular.module("<%= utils.changeCase.camelCase(moduleName) %>").controller("<%= utils.changeCase.camelCase(controllerName) %>Ctl", [<% dependencies.forEach(function (dependency, index) { %>"<%= dependency %>" <% if (dependencies.length > 0) { %>, <% } %><% }); %>function (<% dependencies.forEach(function (dependency, index) { %><%= dependency %><% if (index < dependencies.length - 1) { %>, <% } %><% }); %>) {
    var <%= utils.changeCase.pascalCase(controllerName) %>Ctl = function() {
      resetScope();
      bindEvents();
    }

    function resetScope() {

    }

    function bindEvents() {

    }

    new <%= utils.changeCase.pascalCase(controllerName) %>Ctl();
  }]);
});
