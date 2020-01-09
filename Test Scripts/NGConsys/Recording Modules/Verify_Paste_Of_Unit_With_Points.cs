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
    ///The Verify_Paste_Of_Unit_With_Points recording.
    /// </summary>
    [TestModule("21df85d8-aea5-4759-a8a8-44db0ff18796", ModuleType.Recording, 1)]
    public partial class Verify_Paste_Of_Unit_With_Points : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Paste_Of_Unit_With_Points instance = new Verify_Paste_Of_Unit_With_Points();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Paste_Of_Unit_With_Points()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Paste_Of_Unit_With_Points Instance
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
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("PLX800", "Loops", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "PLX800-E");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPasteButtonDisabled();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Copy");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyContextMenuOptionOnRightClickEnabledOrDisabled("Paste");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(15));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("10", "Address", "9");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("11", "Address", "10");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("12", "Address", "11");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("13", "Address", "12");
            //Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("13", "SKU", "557.202.842");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Cut");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyContextMenuOptionOnRightClickEnabledOrDisabled("Paste");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(25));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "PLX800-5");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("7", "Label", "PLX800-6");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("8", "Label", "PLX800-7");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("9", "Label", "PLX800-8");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro32xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("PLX800", "Loops", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "PLX800-E");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPasteButtonDisabled();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Copy");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyContextMenuOptionOnRightClickEnabledOrDisabled("Paste");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(46));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("10", "Address", "9");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("11", "Address", "10");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("12", "Address", "11");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("13", "Address", "12");
            //Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("13", "SKU", "557.202.842");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Cut");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyContextMenuOptionOnRightClickEnabledOrDisabled("Paste");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(56));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "PLX800-5");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("7", "Label", "PLX800-6");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("8", "Label", "PLX800-7");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("9", "Label", "PLX800-8");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
