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
    ///The Verify_Persistance_Of_Region_Name_Property_On_Cut_Paste recording.
    /// </summary>
    [TestModule("d77c9b28-e21b-4f69-b248-b21217a9522c", ModuleType.Recording, 1)]
    public partial class Verify_Persistance_Of_Region_Name_Property_On_Cut_Paste : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Persistance_Of_Region_Name_Property_On_Cut_Paste instance = new Verify_Persistance_Of_Region_Name_Property_On_Cut_Paste();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Persistance_Of_Region_Name_Property_On_Cut_Paste()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Persistance_Of_Region_Name_Property_On_Cut_Paste Instance
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
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("PLX800", "Loops", "PFI");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "PLX800-E");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Backplane");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PLX");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("PLX800-E");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMultiplePointWizardWithRegion("801 CH", ValueConverter.ArgumentFromString<int>("DeviceQty", "1"), "4");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.editDeviceLabel("6", "Label", "TEXT-E");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Cut");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPasteButtonEnabled();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Paste");
            Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Address", "E");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("7", "Address", "F");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("8", "Address", "G");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("9", "Address", "H");
            //Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "TEXT-E");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.editDeviceLabel("6", "Label", "TEXT-5");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Cut");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyPasteButtonEnabled();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Paste");
            Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Address", "E");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("7", "Address", "F");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("8", "Address", "G");
            //Delay.Milliseconds(0);
            
            //Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("9", "Address", "H");
            //Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "TEXT-E");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
