import { Platform } from "react-native";
import { AndroidApp } from "./android-app/android-app";
import { IosApp } from "./ios-app/ios-app";

let mainApp = AndroidApp;

if (Platform.OS === "ios") {
    mainApp = IosApp;
}

export { mainApp as Main };
export { AndroidApp, AndroidApp as MainAndroid };
export { IosApp, IosApp as MainIos };
export { Home } from "./home/home";
export { About } from "./about/about";
