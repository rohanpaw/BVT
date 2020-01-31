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
    ///The Verify_voltage_drop_calculation recording.
    /// </summary>
    [TestModule("5da1e640-b101-444f-8501-f5f761aeb59e", ModuleType.Recording, 1)]
    public partial class Verify_voltage_drop_calculation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_voltage_drop_calculation instance = new Verify_voltage_drop_calculation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_voltage_drop_calculation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_voltage_drop_calculation Instance
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FIRECLASS 64-4", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("400P", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AssignDeviceBase("400P", "4BI 4\" [517.050.043]", "4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("410LPSY - R/W", "Sounders/Beacons");
            Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropValue("0.27");
            //Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropWorstCaseValue("0.54");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.27", "Volt Drop (V)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.54", "Volt Drop (worst case)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("460H", "Detectors");
            Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropValue("0.27");
            //Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropWorstCaseValue("0.54");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.27", "Volt Drop (V)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.54", "Volt Drop (worst case)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedRow("2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Delete");
            Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropValue("0.16");
            //Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropWorstCaseValue("0.31");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.16", "Volt Drop (V)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.31", "Volt Drop (worst case)");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FIRECLASS 240-4", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("400P", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AssignDeviceBase("400P", "4BI 4\" [517.050.043]", "4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("410LPSY - R/W", "Sounders/Beacons");
            Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropValue("0.51");
            //Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropWorstCaseValue("1.03");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.51", "Volt Drop (V)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("1.03", "Volt Drop (worst case)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("460H", "Detectors");
            Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropValue("0.27");
            //Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropWorstCaseValue("0.54");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.27", "Volt Drop (V)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.54", "Volt Drop (worst case)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedRow("2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Delete");
            Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropValue("0.16");
            //Delay.Milliseconds(0);
            
            //Libraries.VoltageDrop_Functions.verifyVoltDropWorstCaseValue("0.31");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.16", "Volt Drop (V)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.31", "Volt Drop (worst case)");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
