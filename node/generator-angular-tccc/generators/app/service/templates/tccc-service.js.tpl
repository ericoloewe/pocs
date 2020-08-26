(function () {
  "use strict";

  /**
   * @description <%= utils.changeCase.sentenceCase(serviceName) %> service method
   */
  angular.module("<%= utils.changeCase.camelCase(moduleName) %>").factory("<%= utils.changeCase.camelCase(serviceName) %>Ctl", [<% dependencies.forEach(function (dependency, index) { %>"<%= dependency %>" <% if (dependencies.length > 0) { %>, <% } %><% }); %>function (<% dependencies.forEach(function (dependency, index) { %><%= dependency %><% if (index < dependencies.length - 1) { %>, <% } %><% }); %>) {
    var <%= utils.changeCase.pascalCase(serviceName) %>Service = function() {
      /**
       * @description some method method
       */
      this.someMethod = function () {
      }
    }

    /**
     * @description some static method method
     */
    <%= utils.changeCase.pascalCase(serviceName) %>Service.prototype.someStaticMethod = function () {

    }

    return new <%= utils.changeCase.pascalCase(serviceName) %>Service();
  }]);
});
