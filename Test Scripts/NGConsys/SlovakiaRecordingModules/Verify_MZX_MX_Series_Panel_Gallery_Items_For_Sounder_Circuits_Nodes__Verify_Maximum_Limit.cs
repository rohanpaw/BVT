﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TestProject.SlovakiaRecordingModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_MZX_MX_Series_Panel_Gallery_Items_For_Sounder_Circuits_Nodes__Verify_Maximum_Limit recording.
    /// </summary>
    [TestModule("93ad9ad7-f075-4a47-99f8-6517e877c5a3", ModuleType.Recording, 1)]
    public partial class Verify_MZX_MX_Series_Panel_Gallery_Items_For_Sounder_Circuits_Nodes__Verify_Maximum_Limit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_MZX_MX_Series_Panel_Gallery_Items_For_Sounder_Circuits_Nodes__Verify_Maximum_Limit instance = new Verify_MZX_MX_Series_Panel_Gallery_Items_For_Sounder_Circuits_Nodes__Verify_Maximum_Limit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_MZX_MX_Series_Panel_Gallery_Items_For_Sounder_Circuits_Nodes__Verify_Maximum_Limit()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_MZX_MX_Series_Panel_Gallery_Items_For_Sounder_Circuits_Nodes__Verify_Maximum_Limit Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "MZX252", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Sounder Circuit1");
            Delay.Milliseconds(0);
            
            // Sounders
            Libraries.Gallery_Functions.verifyGalleryListItems("Gallery_Sounder_FIM", "Slovakia", "Generic Sounder");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Generic Sounder", "");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("SB520", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.VerifyNavigationTreeItemText("Sounder Circuit1 (2)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Sounder Circuit2");
            Delay.Milliseconds(0);
            
            // Sounders
            Libraries.Gallery_Functions.verifyGalleryListItems("Gallery_Sounder_FIM", "Slovakia", "Generic Sounder");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Generic Sounder", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.VerifyNavigationTreeItemText("Sounder Circuit2 (1)");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
