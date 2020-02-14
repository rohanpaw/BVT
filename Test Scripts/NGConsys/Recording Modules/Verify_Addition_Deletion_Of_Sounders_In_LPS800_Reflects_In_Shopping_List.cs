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
    ///The Verify_Addition_Deletion_Of_Sounders_In_LPS800_Reflects_In_Shopping_List recording.
    /// </summary>
    [TestModule("19afc002-51fb-44c7-98d4-83fc78e4dd53", ModuleType.Recording, 1)]
    public partial class Verify_Addition_Deletion_Of_Sounders_In_LPS800_Reflects_In_Shopping_List : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Addition_Deletion_Of_Sounders_In_LPS800_Reflects_In_Shopping_List instance = new Verify_Addition_Deletion_Of_Sounders_In_LPS800_Reflects_In_Shopping_List();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Addition_Deletion_Of_Sounders_In_LPS800_Reflects_In_Shopping_List()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Addition_Deletion_Of_Sounders_In_LPS800_Reflects_In_Shopping_List Instance
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
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGallery("LPS 800", "Sounders/Beacons");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGalleryNotHavingImages("Flashni Sounder", "Conventional Sounders");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromGalleryNotHavingImages("Squashni Sounder", "Conventional Sounders");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnShoppingListTab();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyShoppingListDevices("TC_51728_Verify_Addition_Deletion_Of_Sounders_In_LPS800_Reflects_In_Shopping_List", "Add Devices");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyShoppingList(ValueConverter.ArgumentFromString<int>("ShoppingListDeviceCount", "6"));
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.DeleteDeviceUsingLabel("Flashni Sounder");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.DeleteDeviceUsingLabel("Squashni Sounder");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnShoppingListTab();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyShoppingList(ValueConverter.ArgumentFromString<int>("ShoppingListDeviceCount", "4"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
