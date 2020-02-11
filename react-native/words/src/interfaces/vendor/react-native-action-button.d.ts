declare module "react-native-action-button" {
    namespace ReactNativeActionButton {
        interface ActionButton extends React.TextProperties {
            buttonColor?: string;
            btnOutRange?: string;
            backdrop?: boolean;
            backgroundTappable?: boolean;
            degrees?: number;
            Item?: ActionButtonItem;
        }
        interface ActionButtonItem extends React.TextProperties {
            buttonColor?: string;
        }
    }
    export default class ActionButton extends React.Component<ReactNativeActionButton.ActionButton, any> { }
}
