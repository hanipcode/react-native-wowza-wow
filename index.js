
import { NativeModules, requireNativeComponent } from 'react-native';

const { RNReactNativeWowzaWow } = NativeModules;

export const LabelView = requireNativeComponent('RNWowzaWowView');
export default RNReactNativeWowzaWow;
