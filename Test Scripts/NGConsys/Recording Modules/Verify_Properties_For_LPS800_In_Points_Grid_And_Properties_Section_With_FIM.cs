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
    ///The Verify_Properties_For_LPS800_In_Points_Grid_And_Properties_Section_With_FIM recording.
    /// </summary>
    [TestModule("615b092c-057c-479d-8fc6-24e9a59c812f", ModuleType.Recording, 1)]
    public partial class Verify_Properties_For_LPS800_In_Points_Grid_And_Properties_Section_With_FIM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Properties_For_LPS800_In_Points_Grid_And_Properties_Section_With_FIM instance = new Verify_Properties_For_LPS800_In_Points_Grid_And_Properties_Section_With_FIM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Properties_For_LPS800_In_Points_Grid_And_Properties_Section_With_FIM()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Properties_For_LPS800_In_Points_Grid_And_Properties_Section_With_FIM Instance
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
            
            Libraries.Devices_Functions.AddDevicesfromGallery("LPS 800", "Sounders/Beacons");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGalleryNotHavingImages("Generic Sounder", "Conventional Sounders");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDeviceOrderColumn();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointsGridColumn("SKU", "1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointsGridColumn("Model", "3");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointsGridColumn("Label", "4");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPointsGridColumn("Address", "6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("1");
            Delay.Milliseconds(0);
            
            verifyZone(ValueConverter.ArgumentFromString<bool>("sZone", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyDescription("Loop Powered Sounder Module");
            Delay.Milliseconds(0);
            
            verifySKU(ValueConverter.ArgumentFromString<bool>("sSKU", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectPointsGridRow("2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.editDeviceLabel("Label", "Generic Sounder Test");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.EditAlarmLoad("5");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProject("53633_FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.Application_Close(ValueConverter.ArgumentFromString<bool>("Save", "False"), ValueConverter.ArgumentFromString<bool>("SaveConfirmation", "False"), "");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
