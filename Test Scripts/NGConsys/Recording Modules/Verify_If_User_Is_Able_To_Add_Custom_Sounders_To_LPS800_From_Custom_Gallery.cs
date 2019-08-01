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
    ///The Verify_If_User_Is_Able_To_Add_Custom_Sounders_To_LPS800_From_Custom_Gallery recording.
    /// </summary>
    [TestModule("8a5657d5-5a28-4966-acd7-0e9a47e689cf", ModuleType.Recording, 1)]
    public partial class Verify_If_User_Is_Able_To_Add_Custom_Sounders_To_LPS800_From_Custom_Gallery : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_If_User_Is_Able_To_Add_Custom_Sounders_To_LPS800_From_Custom_Gallery instance = new Verify_If_User_Is_Able_To_Add_Custom_Sounders_To_LPS800_From_Custom_Gallery();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_If_User_Is_Able_To_Add_Custom_Sounders_To_LPS800_From_Custom_Gallery()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_If_User_Is_Able_To_Add_Custom_Sounders_To_LPS800_From_Custom_Gallery Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(3));
            repo.FormMe.Loop_A1.DoubleClick();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.DeleteDevicesPresentInCustomGallery();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("LPS 800", "Sounders/Beacons");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("LPS 800 - 1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGalleryNotHavingImages("Generic Sounder", "Conventional Sounders");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("Generic Sounder");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.ChangeLabelName("Generic");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.SaveAsCustom' at Center.", repo.FormMe.SaveAsCustomInfo, new RecordItemIndex(11));
            repo.FormMe.SaveAsCustom.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("Generic Sounder");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.ChangeLabelName("Generic");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.ChangeLabelName("ABC");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("LPS 800 - 1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifySounderCustomDeviceDisplayedInCustomGallery("Custom", ValueConverter.ArgumentFromString<bool>("isEnabled", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceUsingLabelName("Generic");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("801 CH - 2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifySounderCustomDeviceDisplayedInCustomGallery("Custom", ValueConverter.ArgumentFromString<bool>("isEnabled", "False"));
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProject("54084");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.Application_Close(ValueConverter.ArgumentFromString<bool>("Save", "False"), ValueConverter.ArgumentFromString<bool>("SaveConfirmation", "False"), "");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
