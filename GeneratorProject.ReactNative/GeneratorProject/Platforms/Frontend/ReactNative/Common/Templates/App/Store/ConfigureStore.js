﻿import { createStore, applyMiddleware } from 'redux';
import thunk from 'redux-thunk';

import rootReducer from '../Reducers';

export default function configureStore(initialState) {
    const middlewares = [thunk];
    return createStore(
        rootReducer,
        initialState,
        applyMiddleware(...middlewares)
    );
}