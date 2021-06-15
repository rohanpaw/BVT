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

namespace TestProject.BelgiumRecordingModule
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_MZX_MX_Series_Panel_Loop_Card_Gallery_And_Addition_Of_Devices recording.
    /// </summary>
    [TestModule("e4607eb1-c969-42d5-933a-db7fd2cbe953", ModuleType.Recording, 1)]
    public partial class Verify_MZX_MX_Series_Panel_Loop_Card_Gallery_And_Addition_Of_Devices : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_MZX_MX_Series_Panel_Loop_Card_Gallery_And_Addition_Of_Devices instance = new Verify_MZX_MX_Series_Panel_Loop_Card_Gallery_And_Addition_Of_Devices();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_MZX_MX_Series_Panel_Loop_Card_Gallery_And_Addition_Of_Devices()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_MZX_MX_Series_Panel_Loop_Card_Gallery_And_Addition_Of_Devices Instance
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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "MZX253", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("XLM800", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("XLM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("XLM800-C");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Detectors", "801 CH");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Call points", "CP 820");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "SoundersBeacons", "LPAV 3000");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Ancillary", "CIM 800");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Ancillary Conventional", "DDM 800 Loop");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Ancillary Specific", "APM 800");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Other", "LI800");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("DIN 830", "Call points");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("LPSY 800 - R/W", "SoundersBeacons");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("DDM 800 Loop (Fast CallPoints)", "Ancillary Conventional");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Junction Box\r\n", "Other");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.DeleteDeviceUsingLabelInInventoryTab("XLM800-C");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("XLM800-STI", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("XLM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("XLM800-STI-D");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Detectors_STI", "Analogue Sensor STI\r\n");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Call points STI", "Man. Callpoint STI\r\n");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Ancillary STI", "Remote Indicat. STI\r\n");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Other STI", "Monitored Output STI\r\n");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Zone Monitor STI\r\n", "Detectors_STI");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Remote Indicat. STI\r\n", "Ancillary STI");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Monitored Output STI\r\n", "Other STI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.DeleteDeviceUsingLabelInInventoryTab("XLM800-STI-C");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("XLM800-Zetfas", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("XLM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("XLM800-Zetfas-C");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Detectors_Zetfas", "Ion Sensor IR3-S1\r\n");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Ancillary Zetfas", "ADK/UAK\r\n");
            Delay.Milliseconds(0);
            
            Libraries.Gallery_Functions.verifyGalleryListItems("T1832", "Other Zetfas", "Callpoint HM3-D1/S1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Ion Sensor IR3-S1\r\n", "Detectors_Zetfas");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Extinguisher LAV II\r\n", "Ancillary Zetfas");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("Callpoint HM3-D1/S1\r\n", "Other Zetfas");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
