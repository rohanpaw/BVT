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
    ///The Verify_Export_Of_Shopping_List recording.
    /// </summary>
    [TestModule("fd263429-f8ad-4d41-bf7b-07bdbb8e8fd0", ModuleType.Recording, 1)]
    public partial class Verify_Export_Of_Shopping_List : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Export_Of_Shopping_List instance = new Verify_Export_Of_Shopping_List();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Export_Of_Shopping_List()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Export_Of_Shopping_List Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Expander' at Center.", repo.ProfileConsys1.NavigationTree.ExpanderInfo, new RecordItemIndex(1));
            repo.ProfileConsys1.NavigationTree.Expander.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.BackplaneOrXLMExternalLoopCard_Expander' at Center.", repo.FormMe.BackplaneOrXLMExternalLoopCard_ExpanderInfo, new RecordItemIndex(2));
            repo.FormMe.BackplaneOrXLMExternalLoopCard_Expander.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.OtherSlotCards_BP1' at Center.", repo.FormMe.OtherSlotCards_BP1Info, new RecordItemIndex(3));
            repo.FormMe.OtherSlotCards_BP1.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("PCH800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("PCH800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.SiteNode' at Center.", repo.ProfileConsys1.SiteNodeInfo, new RecordItemIndex(6));
            repo.ProfileConsys1.SiteNode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.ShoppingList' at Center.", repo.FormMe.ShoppingListInfo, new RecordItemIndex(7));
            repo.FormMe.ShoppingList.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Backplane2_Expander' at Center.", repo.FormMe.Backplane2_ExpanderInfo, new RecordItemIndex(8));
            repo.FormMe.Backplane2_Expander.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.OtherSlotCards_BP2' at Center.", repo.FormMe.OtherSlotCards_BP2Info, new RecordItemIndex(9));
            repo.FormMe.OtherSlotCards_BP2.Click();
            Delay.Milliseconds(200);
            
            Libraries.SlotCards_Functions.VerifySlotCardsTextForBackplane2("Other Slot Cards  (1 of 6)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("PCH800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Backplane3_Expander' at Center.", repo.FormMe.Backplane3_ExpanderInfo, new RecordItemIndex(12));
            repo.FormMe.Backplane3_Expander.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.OtherSlotCards_BP3' at Center.", repo.FormMe.OtherSlotCards_BP3Info, new RecordItemIndex(13));
            repo.FormMe.OtherSlotCards_BP3.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.SiteNode' at Center.", repo.ProfileConsys1.SiteNodeInfo, new RecordItemIndex(14));
            repo.ProfileConsys1.SiteNode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.ShoppingList' at Center.", repo.FormMe.ShoppingListInfo, new RecordItemIndex(15));
            repo.FormMe.ShoppingList.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Backplane3_Expander' at Center.", repo.FormMe.Backplane3_ExpanderInfo, new RecordItemIndex(16));
            repo.FormMe.Backplane3_Expander.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.OtherSlotCards_BP3' at Center.", repo.FormMe.OtherSlotCards_BP3Info, new RecordItemIndex(17));
            repo.FormMe.OtherSlotCards_BP3.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.SiteNode' at Center.", repo.ProfileConsys1.SiteNodeInfo, new RecordItemIndex(18));
            repo.ProfileConsys1.SiteNode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.ShoppingList' at Center.", repo.FormMe.ShoppingListInfo, new RecordItemIndex(19));
            repo.FormMe.ShoppingList.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.verifyShoppingList(ValueConverter.ArgumentFromString<int>("ShoppingListDeviceCount", "5"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.OtherSlotCards_BP3' at Center.", repo.FormMe.OtherSlotCards_BP3Info, new RecordItemIndex(21));
            repo.FormMe.OtherSlotCards_BP3.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("PCH800-3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.SiteNode' at Center.", repo.ProfileConsys1.SiteNodeInfo, new RecordItemIndex(23));
            repo.ProfileConsys1.SiteNode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.ShoppingList' at Center.", repo.FormMe.ShoppingListInfo, new RecordItemIndex(24));
            repo.FormMe.ShoppingList.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.verifyShoppingList(ValueConverter.ArgumentFromString<int>("ShoppingListDeviceCount", "6"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Export' at Center.", repo.FormMe.ExportInfo, new RecordItemIndex(26));
            repo.FormMe.Export.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PrintPreview.PARTMaximize' at Center.", repo.PrintPreview.PARTMaximizeInfo, new RecordItemIndex(27));
            repo.PrintPreview.PARTMaximize.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PrintPreview.ExportDropdown' at Center.", repo.PrintPreview.ExportDropdownInfo, new RecordItemIndex(28));
            repo.PrintPreview.ExportDropdown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportDocument.ExcelFormat' at Center.", repo.ExportDocument.ExcelFormatInfo, new RecordItemIndex(29));
            repo.ExportDocument.ExcelFormat.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(30));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'Xls' on item 'ExportDocument.ExcelFormat'.", repo.ExportDocument.ExcelFormatInfo, new RecordItemIndex(31));
            repo.ExportDocument.ExcelFormat.Element.SetAttributeValue("Text", "Xls");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(32));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportDocument.ButtonOK' at Center.", repo.ExportDocument.ButtonOKInfo, new RecordItemIndex(33));
            repo.ExportDocument.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportDocument.ButtonOK' at Center.", repo.ExportDocument.ButtonOKInfo, new RecordItemIndex(34));
            repo.ExportDocument.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShoppingListCompatibilityModeE.Cell18' at Center.", repo.ShoppingListCompatibilityModeE.Cell18Info, new RecordItemIndex(35));
            repo.ShoppingListCompatibilityModeE.Cell18.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.verifyShoppingListDevicesTextForPxD("PxD");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShoppingListCompatibilityModeE.CellF22' at Center.", repo.ShoppingListCompatibilityModeE.CellF22Info, new RecordItemIndex(37));
            repo.ShoppingListCompatibilityModeE.CellF22.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.verifyShoppingListDevicesTextForPSC("PSC800");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShoppingListCompatibilityModeE.btn_CloseExcel' at Center.", repo.ShoppingListCompatibilityModeE.btn_CloseExcelInfo, new RecordItemIndex(39));
            repo.ShoppingListCompatibilityModeE.btn_CloseExcel.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PrintPreview.btn_CloseB' at Center.", repo.PrintPreview.btn_CloseBInfo, new RecordItemIndex(40));
            repo.PrintPreview.btn_CloseB.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Header_ProfileConsys' at Center.", repo.FormMe.Header_ProfileConsysInfo, new RecordItemIndex(41));
            repo.FormMe.Header_ProfileConsys.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
