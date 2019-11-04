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
    ///The VerifyDeletionOfFBI800AndPNI800Cards recording.
    /// </summary>
    [TestModule("5db13383-7f65-4b13-98b6-ce5b4620edfb", ModuleType.Recording, 1)]
    public partial class VerifyDeletionOfFBI800AndPNI800Cards : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static VerifyDeletionOfFBI800AndPNI800Cards instance = new VerifyDeletionOfFBI800AndPNI800Cards();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyDeletionOfFBI800AndPNI800Cards()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyDeletionOfFBI800AndPNI800Cards Instance
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
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("FBI800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_PanelAccessories' at Center.", repo.FormMe.tab_PanelAccessoriesInfo, new RecordItemIndex(4));
            repo.FormMe.tab_PanelAccessories.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDevicefromPanelAccessoriesGallery("IOB800", "Accessories");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_Inventory' at Center.", repo.FormMe.tab_InventoryInfo, new RecordItemIndex(6));
            repo.FormMe.tab_Inventory.Click();
            Delay.Milliseconds(200);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "FBI800-1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Backplane");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.VerifyAndClickNavigationTreeItemText("Other Slot Cards  (2 of 18)");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("1", "Label", "FBI800-1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.btn_Delete' at Center.", repo.ProfileConsys1.btn_DeleteInfo, new RecordItemIndex(12));
            repo.ProfileConsys1.btn_Delete.Click();
            Delay.Milliseconds(200);
            
            Libraries.Common_Functions.VerifyAndClickNavigationTreeItemText("Other Slot Cards  (1 of 18)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("PNI800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("7", "Label", "PNI800-1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.VerifyAndClickNavigationTreeItemText("Other Slot Cards  (2 of 18)");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("1", "Label", "PNI800-1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.btn_Delete' at Center.", repo.ProfileConsys1.btn_DeleteInfo, new RecordItemIndex(20));
            repo.ProfileConsys1.btn_Delete.Click();
            Delay.Milliseconds(200);
            
            Libraries.Common_Functions.VerifyAndClickNavigationTreeItemText("Other Slot Cards  (1 of 18)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProjectFromFileOption("389_5");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("389_5");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Backplane");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro32xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("FBI800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_PanelAccessories' at Center.", repo.FormMe.tab_PanelAccessoriesInfo, new RecordItemIndex(32));
            repo.FormMe.tab_PanelAccessories.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDevicefromPanelAccessoriesGallery("IOB800", "Accessories");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_Inventory' at Center.", repo.FormMe.tab_InventoryInfo, new RecordItemIndex(34));
            repo.FormMe.tab_Inventory.Click();
            Delay.Milliseconds(200);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "FBI800-1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Backplane");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.VerifyAndClickNavigationTreeItemText("Other Slot Cards  (2 of 18)");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("1", "Label", "FBI800-1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.btn_Delete' at Center.", repo.ProfileConsys1.btn_DeleteInfo, new RecordItemIndex(40));
            repo.ProfileConsys1.btn_Delete.Click();
            Delay.Milliseconds(200);
            
            Libraries.Common_Functions.VerifyAndClickNavigationTreeItemText("Other Slot Cards  (1 of 18)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("PNI800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("7", "Label", "PNI800-1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.VerifyAndClickNavigationTreeItemText("Other Slot Cards  (2 of 18)");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("1", "Label", "PNI800-1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.btn_Delete' at Center.", repo.ProfileConsys1.btn_DeleteInfo, new RecordItemIndex(48));
            repo.ProfileConsys1.btn_Delete.Click();
            Delay.Milliseconds(200);
            
            Libraries.Common_Functions.VerifyAndClickNavigationTreeItemText("Other Slot Cards  (1 of 18)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProjectFromFileOption("389_5");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("389_5");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Backplane");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
