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
    ///The Verify_DC_Units_Displayed_For_Split_Loops_FC recording.
    /// </summary>
    [TestModule("ba9786e7-7ae7-46bd-b78c-090a734cff3c", ModuleType.Recording, 1)]
    public partial class Verify_DC_Units_Displayed_For_Split_Loops_FC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_DC_Units_Displayed_For_Split_Loops_FC instance = new Verify_DC_Units_Displayed_For_Split_Loops_FC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_DC_Units_Displayed_For_Split_Loops_FC()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_DC_Units_Displayed_For_Split_Loops_FC Instance
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

            Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FC708D", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            //Libraries.DC_Functions.verifyDCUnitsValue("220");
            //Delay.Milliseconds(0);
            
            //Libraries.DC_Functions.verifyMaxDCUnits("2200");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("220", "Current (DC Units)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("4000", "Current (DC Units)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-C");
            Delay.Milliseconds(0);
            
            //Libraries.DC_Functions.verifyDCUnitsValue("220");
            //Delay.Milliseconds(0);
            
            //Libraries.DC_Functions.verifyMaxDCUnits("2200");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("220", "Current (DC Units)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("4000", "Current (DC Units)");
            Delay.Milliseconds(0);
            
            Libraries.DC_Functions.verifyDCUnitCalculationForSplitLoops("TC_63775_Verify_DC_Units_Displayed_For_Split_Loops_FC", "Add_Devices_LoopA", "Add_Devices_LoopC");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
