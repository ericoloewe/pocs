/**
 * @description the Bootstrap of application.
 */
var Bootstrap = (function () {
    function Bootstrap() {
        this.load();
    }
    Bootstrap.prototype.load = function () {
        System.import("scripts/app.js")
            .catch(function (err) {
            console.error(err);
        });
    };
    return Bootstrap;
}());
new Bootstrap();
//# sourceMappingURL=bootstrap.js.map