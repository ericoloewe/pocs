import { Reducer } from "redux";
import { Routes } from "../configs/routes";
import { RouteActions } from "../actions";

/**
 * @description reducers for routes
 */
export class RouteReducer {
    private _defaultState: RouteState;

    public constructor() {
        this._defaultState = {
            actualRoute: Routes.defaultRoute()
        };
    }

    /**
     * @description generate
     */
    public generate(): Reducer<RouteState> {
        return (state: RouteState, action: DefaultAction) => {
            let nextState = Object.assign({}, this._defaultState);

            if (state !== undefined) {
                nextState = Object.assign({}, state);

                switch (action.type) {
                    case RouteActions.CHANGE_ROUTE: {
                        // TODO: change route
                        break;
                    }
                }
            }

            return nextState;
        };
    }
}
