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
    ///The Verify_Isolator_Units_And_Intrinsically_Safe_Units_When_User_Add_Delete_The_Device_From_The_Loop_FIM recording.
    /// </summary>
    [TestModule("a14895cd-ab9f-4425-82e4-f2824325eadc", ModuleType.Recording, 1)]
    public partial class Verify_Isolator_Units_And_Intrinsically_Safe_Units_When_User_Add_Delete_The_Device_From_The_Loop_FIM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Isolator_Units_And_Intrinsically_Safe_Units_When_User_Add_Delete_The_Device_From_The_Loop_FIM instance = new Verify_Isolator_Units_And_Intrinsically_Safe_Units_When_User_Add_Delete_The_Device_From_The_Loop_FIM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Isolator_Units_And_Intrinsically_Safe_Units_When_User_Add_Delete_The_Device_From_The_Loop_FIM()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Isolator_Units_And_Intrinsically_Safe_Units_When_User_Add_Delete_The_Device_From_The_Loop_FIM Instance
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

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "MX 4000", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Expander' at Center.", repo.ProfileConsys1.NavigationTree.ExpanderInfo, new RecordItemIndex(1));
            repo.ProfileConsys1.NavigationTree.Expander.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Expand_LoopCard' at Center.", repo.ProfileConsys1.NavigationTree.Expand_LoopCardInfo, new RecordItemIndex(2));
            repo.ProfileConsys1.NavigationTree.Expand_LoopCard.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Loop_A' at Center.", repo.ProfileConsys1.NavigationTree.Loop_AInfo, new RecordItemIndex(3));
            repo.ProfileConsys1.NavigationTree.Loop_A.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Exi800", "Other");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CHEx IS", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CHEx IS", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Exi800", "Other");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CHEx IS", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 PH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 PC", "Detectors");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.tab_PhysicalLayout' at Center.", repo.ProfileConsys1.tab_PhysicalLayoutInfo, new RecordItemIndex(14));
            repo.ProfileConsys1.tab_PhysicalLayout.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.tab_Points' at Center.", repo.ProfileConsys1.tab_PointsInfo, new RecordItemIndex(15));
            repo.ProfileConsys1.tab_Points.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.tab_PhysicalLayout' at Center.", repo.ProfileConsys1.tab_PhysicalLayoutInfo, new RecordItemIndex(16));
            repo.ProfileConsys1.tab_PhysicalLayout.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.VerifyDeviceDisplayedInPhysicalLayout("9", "A:3", "801 CHEx IS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceDisplayedInPhysicalLayout("11", "A:1", "801 CHEx IS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceDisplayedInPhysicalLayout("19", "A:5", "801 PH");
            Delay.Milliseconds(0);
            
            Libraries.IS_Functions.VerifyIsolatorUnits("1", "FIM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.tab_Points' at Center.", repo.ProfileConsys1.tab_PointsInfo, new RecordItemIndex(21));
            repo.ProfileConsys1.tab_Points.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.SelectPointsGridRow("2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.btn_Delete' at Center.", repo.ProfileConsys1.btn_DeleteInfo, new RecordItemIndex(23));
            repo.ProfileConsys1.btn_Delete.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.SelectPointsGridRow("6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.ButtonCut' at Center.", repo.FormMe.ButtonCutInfo, new RecordItemIndex(25));
            repo.FormMe.ButtonCut.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(26));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
