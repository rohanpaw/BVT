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
    ///The Verify_the_behaviour_when_user_copies_both_IS_and_Non_IS_devices recording.
    /// </summary>
    [TestModule("787a9c2e-0e9c-4df6-9275-18024c452172", ModuleType.Recording, 1)]
    public partial class Verify_the_behaviour_when_user_copies_both_IS_and_Non_IS_devices : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_the_behaviour_when_user_copies_both_IS_and_Non_IS_devices instance = new Verify_the_behaviour_when_user_copies_both_IS_and_Non_IS_devices();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_the_behaviour_when_user_copies_both_IS_and_Non_IS_devices()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_the_behaviour_when_user_copies_both_IS_and_Non_IS_devices Instance
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
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Exi800", "Other");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Exi800", "Other");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CHEx IS", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectMultipleDevices("3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.btn_Copy1' at Center.", repo.FormMe.btn_Copy1Info, new RecordItemIndex(10));
            repo.FormMe.btn_Copy1.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.SelectPointsGridRow("2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(12));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.verifyPointGridProperties("5", "Label", "801 CH - 3");
            Delay.Milliseconds(0);
            
            Libraries.IS_Functions.VerifyDeviceOrder("4", "0 / 1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.btn_Copy1' at Center.", repo.FormMe.btn_Copy1Info, new RecordItemIndex(16));
            repo.FormMe.btn_Copy1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(17));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.verifyPointGridProperties("6", "Label", "801 CH - 4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.btn_Copy1' at Center.", repo.FormMe.btn_Copy1Info, new RecordItemIndex(20));
            repo.FormMe.btn_Copy1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(21));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.Common_Functions.SaveProject("50445");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("50445");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("1", "Label", "801 CH - 1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("2", "Label", "801 CHEx IS - 2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("3", "Label", "801 CH - 3");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("4", "Label", "801 CH - 4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("5", "Label", "Exi800");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("6", "Label", "Exi800");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro16xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Exi800", "Other");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Exi800", "Other");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CHEx IS", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectMultipleDevices("3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.btn_Copy1' at Center.", repo.FormMe.btn_Copy1Info, new RecordItemIndex(44));
            repo.FormMe.btn_Copy1.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.SelectPointsGridRow("2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(46));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.verifyPointGridProperties("5", "Label", "801 CH - 3");
            Delay.Milliseconds(0);
            
            Libraries.IS_Functions.VerifyDeviceOrder("4", "0 / 1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.btn_Copy1' at Center.", repo.FormMe.btn_Copy1Info, new RecordItemIndex(50));
            repo.FormMe.btn_Copy1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(51));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.verifyPointGridProperties("6", "Label", "801 CH - 4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.btn_Copy1' at Center.", repo.FormMe.btn_Copy1Info, new RecordItemIndex(54));
            repo.FormMe.btn_Copy1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(55));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.Common_Functions.SaveProject("50445");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("50445");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("1", "Label", "801 CH - 1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("2", "Label", "801 CHEx IS - 2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("3", "Label", "801 CH - 3");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("4", "Label", "801 CH - 4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("5", "Label", "Exi800");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointGridProperties("6", "Label", "Exi800");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
