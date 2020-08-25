/**
 * @description the Bootstrap of application.
 */
class Bootstrap {
    constructor() {
        this.load();
    }

    private load() {
        System.import("scripts/app.js")
            .catch((err) => {
                console.error(err);
            });
    }
}

new Bootstrap();
