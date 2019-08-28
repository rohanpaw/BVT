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
    ///The VerifyShoppingList_BVT recording.
    /// </summary>
    [TestModule("7a8f261c-154c-48ac-afa9-57bc58adf125", ModuleType.Recording, 1)]
    public partial class VerifyShoppingList_BVT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static VerifyShoppingList_BVT instance = new VerifyShoppingList_BVT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyShoppingList_BVT()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyShoppingList_BVT Instance
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

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "2"), "Pro32xD,Pro16xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.tab_Points' at Center.", repo.ProfileConsys1.tab_PointsInfo, new RecordItemIndex(4));
            //repo.ProfileConsys1.tab_Points.Click();
            //Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDevicesForBVT("Build_Verification_Test", "TC07_A", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMultiplePointWizardWithRegion("801 CH", ValueConverter.ArgumentFromString<int>("DeviceQty", "15"), "0");
            Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            //Delay.Milliseconds(0);
            
            //Libraries.Devices_Functions.AddDevicesForBVT("Build_Verification_Test", "", "TC07_B");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node2");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMultiplePointWizardWithRegion("LPBS 3000", ValueConverter.ArgumentFromString<int>("DeviceQty", "10"), "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.SiteNode1' at Center.", repo.FormMe.SiteNode1Info, new RecordItemIndex(16));
            repo.FormMe.SiteNode1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.ShoppingList' at Center.", repo.FormMe.ShoppingListInfo, new RecordItemIndex(17));
            repo.FormMe.ShoppingList.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Export2ndTime' at Center.", repo.FormMe.Export2ndTimeInfo, new RecordItemIndex(18));
            repo.FormMe.Export2ndTime.Click();
            Delay.Milliseconds(200);
            
            Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("LPBS 3000", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("801 CH", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("801 PH", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Export2ndTime' at Center.", repo.FormMe.Export2ndTimeInfo, new RecordItemIndex(22));
            repo.FormMe.Export2ndTime.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'PrintPreview.Print1'.", repo.PrintPreview.Print1Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.PrintPreview.Print1Info, "Enabled", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'PrintPreview.Mail_Export'.", repo.PrintPreview.Mail_ExportInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.PrintPreview.Mail_ExportInfo, "Enabled", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PrintPreview.ExportDropdown' at Center.", repo.PrintPreview.ExportDropdownInfo, new RecordItemIndex(25));
            repo.PrintPreview.ExportDropdown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportDocument.ExcelFormat' at Center.", repo.ExportDocument.ExcelFormatInfo, new RecordItemIndex(26));
            repo.ExportDocument.ExcelFormat.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(27));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'csv' on item 'ExportDocument.ExcelFormat'.", repo.ExportDocument.ExcelFormatInfo, new RecordItemIndex(28));
            //repo.ExportDocument.ExcelFormat.Element.SetAttributeValue("Text", "csv");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'csv{Return}'.", new RecordItemIndex(29));
            Keyboard.Press("csv{Return}");
            Delay.Milliseconds(0);
            
            Libraries.Export_Functions.VerifyOverwriteConfirmationForExcel();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(31));
            //Delay.Duration(5000, false);
            
            //Libraries.Export_Functions.validateAndClickOKButtonOnExportDocument();
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyExcelCellValue("8", "H8", "10");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyExcelCellValue("4", "H4", "16");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyExcelCellValue("6", "H6", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShoppingListCompatibilityModeE.btn_CloseExcel' at Center.", repo.ShoppingListCompatibilityModeE.btn_CloseExcelInfo, new RecordItemIndex(36));
            repo.ShoppingListCompatibilityModeE.btn_CloseExcel.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PrintPreview.btn_Close' at Center.", repo.PrintPreview.btn_CloseInfo, new RecordItemIndex(37));
            repo.PrintPreview.btn_Close.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
