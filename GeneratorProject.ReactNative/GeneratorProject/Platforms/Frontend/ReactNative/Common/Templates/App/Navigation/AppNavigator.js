import { createSwitchNavigator } from 'react-navigation';

import AuthLoadingScreen from '../Screens/Auth/AuthLoadingScreen';
import AuthStackNavigator from './AuthStackNavigator';
import AppMainStackNavigator from './AppMainStackNavigator';

export default createSwitchNavigator({
    AuthLoading: AuthLoadingScreen,
    Auth: AuthStackNavigator,
    App: AppMainStackNavigator
},
  {
    initialRouteName: 'AuthLoading'
  }
);