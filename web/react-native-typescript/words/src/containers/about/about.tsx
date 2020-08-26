import * as React from "react";
import { View, Text } from "react-native";
import { styles } from "./about.styles";

export class About extends React.Component<any, any> {
    /**
     * @description render the template
     */
    public render() {
        return (
            <View style={styles.container}>
                <Text style={styles.welcome}>
                    About our project :)
                </Text>
            </View>
        );
    }
}

export { About as Component };
