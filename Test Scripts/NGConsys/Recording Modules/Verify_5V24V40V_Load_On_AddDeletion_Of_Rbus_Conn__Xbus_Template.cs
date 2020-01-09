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
    ///The Verify_5V24V40V_Load_On_AddDeletion_Of_Rbus_Conn__Xbus_Template recording.
    /// </summary>
    [TestModule("8bb0cd77-dd31-4022-94c4-0646ec21eb7f", ModuleType.Recording, 1)]
    public partial class Verify_5V24V40V_Load_On_AddDeletion_Of_Rbus_Conn__Xbus_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_5V24V40V_Load_On_AddDeletion_Of_Rbus_Conn__Xbus_Template instance = new Verify_5V24V40V_Load_On_AddDeletion_Of_Rbus_Conn__Xbus_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_5V24V40V_Load_On_AddDeletion_Of_Rbus_Conn__Xbus_Template()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_5V24V40V_Load_On_AddDeletion_Of_Rbus_Conn__Xbus_Template Instance
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

            Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FIRECLASS 64-4", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.250", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.250", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.270", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Main");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("MPM800", "Miscellaneous", "FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.297", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.297", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.270", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("Zonal Alarm Display 64", "Attached Functionality", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.120", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.120", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.270", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Delete");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.250", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.250", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.270", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FIRECLASS 240-2", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.250", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.160", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.250", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.160", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Main");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("MPM800", "Miscellaneous", "FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.110", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.160", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.110", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.160", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectInventoryGridRow("2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.AddDevicesfromMainProcessorGallery("Zonal Alarm Display 64", "Attached Functionality", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.110", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.160", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.110", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.160", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.RightClickOnSelectedInventoryGridRow("2");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.clickContextMenuOptionOnRightClick("Delete");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.250", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.250", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.270", "40V");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
