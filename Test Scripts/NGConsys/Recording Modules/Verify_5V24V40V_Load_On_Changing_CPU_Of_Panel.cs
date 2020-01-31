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
    ///The Verify_5V24V40V_Load_On_Changing_CPU_Of_Panel recording.
    /// </summary>
    [TestModule("082dffce-d287-401e-a4f1-76d4a095c6c2", ModuleType.Recording, 1)]
    public partial class Verify_5V24V40V_Load_On_Changing_CPU_Of_Panel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_5V24V40V_Load_On_Changing_CPU_Of_Panel instance = new Verify_5V24V40V_Load_On_Changing_CPU_Of_Panel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_5V24V40V_Load_On_Changing_CPU_Of_Panel()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_5V24V40V_Load_On_Changing_CPU_Of_Panel Instance
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
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node1 - FireClass 64-4 ZL");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("1.500", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("3.100", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("1.250", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verifyMax5VPSULoad("1.500", "FIM", ValueConverter.ArgumentFromString<int>("rowNumber", "14"));
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verifyMax24VPSULoad("3.100", "FIM", ValueConverter.ArgumentFromString<int>("rowNumber", "15"));
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verifyMax40VPSULoadForFCPanel("1.250", "16");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.250", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.270", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.250", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node1 - FireClass 64-4 ZL");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.txt_SearchProperties' at Center.", repo.ProfileConsys1.txt_SearchPropertiesInfo, new RecordItemIndex(18));
            repo.ProfileConsys1.txt_SearchProperties.Click();
            Delay.Milliseconds(200);
            
            Libraries.Panel_Functions.ChangeCPUType("CPU 801");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM Loop Card");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.433", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.250", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.433", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.250", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.270", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanelsFC(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "FIRECLASS 240-4", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node1 - FireClass 240-4");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("1.500", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("3.100", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("1.250", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verifyMax5VPSULoad("1.500", "FIM", ValueConverter.ArgumentFromString<int>("rowNumber", "14"));
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verifyMax24VPSULoad("3.100", "FIM", ValueConverter.ArgumentFromString<int>("rowNumber", "15"));
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verifyMax40VPSULoadForFCPanel("1.250", "16");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.298", "5V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.250", "24V");
            //Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.270", "40V");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.298", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.250", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node1 - FireClass 64-4 ZL");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.txt_SearchProperties' at Center.", repo.ProfileConsys1.txt_SearchPropertiesInfo, new RecordItemIndex(47));
            repo.ProfileConsys1.txt_SearchProperties.Click();
            Delay.Milliseconds(200);
            
            Libraries.Panel_Functions.ChangeCPUType("CPU 801");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("FIM");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.433", "Main Processor 5V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.250", "Main Processor 24V (A)");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyLoadingDetailsValue("0.270", "40V (A)");
            Delay.Milliseconds(0);
            
            //Libraries.PSULoad_Functions.verify_5_24_40PSULoadValueFC("0.433", "5V");
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
