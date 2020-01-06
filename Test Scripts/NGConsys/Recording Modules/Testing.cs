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
    ///The Testing recording.
    /// </summary>
    [TestModule("d173c66d-c7b7-47fb-ab2e-60be9cff88e6", ModuleType.Recording, 1)]
    public partial class Testing : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Testing instance = new Testing();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Testing()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Testing Instance
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
            
            Libraries.Devices_Functions.EnableISDevices();
            Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Main");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeExpander("Main");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Ethernet");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-C");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeExpander("Backplane");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Backplane  1/3");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.VerifyNavigationTreeItemText("Backplane  1/3");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Other Slot Cards");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.VerifyNavigationTreeItemText("Other Slot Cards  (0 of 6)");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.VerifyNavigationTreeItemText("Other Slot Cards  (1 of 6)");
            //Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeExpander("Backplane  1/3");
            //Delay.Milliseconds(0);
            
            //Libraries.DC_Functions.verifyPanelLEDEffectOnDC("Verify DC Units Calculation for PFI", "Panel LED");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_C1' at Center.", repo.FormMe.Loop_C1Info, new RecordItemIndex(20));
            //repo.FormMe.Loop_C1.Click();
            //Delay.Milliseconds(200);
            
            //Libraries.DC_Functions.verifyDCUnitsValue("220");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_D1' at Center.", repo.FormMe.Loop_D1Info, new RecordItemIndex(22));
            //repo.FormMe.Loop_D1.Click();
            //Delay.Milliseconds(200);
            
            //Libraries.DC_Functions.verifyDCUnitsValue("220");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(24));
            //repo.FormMe.Loop_A1.Click();
            //Delay.Milliseconds(200);
            
            //Libraries.Devices_Functions.DeleteDevices("Verify DC Units Calculation for PFI", "Delete Devices Loop A");
            //Delay.Milliseconds(0);
            
            //Libraries.DC_Functions.verifyDCUnitsValue("366");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_B1' at Center.", repo.FormMe.Loop_B1Info, new RecordItemIndex(27));
            //repo.FormMe.Loop_B1.Click();
            //Delay.Milliseconds(200);
            
            //Libraries.DC_Functions.verifyDCUnitsValue("366");
            //Delay.Milliseconds(0);
            
            //Libraries.Devices_Functions.DeleteDevices("Verify DC Units Calculation for PFI", "Delete Devices Loop B");
            //Delay.Milliseconds(0);
            
            //Libraries.DC_Functions.verifyDCUnitsValue("339.5");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(31));
            //repo.FormMe.Loop_A1.Click();
            //Delay.Milliseconds(200);
            
            //Libraries.DC_Functions.verifyDCUnitsValue("339.5");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
