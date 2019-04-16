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
    ///The Verification_for_device_Label recording.
    /// </summary>
    [TestModule("5446ddf6-5984-44ac-9653-3a4ea504726a", ModuleType.Recording, 1)]
    public partial class Verification_for_device_Label : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verification_for_device_Label instance = new Verification_for_device_Label();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verification_for_device_Label()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verification_for_device_Label Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable PanelNode.
        /// </summary>
        [TestVariable("361584a9-c082-463b-bb0a-d3f851f66bcb")]
        public string PanelNode
        {
            get { return repo.PanelNode; }
            set { repo.PanelNode = value; }
        }

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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.VerifyPanelNode' at Center.", repo.ProfileConsys1.NavigationTree.VerifyPanelNodeInfo, new RecordItemIndex(1));
            repo.ProfileConsys1.NavigationTree.VerifyPanelNode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_PanelAccessories' at Center.", repo.FormMe.tab_PanelAccessoriesInfo, new RecordItemIndex(2));
            repo.FormMe.tab_PanelAccessories.Click();
            Delay.Milliseconds(200);
            
            Libraries.Devices_Functions.AddDevicefromPanelAccessoriesGallery("IOB800", "Accessories");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.MainProcessor' at Center.", repo.FormMe.MainProcessorInfo, new RecordItemIndex(4));
            repo.FormMe.MainProcessor.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.NavigationTree.Expander' at Center.", repo.ProfileConsys1.NavigationTree.ExpanderInfo, new RecordItemIndex(5));
            repo.ProfileConsys1.NavigationTree.Expander.Click();
            Delay.Milliseconds(200);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "SKU", "557.202.006");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Model", "IOB800");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Label", "IOB800-1");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Slot Address", "1");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.verifyInventoryGridProperties("6", "Connection", "Other Slot Cards 1");
            Delay.Milliseconds(0);
            
            Libraries.InventoryGrid_Functions.editDeviceLabel("6", "Label", "IOB-Test");
            Delay.Milliseconds(0);
            
            verifyInventoryDeviceProperty("Label", "IOB-Test");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
