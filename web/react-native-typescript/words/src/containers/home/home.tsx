import * as React from "react";
import { Container, Content, Header, Title, Body } from 'native-base';
import Icon from 'react-native-vector-icons/MaterialIcons';
import ActionButton from 'react-native-action-button';
import { WordList } from "../../components/index";
import { styles } from "./home.styles";

export class Home extends React.Component<HomeProps, HomeStates> {

    public constructor() {
        super();
    }
    /**
     * @description render the template
     */
    public render() {
        return (
            <Container>
                <Header>
                    <Body>
                        <Title style={styles.container__header__body__title}>
                            Welcome to words app!
                        </Title>
                    </Body>
                </Header>
                <Content>
                    <WordList />
                </Content>
                <ActionButton buttonColor="#e74c3c" btnOutRange="#FF7F6F" degrees={0} onPress={() => this.goToWordForm()}>
                    <Icon name="add" />
                </ActionButton>
            </Container>
        );
    }

    private goToWordForm() {
    }
}

export { Home as Component };
