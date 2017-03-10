declare module "react-native-vector-icons" {
    namespace ReactNativeVectorIcons {
        interface Icon extends React.TextProperties {
            name?: string,
            android?: string,
            ios?: string,
            style?: React.TextStyle
        }
    }
    export class Icon extends React.Component<ReactNativeVectorIcons.Icon, any> { }
}
declare module "react-native-vector-icons/FontAwesome" {
    namespace ReactNativeVectorFontAwesome {
        interface Icon extends React.TextProperties {
            name?: string,
            android?: string,
            ios?: string,
            style?: React.TextStyle
        }
    }
    export default class Icon extends React.Component<ReactNativeVectorFontAwesome.Icon, any> { }
}
declare module "react-native-vector-icons/MaterialIcons" {
    namespace ReactNativeVectorMaterialIcons {
        interface Icon extends React.TextProperties {
            name?: string,
            android?: string,
            ios?: string,
            style?: React.TextStyle
        }
    }
    export default class Icon extends React.Component<ReactNativeVectorMaterialIcons.Icon, any> { }
}
