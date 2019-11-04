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
    ///The Verify_persistance_Of_Loop_Properties_on_Copy_Paste recording.
    /// </summary>
    [TestModule("4a0775d8-a68f-48c8-b0fa-9133aa087947", ModuleType.Recording, 1)]
    public partial class Verify_persistance_Of_Loop_Properties_on_Copy_Paste : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_persistance_Of_Loop_Properties_on_Copy_Paste instance = new Verify_persistance_Of_Loop_Properties_on_Copy_Paste();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_persistance_Of_Loop_Properties_on_Copy_Paste()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_persistance_Of_Loop_Properties_on_Copy_Paste Instance
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
            
            Libraries.Devices_Functions.SelectInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.ChangeCableLengthFromInventory(ValueConverter.ArgumentFromString<int>("fchangeCableLength", "1000"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Copy");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Paste with Points");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyCableLengthInNodeGalleryItems("1,000");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PLX/External Loop Card 3");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("PLX800-9");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceUsingLabelName("801 CH - 1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.ChangeCableLengthFromInventory(ValueConverter.ArgumentFromString<int>("fchangeCableLength", "1000"));
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Copy");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Paste with Points");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("6");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyCableLengthInNodeGalleryItems("500");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PLX/External Loop Card 4");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("PLX800-13");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyDeviceUsingLabelName("801 CH - 1");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
