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

namespace TestProject.BelgiumRecordingModule
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_Maximum_Calculation_Value_For_5V_24V_40V_Rail_AC_DC_VoltDropUnits recording.
    /// </summary>
    [TestModule("a67d01cd-6d6f-4f38-b8e0-d8e39e0b7024", ModuleType.Recording, 1)]
    public partial class Verify_Maximum_Calculation_Value_For_5V_24V_40V_Rail_AC_DC_VoltDropUnits : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Maximum_Calculation_Value_For_5V_24V_40V_Rail_AC_DC_VoltDropUnits instance = new Verify_Maximum_Calculation_Value_For_5V_24V_40V_Rail_AC_DC_VoltDropUnits();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Maximum_Calculation_Value_For_5V_24V_40V_Rail_AC_DC_VoltDropUnits()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Maximum_Calculation_Value_For_5V_24V_40V_Rail_AC_DC_VoltDropUnits Instance
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

            Libraries.PSULoad_Functions.VerifyMaximumPanelPowerCalculation("T1838_T1840_T1841", "MaximumPanelCalculation");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
