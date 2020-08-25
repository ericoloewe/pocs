(function () {
  "use strict";

  /**
   * @description <%= utils.changeCase.sentenceCase(directiveName) %> directive method
   */
  angular.module("<%= utils.changeCase.camelCase(moduleName) %>").directive("<%= utils.changeCase.camelCase(directiveName) %>", [<% dependencies.forEach(function (dependency, index) { %>"<%= dependency %>" <% if (dependencies.length > 0) { %>, <% } %><% }); %>function (<% dependencies.forEach(function (dependency, index) { %><%= dependency %><% if (index < dependencies.length - 1) { %>, <% } %><% }); %>) {
    var directive = {
      restrict: '<%= options.restrict %>',
      templateUrl: '<%= options.templateUrl %>',
      controller: '<%= utils.changeCase.camelCase(directiveName) %>Ctl'
    }

    return directive;
  }])

  /**
   * @description <%= utils.changeCase.sentenceCase(directiveName) %> controller method
   */
  angular.module("<%= utils.changeCase.camelCase(moduleName) %>").controller("<%= utils.changeCase.camelCase(directiveName) %>Ctl", [<% controllerDependencies.forEach(function (dependency, index) { %>"<%= dependency %>" <% if (controllerDependencies.length > 0) { %>, <% } %><% }); %>function (<% controllerDependencies.forEach(function (dependency, index) { %><%= dependency %><% if (index < controllerDependencies.length - 1) { %>, <% } %><% }); %>) {
    var <%= utils.changeCase.pascalCase(directiveName) %>Ctl = function() {
      resetScope();
      bindEvents();
    }

    function resetScope() {

    }

    function bindEvents() {

    }

    new <%= utils.changeCase.pascalCase(directiveName) %>Ctl();
  }]);
});
