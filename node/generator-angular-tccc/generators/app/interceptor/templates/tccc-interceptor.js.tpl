(function () {
  "use strict";

  /**
   * @description <%= utils.changeCase.sentenceCase(interceptorName) %> interceptor method
   */
  angular.module("<%= utils.changeCase.camelCase(moduleName) %>").factory("<%= utils.changeCase.camelCase(interceptorName) %>Ctl", [<% dependencies.forEach(function (dependency, index) { %>"<%= dependency %>" <% if (dependencies.length > 0) { %>, <% } %><% }); %>function (<% dependencies.forEach(function (dependency, index) { %><%= dependency %><% if (index < dependencies.length - 1) { %>, <% } %><% }); %>) {
    var <%= utils.changeCase.pascalCase(interceptorName) %>Interceptor = function() {
    }

    /**
     * @description request method
     */
    <%= utils.changeCase.pascalCase(interceptorName) %>Interceptor.prototype.request = function (config) {
      return config;
    }

    /**
     * @description requestError method
     */
    <%= utils.changeCase.pascalCase(interceptorName) %>Interceptor.prototype.requestError = function (rejection) {
      return $q.reject(rejection);
    }

    /**
     * @description response method
     */
    <%= utils.changeCase.pascalCase(interceptorName) %>Interceptor.prototype.response = function (response) {
      return response;
    }

    /**
     * @description responseError method
     */
    <%= utils.changeCase.pascalCase(interceptorName) %>Interceptor.prototype.responseError = function (rejection) {
      return $q.reject(rejection);
    }

    return new <%= utils.changeCase.pascalCase(interceptorName) %>Interceptor();
  }]);
});
