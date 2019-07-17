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
    ///The Verify_If_Custom_Gallery_Can_Be_Updated_For_LPS800_Sounders recording.
    /// </summary>
    [TestModule("3924e32b-485d-4f2f-be98-76a073bea943", ModuleType.Recording, 1)]
    public partial class Verify_If_Custom_Gallery_Can_Be_Updated_For_LPS800_Sounders : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_If_Custom_Gallery_Can_Be_Updated_For_LPS800_Sounders instance = new Verify_If_Custom_Gallery_Can_Be_Updated_For_LPS800_Sounders();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_If_Custom_Gallery_Can_Be_Updated_For_LPS800_Sounders()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_If_Custom_Gallery_Can_Be_Updated_For_LPS800_Sounders Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Expand_LoopCard' at Center.", repo.ProfileConsys1.NavigationTree.Expand_LoopCardInfo, new RecordItemIndex(2));
            repo.ProfileConsys1.NavigationTree.Expand_LoopCard.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Loop_A' at Center.", repo.ProfileConsys1.NavigationTree.Loop_AInfo, new RecordItemIndex(3));
            repo.ProfileConsys1.NavigationTree.Loop_A.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.DeleteDevicesPresentInCustomGallery();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("LPS 800", "Sounders/Beacons");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("801 CH", "Detectors");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("LPS 800 - 1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGalleryNotHavingImages("Generic Sounder", "Conventional Sounders");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("Generic Sounder");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.ChangeLabelName("Generic");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.SaveAsCustom' at Center.", repo.FormMe.SaveAsCustomInfo, new RecordItemIndex(11));
            repo.FormMe.SaveAsCustom.Click();
            Delay.Milliseconds(200);
            
            //Libraries.Devices_Functions.SelectRowUsingLabelName("LPS 800 - 1");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedRow("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContextMenu.Custom_In_Context_Menu' at Center.", repo.ContextMenu.Custom_In_Context_MenuInfo, new RecordItemIndex(14));
            repo.ContextMenu.Custom_In_Context_Menu.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.VerifyCustomDevicesInContextMenu(ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelName("801 CH - 2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedRow("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContextMenu.Custom_In_Context_Menu' at Center.", repo.ContextMenu.Custom_In_Context_MenuInfo, new RecordItemIndex(18));
            repo.ContextMenu.Custom_In_Context_Menu.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.VerifyCustomDevicesInContextMenu(ValueConverter.ArgumentFromString<bool>("sExist", "False"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
