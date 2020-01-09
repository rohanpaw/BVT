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
    ///The Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane recording.
    /// </summary>
    [TestModule("674e8a71-46ac-455d-8c1b-aa251c477155", ModuleType.Recording, 1)]
    public partial class Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane instance = new Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane Instance
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

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro32xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.SlotCards_Functions.VerifyAdditionOfDevicesInBackplaneWithOnePanel("TC_60_Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane", "Add Devices");
            Delay.Milliseconds(0);
            
            Libraries.SlotCards_Functions.VerifyDeletionOfDevicesInBackplane("TC_60_Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane", "Delete Devices");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_Panel_Network' at Center.", repo.FormMe.tab_Panel_NetworkInfo, new RecordItemIndex(4));
            repo.FormMe.tab_Panel_Network.Click();
            Delay.Milliseconds(200);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Node1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro215S", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.SlotCards_Functions.VerifyAdditionOfDevicesInBackplaneWithOnePanel("TC_60_Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane", "Add Devices2");
            Delay.Milliseconds(0);
            
            Libraries.SlotCards_Functions.VerifyDeletionOfDevicesInBackplane("TC_60_Verify_Deletion_Of_PCS_POS_IOB_And_FB_From_Backplane", "Delete Devices2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_Panel_Network' at Center.", repo.FormMe.tab_Panel_NetworkInfo, new RecordItemIndex(11));
            repo.FormMe.tab_Panel_Network.Click();
            Delay.Milliseconds(200);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Node1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
