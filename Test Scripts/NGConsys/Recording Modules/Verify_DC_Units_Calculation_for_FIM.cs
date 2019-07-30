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
    ///The Verify_DC_Units_Calculation_for_FIM recording.
    /// </summary>
    [TestModule("86002f58-bc14-4daf-a2e4-8d85f8a181b7", ModuleType.Recording, 1)]
    public partial class Verify_DC_Units_Calculation_for_FIM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_DC_Units_Calculation_for_FIM instance = new Verify_DC_Units_Calculation_for_FIM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_DC_Units_Calculation_for_FIM()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_DC_Units_Calculation_for_FIM Instance
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

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "MX 4000", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(1));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.LoopExpander1' at Center.", repo.FormMe.LoopExpander1Info, new RecordItemIndex(2));
            repo.FormMe.LoopExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(3));
            repo.FormMe.Loop_A1.Click();
            Delay.Milliseconds(200);
            
            Libraries.DC_Functions.verifyDCUnitsValue("220");
            Delay.Milliseconds(0);
            
            Libraries.DC_Functions.verifyMaxDCUnits("2200");
            Delay.Milliseconds(0);
            
            Libraries.DC_Functions.VerifyDCCalculationOnAddingDevices("Verify DC Units Calculation for FIM", "Add Devices Loop A", "Add Devices Loop B");
            Delay.Milliseconds(0);
            
            Libraries.DC_Functions.verifyPanelLEDEffectOnDC("Verify DC Units Calculation for FIM", "Panel LED");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_B1' at Center.", repo.FormMe.Loop_B1Info, new RecordItemIndex(8));
            repo.FormMe.Loop_B1.Click();
            Delay.Milliseconds(200);
            
            Libraries.DC_Functions.verifyDCUnitsValue("259.3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(10));
            repo.FormMe.Loop_A1.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.DeleteDevices("Verify DC Units Calculation for FIM", "Delete Devices Loop A");
            Delay.Milliseconds(0);
            
            Libraries.DC_Functions.verifyDCUnitsValue("286.2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_B1' at Center.", repo.FormMe.Loop_B1Info, new RecordItemIndex(13));
            repo.FormMe.Loop_B1.Click();
            Delay.Milliseconds(200);
            
            Libraries.DC_Functions.verifyDCUnitsValue("259.3");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.DeleteDevices("Verify DC Units Calculation for FIM", "Delete Devices Loop B");
            Delay.Milliseconds(0);
            
            Libraries.DC_Functions.verifyDCUnitsValue("233.1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(17));
            repo.FormMe.Loop_A1.Click();
            Delay.Milliseconds(200);
            
            Libraries.DC_Functions.verifyDCUnitsValue("286.2");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
