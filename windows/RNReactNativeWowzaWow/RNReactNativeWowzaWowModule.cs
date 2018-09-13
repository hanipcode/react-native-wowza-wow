using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Wowza.Wow.RNReactNativeWowzaWow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeWowzaWowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeWowzaWowModule"/>.
        /// </summary>
        internal RNReactNativeWowzaWowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeWowzaWow";
            }
        }
    }
}
