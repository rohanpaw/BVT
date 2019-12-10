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

namespace TestProject.Recording_Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_AC_Units_Calculation_for_Base recording.
    /// </summary>
    [TestModule("7e18e2f7-e0da-42dc-8d17-d5c59120acf2", ModuleType.Recording, 1)]
    public partial class Verify_AC_Units_Calculation_for_Base : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_AC_Units_Calculation_for_Base instance = new Verify_AC_Units_Calculation_for_Base();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_AC_Units_Calculation_for_Base()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_AC_Units_Calculation_for_Base Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro32xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AssignDeviceBase("801 CH - 1", "5BI 5\" [517.050.018]", "13");
            Delay.Milliseconds(0);
            
            //Libraries.AC_Functions.verifyACUnitsValue("1.2");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("1", "Signal (AC Units)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AssignAdditionalBase("801 CH - 1", "801SB [516.800.907] @ 90dB", "13");
            Delay.Milliseconds(0);
            
            //Libraries.AC_Functions.verifyACUnitsValue("3.6");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("3.6", "Signal (AC Units)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RemoveBase("801 CH - 1", "13");
            Delay.Milliseconds(0);
            
            //Libraries.AC_Functions.verifyACUnitsValue("1");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("1", "Signal (AC Units)");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
