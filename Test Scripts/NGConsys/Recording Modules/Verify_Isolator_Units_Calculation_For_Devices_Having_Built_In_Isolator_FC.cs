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
    ///The Verify_Isolator_Units_Calculation_For_Devices_Having_Built_In_Isolator_FC recording.
    /// </summary>
    [TestModule("9542f4a4-2466-436d-98a9-9d9ce9009bac", ModuleType.Recording, 1)]
    public partial class Verify_Isolator_Units_Calculation_For_Devices_Having_Built_In_Isolator_FC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Isolator_Units_Calculation_For_Devices_Having_Built_In_Isolator_FC instance = new Verify_Isolator_Units_Calculation_For_Devices_Having_Built_In_Isolator_FC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Isolator_Units_Calculation_For_Devices_Having_Built_In_Isolator_FC()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Isolator_Units_Calculation_For_Devices_Having_Built_In_Isolator_FC Instance
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

            Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FIRECLASS 64-2", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.btn_MultiplePointWizard' at Center.", repo.FormMe.btn_MultiplePointWizardInfo, new RecordItemIndex(4));
            //repo.FormMe.btn_MultiplePointWizard.Click();
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddDevices.txt_AllDevices' at Center.", repo.AddDevices.txt_AllDevicesInfo, new RecordItemIndex(5));
            //repo.AddDevices.txt_AllDevices.Click();
            //Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDevicesForBVT("NGC_1826_Add_Devices_In_Multiple_Point_Wizard", "TC_63981", "");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("7", "3");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("8", "7.5");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("9", "5");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("10", "2.5");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("11", "2.5");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyValueOfParameterInPhysicalLayout("12", "0");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
