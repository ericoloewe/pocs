import * as React from "react";
import { ListItem, Text } from 'native-base';

export class WordItem extends React.Component<WordItemProps, WordItemStates> {
    /**
     * @description render the template
     */
    public render() {
        return (
            <ListItem>
                <Text>
                    {`${this.props.id} - ${this.props.name}`}
                </Text>
            </ListItem>
        );
    }
}
