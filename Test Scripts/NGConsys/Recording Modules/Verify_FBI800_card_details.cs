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
    ///The Verify_FBI800_card_details recording.
    /// </summary>
    [TestModule("aa209ed5-2360-4a04-b4f0-d223a15560e0", ModuleType.Recording, 1)]
    public partial class Verify_FBI800_card_details : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_FBI800_card_details instance = new Verify_FBI800_card_details();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_FBI800_card_details()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_FBI800_card_details Instance
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
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("FBI800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "FBI800-1");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "SKU", "557.202.845");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Model", "FBI800");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Connection", "Backplane");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.editDeviceLabel("6", "Label", "FBI800-3");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryDeviceProperty("Region name", "FBI800-3");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProjectFromFileOption("378_3");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("378_3");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "FBI800-3");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "SKU", "557.202.844");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Model", "FBI800");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Connection", "Backplane");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro16xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("FBI800", "Slot Cards", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "FBI800-1");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "SKU", "557.202.845");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Model", "FBI800");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Connection", "Backplane");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.editDeviceLabel("6", "Label", "FBI800-3");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryDeviceProperty("Region name", "FBI800-3");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProjectFromFileOption("378_3");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("378_3");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "FBI800-3");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "SKU", "557.202.844");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Model", "FBI800");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Connection", "Backplane");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
