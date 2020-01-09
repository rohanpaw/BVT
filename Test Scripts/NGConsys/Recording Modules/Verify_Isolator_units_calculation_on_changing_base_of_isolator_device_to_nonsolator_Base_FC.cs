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
    ///The Verify_Isolator_units_calculation_on_changing_base_of_isolator_device_to_nonsolator_Base_FC recording.
    /// </summary>
    [TestModule("662031fa-a3f5-42aa-9752-e52ac68fa817", ModuleType.Recording, 1)]
    public partial class Verify_Isolator_units_calculation_on_changing_base_of_isolator_device_to_nonsolator_Base_FC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Isolator_units_calculation_on_changing_base_of_isolator_device_to_nonsolator_Base_FC instance = new Verify_Isolator_units_calculation_on_changing_base_of_isolator_device_to_nonsolator_Base_FC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Isolator_units_calculation_on_changing_base_of_isolator_device_to_nonsolator_Base_FC()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Isolator_units_calculation_on_changing_base_of_isolator_device_to_nonsolator_Base_FC Instance
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

            Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FIRECLASS 64-2", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("460PH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("460PH", "Call Points");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AssignDeviceBase("460PH - 1", "430SB [516.800.710] @ 90dB & 801RIL", "13");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("410BDM", "Ancillary");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("445SR", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("460P", "Ancillary");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AssignDeviceBase("460P - 4", "440DSB [576.440.001] @ 90dB & 801RIL", "13");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("410MIM", "Call Points");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("420CP-I", "Ancillary");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("460PC", "Ancillary");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AssignDeviceBase("460PC - 7", "440DSB [576.440.001] @ 90dB & 801HL", "13");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.DragAndDropDevicesInPhysicalLayout("A:5", "A:4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.DragAndDropDevicesInPhysicalLayout("A:6", "A:4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.tab_Points' at Center.", repo.ProfileConsys1.tab_PointsInfo, new RecordItemIndex(17));
            repo.ProfileConsys1.tab_Points.Click();
            Delay.Milliseconds(200);
            
            //Libraries.IS_Functions.VerifyIsolatorUnits("3.5", "FIM");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("7", "6.5");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("8", "6.5");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("9", "3.5");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
