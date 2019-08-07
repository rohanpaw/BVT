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
    ///The Verify_LPS800_And_Its_Sounders recording.
    /// </summary>
    [TestModule("18ef900d-c144-4970-b519-5d9e9cf9cec2", ModuleType.Recording, 1)]
    public partial class Verify_LPS800_And_Its_Sounders : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_LPS800_And_Its_Sounders instance = new Verify_LPS800_And_Its_Sounders();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_LPS800_And_Its_Sounders()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_LPS800_And_Its_Sounders Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(1));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.LoopExpander1' at Center.", repo.FormMe.LoopExpander1Info, new RecordItemIndex(2));
            repo.FormMe.LoopExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(3));
            repo.FormMe.Loop_A1.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("LPS 800", "Sounders/Beacons");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGalleryNotHavingImages("Squashni Sounder", "Conventional Sounders");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("LPS 800", "Sounders/Beacons");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("LPS 800 - 2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGalleryNotHavingImages("Squashni Sounder", "Conventional Sounders");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("LPS 800 - 2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGalleryNotHavingImages("Flashni Sounder", "Conventional Sounders");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.btn_Copy1' at Center.", repo.FormMe.btn_Copy1Info, new RecordItemIndex(11));
            repo.FormMe.btn_Copy1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(12));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDeviceOrderColumn();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("1", "1", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("2", "2", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("5", "3", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("3", "1/1", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("4", "2/1", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("6", "2/2", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("7", "3/1", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("8", "3/2", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("LPS 800 - 1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.ButtonCut1' at Center.", repo.FormMe.ButtonCut1Info, new RecordItemIndex(23));
            repo.FormMe.ButtonCut1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_B1' at Center.", repo.FormMe.Loop_B1Info, new RecordItemIndex(24));
            repo.FormMe.Loop_B1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.tab_Points' at Center.", repo.ProfileConsys1.tab_PointsInfo, new RecordItemIndex(25));
            repo.ProfileConsys1.tab_Points.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Paste' at Center.", repo.FormMe.PasteInfo, new RecordItemIndex(26));
            repo.FormMe.Paste.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDeviceOrderColumn();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("1", "126", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceOrder("2", "126/1", ValueConverter.ArgumentFromString<bool>("Present", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProject("TC_54105");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.Application_Close(ValueConverter.ArgumentFromString<bool>("Save", "False"), ValueConverter.ArgumentFromString<bool>("SaveConfirmation", "False"), "");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
