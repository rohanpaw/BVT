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

namespace Fireclass.DenmarkFCRecordingsModule
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_FC602S_And_FC604S_Series_Panel_Gallery_Items_For_Ethernet_Node recording.
    /// </summary>
    [TestModule("81ac8833-4aee-4246-bb3b-e6034fd8cb0e", ModuleType.Recording, 1)]
    public partial class Verify_FC602S_And_FC604S_Series_Panel_Gallery_Items_For_Ethernet_Node : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Fireclass.FireclassRepository repository.
        /// </summary>
        public static global::Fireclass.FireclassRepository repo = global::Fireclass.FireclassRepository.Instance;

        static Verify_FC602S_And_FC604S_Series_Panel_Gallery_Items_For_Ethernet_Node instance = new Verify_FC602S_And_FC604S_Series_Panel_Gallery_Items_For_Ethernet_Node();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_FC602S_And_FC604S_Series_Panel_Gallery_Items_For_Ethernet_Node()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_FC602S_And_FC604S_Series_Panel_Gallery_Items_For_Ethernet_Node Instance
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

            TestProject.Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FC604S", "");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Common_Functions.ClickOnNavigationTreeItem("Ethernet");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Gallery_Functions.verifyGalleryListItems("FC_Gallery_Ethernet_FC600_FC700_Series_Panels", "Denmark", "FC8AS");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("FC1DS", "Repeaters");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.SelectRowUsingLabelNameFromInventoryTab("FC1DS-2");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Gallery_Functions.verifyGalleryListItems("FC_Gallery_Ethernet_AttachedFunctionality_FC600_FC700_Series_Panels", "Denmark", "FCZ8DS");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.SelectRowUsingLabelNameFromInventoryTab("FC1DS-2");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("Two FCZ4DS", "Attached Functionality");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.SelectRowUsingSKUFromInventoryTab("557.200.954");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("FC1DS", "Repeaters");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("FC1DS", "Repeaters");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("FC8AS", "Repeaters");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.SelectRowUsingModelNameFromInventoryTab("FCZ8DS");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("FC1DS", "Repeaters");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("FC1DS", "Repeaters");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("FC1DS", "Repeaters");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Devices_Functions.AddDevicesfromGallery("FC8AS", "Repeaters");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Common_Functions.VerifyNavigationTreeItemText("Ethernet (8 of 8)");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Gallery_Functions.verifyGalleryExistsWithDropdown(ValueConverter.ArgumentFromString<bool>("GalleryVisibility", "False"), "FC1DS");
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Gallery_Functions.verifyGalleryExistsWithDropdown(ValueConverter.ArgumentFromString<bool>("GalleryVisibility", "False"), "Two FCZ4DS");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
