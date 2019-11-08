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
    ///The Verify_ACON_Conduct_Adapt_Sd_AV_Base_For_P81AVB_P80SB_P80AVB_P80AIB_Devices recording.
    /// </summary>
    [TestModule("ac389839-6ec7-48db-af66-62d712b90539", ModuleType.Recording, 1)]
    public partial class Verify_ACON_Conduct_Adapt_Sd_AV_Base_For_P81AVB_P80SB_P80AVB_P80AIB_Devices : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_ACON_Conduct_Adapt_Sd_AV_Base_For_P81AVB_P80SB_P80AVB_P80AIB_Devices instance = new Verify_ACON_Conduct_Adapt_Sd_AV_Base_For_P81AVB_P80SB_P80AVB_P80AIB_Devices();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_ACON_Conduct_Adapt_Sd_AV_Base_For_P81AVB_P80SB_P80AVB_P80AIB_Devices()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_ACON_Conduct_Adapt_Sd_AV_Base_For_P81AVB_P80SB_P80AVB_P80AIB_Devices Instance
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
            
            Libraries.LinkedHardware_Fuctions.VerifyCheckboxOfProperties("TC_55046_55052_55056_Verify_Combobox_And_Shopping_List", "TC_55046");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProject("55046");
            Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.Application_Close(ValueConverter.ArgumentFromString<bool>("Save", "False"), ValueConverter.ArgumentFromString<bool>("SaveConfirmation", "False"), "");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("55046");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.SiteNode1' at Center.", repo.FormMe.SiteNode1Info, new RecordItemIndex(5));
            //repo.FormMe.SiteNode1.Click();
            //Delay.Milliseconds(200);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_ShoppingList' at Center.", repo.FormMe.tab_ShoppingListInfo, new RecordItemIndex(7));
            repo.FormMe.tab_ShoppingList.Click();
            Delay.Milliseconds(200);
            
            Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("576.080.014", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Export2ndTime' at Center.", repo.FormMe.Export2ndTimeInfo, new RecordItemIndex(9));
            //repo.FormMe.Export2ndTime.Click();
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PrintPreview.ExportDropdown' at Center.", repo.PrintPreview.ExportDropdownInfo, new RecordItemIndex(10));
            //repo.PrintPreview.ExportDropdown.Click();
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportDocument.ExcelFormat' at Center.", repo.ExportDocument.ExcelFormatInfo, new RecordItemIndex(11));
            //repo.ExportDocument.ExcelFormat.Click();
            //Delay.Milliseconds(200);
            
            //Libraries.Export_Functions.VerifyOverwriteConfirmationForExcel();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(13));
            //Delay.Duration(100, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'csv{Return}'.", new RecordItemIndex(14));
            //Keyboard.Press("csv{Return}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(15));
            //Delay.Duration(5000, false);
            
            //Libraries.Export_Functions.validateAndClickOKButtonOnExportDocument();
            //Delay.Milliseconds(0);
            
            //Libraries.Devices_Functions.verifyExcelCellValue("5", "H5", "8");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShoppingListCompatibilityModeE.btn_CloseExcel' at Center.", repo.ShoppingListCompatibilityModeE.btn_CloseExcelInfo, new RecordItemIndex(18));
            //repo.ShoppingListCompatibilityModeE.btn_CloseExcel.Click();
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PrintPreview.btn_Close' at Center.", repo.PrintPreview.btn_CloseInfo, new RecordItemIndex(19));
            //repo.PrintPreview.btn_Close.Click();
            //Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
