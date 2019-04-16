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
    ///The Verify_Voltage_Drop_on_Other_Loops recording.
    /// </summary>
    [TestModule("c2a7aacf-737f-400b-9f80-11f1019f7274", ModuleType.Recording, 1)]
    public partial class Verify_Voltage_Drop_on_Other_Loops : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Voltage_Drop_on_Other_Loops instance = new Verify_Voltage_Drop_on_Other_Loops();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Voltage_Drop_on_Other_Loops()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Voltage_Drop_on_Other_Loops Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Expander' at Center.", repo.ProfileConsys1.NavigationTree.ExpanderInfo, new RecordItemIndex(1));
            repo.ProfileConsys1.NavigationTree.Expander.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Expand_LoopCard' at Center.", repo.ProfileConsys1.NavigationTree.Expand_LoopCardInfo, new RecordItemIndex(2));
            repo.ProfileConsys1.NavigationTree.Expand_LoopCard.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Loop_A' at Center.", repo.ProfileConsys1.NavigationTree.Loop_AInfo, new RecordItemIndex(3));
            repo.ProfileConsys1.NavigationTree.Loop_A.Click();
            Delay.Milliseconds(200);
            
            Libraries.VoltageDrop_Functions.verifyVoltageDropCalculation("Verify Voltage Drop Calculation on adding devices in Multiple loops of FIM", "Add Devices Loop A");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Loop_B' at Center.", repo.ProfileConsys1.NavigationTree.Loop_BInfo, new RecordItemIndex(5));
            repo.ProfileConsys1.NavigationTree.Loop_B.Click();
            Delay.Milliseconds(200);
            
            Libraries.VoltageDrop_Functions.verifyVoltDropValue("0.00");
            Delay.Milliseconds(0);
            
            Libraries.VoltageDrop_Functions.verifyVoltDropWorstCaseValue("0.00");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Loop_B' at Center.", repo.ProfileConsys1.NavigationTree.Loop_BInfo, new RecordItemIndex(8));
            repo.ProfileConsys1.NavigationTree.Loop_B.Click();
            Delay.Milliseconds(200);
            
            Libraries.VoltageDrop_Functions.verifyVoltageDropCalculation("Verify Voltage Drop Calculation on adding devices in Multiple loops of FIM", "Add Devices Loop B");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
