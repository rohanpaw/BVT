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
    ///The Verify_When_XML800_Is_Added_To_Panel_Second_PSU_Should_Get_Added_Automatically recording.
    /// </summary>
    [TestModule("4be5cc3d-6d55-49f9-8ff9-387dce87cc8a", ModuleType.Recording, 1)]
    public partial class Verify_When_XML800_Is_Added_To_Panel_Second_PSU_Should_Get_Added_Automatically : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_When_XML800_Is_Added_To_Panel_Second_PSU_Should_Get_Added_Automatically instance = new Verify_When_XML800_Is_Added_To_Panel_Second_PSU_Should_Get_Added_Automatically();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_When_XML800_Is_Added_To_Panel_Second_PSU_Should_Get_Added_Automatically()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_When_XML800_Is_Added_To_Panel_Second_PSU_Should_Get_Added_Automatically Instance
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

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "MZX252", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromPanelNodeGallery("XLM800", "Loops", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.VerifyValueOf2ndPSU("PMM840");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProject("55131");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("55131");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.VerifyValueOf2ndPSUOnReopen("PMM840");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnInventoryTab();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_Inventory' at Center.", repo.FormMe.tab_InventoryInfo, new RecordItemIndex(12));
            //repo.FormMe.tab_Inventory.Click();
            //Delay.Milliseconds(200);
            
            //Libraries.Devices_Functions.SelectRowUsingLabelName("XLM800-C");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelNameOnReopen("XLM800-C");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnDeleteButton();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.btn_Delete' at Center.", repo.ProfileConsys1.btn_DeleteInfo, new RecordItemIndex(16));
            //repo.ProfileConsys1.btn_Delete.Click();
            //Delay.Milliseconds(200);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            //Libraries.Panel_Functions.VerifyValueOf2ndPSUOnReopen("None");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
