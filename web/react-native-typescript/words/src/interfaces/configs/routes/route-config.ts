/**
 * @description interface for route configuration
 */
interface RouteConfig {
    key: string;
    component: string;
    scenes: Array<RouteConfig>;
    initial: boolean;
    hideNavBar: boolean;
}
