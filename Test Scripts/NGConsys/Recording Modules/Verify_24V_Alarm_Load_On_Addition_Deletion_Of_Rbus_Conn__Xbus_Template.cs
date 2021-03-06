///////////////////////////////////////////////////////////////////////////////
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
    ///The Verify_24V_Alarm_Load_On_Addition_Deletion_Of_Rbus_Conn__Xbus_Template recording.
    /// </summary>
    [TestModule("db3b9404-a8e7-4335-9815-b8d8f363970c", ModuleType.Recording, 1)]
    public partial class Verify_24V_Alarm_Load_On_Addition_Deletion_Of_Rbus_Conn__Xbus_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_24V_Alarm_Load_On_Addition_Deletion_Of_Rbus_Conn__Xbus_Template instance = new Verify_24V_Alarm_Load_On_Addition_Deletion_Of_Rbus_Conn__Xbus_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_24V_Alarm_Load_On_Addition_Deletion_Of_Rbus_Conn__Xbus_Template()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_24V_Alarm_Load_On_Addition_Deletion_Of_Rbus_Conn__Xbus_Template Instance
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

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "P405D", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnPanelCalculationsTab();
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify24VPSULoadValue("0.301", "FIM1");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.291", "24V Rail(A)");
            Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.ClickOnNavigationTreeExpander("Main");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.additionOfDevicesOnRBus("Verify_24V_Alarm_Load_On_Addition_Deletion_Of_RBus_And_XBus", "Add RBus Devices", "FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnPanelCalculationsTab();
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify24VPSULoadValue("0.348", "FIM1");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.310", "24V Rail(A)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelNameForRBUSOneRow("MPM800-1");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.additionOfDevicesForXBus("Verify_24V_Alarm_Load_On_Addition_Deletion_Of_RBus_And_XBus", "Add XBus Devices", "FIM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(17));
            Delay.Duration(5000, false);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnPanelCalculationsTab();
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify24VPSULoadValue("0.348", "FIM1");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.310", "24V Rail(A)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("R-BUS");
            Delay.Milliseconds(0);
            
            //Libraries.Devices_Functions.DeleteDevices("Verify_24V_Alarm_Load_On_Addition_Deletion_Of_RBus_And_XBus", "Delete Devices");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectRowUsingLabelNameForRBUS("MPM800-1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnDeleteButton();
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnPanelCalculationsTab();
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify24VPSULoadValue("0.365", "FIM1");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.291", "24V Rail(A)");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
