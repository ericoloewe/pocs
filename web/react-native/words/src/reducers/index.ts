import { combineReducers } from "redux";
import { RouteReducer } from "./route";

export default combineReducers({
    route: new RouteReducer().generate()
});

export { RouteReducer };
