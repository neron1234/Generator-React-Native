import React, { Component } from 'react';
import { Provider } from 'react-redux';

import AppNavigator from './Navigation/AppNavigator';
import ConfigureStore from './Store/ConfigureStore';
import initalState from './Reducers/InitialState';

// create application's store
const store = ConfigureStore(initalState);

export default class App extends Component {
  render() {
    return (
      <Provider store={store}>
        <AppNavigator />
      </Provider>
    );
  }
}
