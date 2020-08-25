/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow
 */

import React from 'react';
import { Component } from 'react';
import { StyleSheet, Text, View } from 'react-native';

type Props = {};
type States = {
  modules: Array<{ status: string }>
};

export class DashboardContainer extends Component<Props, States> {
  state = {
    modules: []
  }

  componentDidMount() {
    this._load()
  }

  async _load() {
    const response = await fetch('https://apigateway.vtex.com/healthcheck/modules')
    const modules = await response.json()

    console.log(modules);

    this.setState(() => ({ modules }))
  }

  render() {
    const { modules } = this.state

    const healthModules = modules.filter(m => m.status === 'healthy')
    const healthModulesLength = healthModules.length
    const modulesLength = modules.length

    return (
      <View style={styles.container}>
        <Text>✅</Text>
        <Text style={styles.welcome}>
          {healthModulesLength}/{modulesLength} modulos de funcionando corretamente
        </Text>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
  welcome: {
    fontSize: 20,
    textAlign: 'center',
    margin: 10,
  },
  instructions: {
    textAlign: 'center',
    color: '#333333',
    marginBottom: 5,
  },
});
