/**
 * @description actions for routes
 */
export class RouteActions {
    public static CHANGE_ROUTE = "CHANGE_ROUTE";

    /**
     * @description generate
     */
    public generate() {
        return {
            changeRoute: this.changeRoute
        };
    }

    /**
     * @description Change route
     */
    public changeRoute(scene: any): ChangeRouteAction {
        return {
            type: RouteActions.CHANGE_ROUTE,
            scene
        };
    }
}
