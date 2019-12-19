import React, { Component } from 'react';
import { Provider } from 'react-redux';
import { createAppContainer } from 'react-navigation';

import AppNavigator from './Navigation/AppNavigator';
import ConfigureStore from './Store/ConfigureStore';
import initalState from './Reducers/InitialState';

// create application's container
const AppContainer = createAppContainer(AppNavigator);

// create application's store
const store = ConfigureStore(initalState);

export default class App extends Component {
    render() {
        return (
            <Provider store={store}>
                <AppContainer />
            </Provider>
        );
    }
}
