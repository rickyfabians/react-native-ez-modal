using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Ez.Modal.RNEzModal
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNEzModalModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNEzModalModule"/>.
        /// </summary>
        internal RNEzModalModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNEzModal";
            }
        }
    }
}
