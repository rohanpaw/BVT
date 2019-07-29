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
    ///The Verify_5V_Load_On_Changing_CPU_Of_Panel recording.
    /// </summary>
    [TestModule("87203d2e-5867-4942-9f7d-9ba9a5680bba", ModuleType.Recording, 1)]
    public partial class Verify_5V_Load_On_Changing_CPU_Of_Panel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_5V_Load_On_Changing_CPU_Of_Panel instance = new Verify_5V_Load_On_Changing_CPU_Of_Panel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_5V_Load_On_Changing_CPU_Of_Panel()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_5V_Load_On_Changing_CPU_Of_Panel Instance
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

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "MX 4000", "");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.ChangeCPUType("CPU 801");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(2));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.LoopExpander1' at Center.", repo.FormMe.LoopExpander1Info, new RecordItemIndex(3));
            repo.FormMe.LoopExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(4));
            repo.FormMe.Loop_A1.Click();
            Delay.Milliseconds(200);
            
            Libraries.PSULoad_Functions.verifyMax5VPSULoad("3.000", "FIM", ValueConverter.ArgumentFromString<int>("rowNumber", "12"));
            Delay.Milliseconds(0);
            
            Libraries.PSULoad_Functions.verify5VPSULoadValue("0.349", "FIM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(7));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.txt_SearchProperties' at Center.", repo.ProfileConsys1.txt_SearchPropertiesInfo, new RecordItemIndex(8));
            repo.ProfileConsys1.txt_SearchProperties.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(9));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Libraries.Panel_Functions.ChangeCPUType("CPU 800");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(11));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.LoopExpander1' at Center.", repo.FormMe.LoopExpander1Info, new RecordItemIndex(12));
            repo.FormMe.LoopExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(13));
            repo.FormMe.Loop_A1.Click();
            Delay.Milliseconds(200);
            
            Libraries.PSULoad_Functions.verify5VPSULoadValue("0.214", "FIM");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Node1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "MX2-100", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(17));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Libraries.Panel_Functions.ChangeCPUType("CPU 801");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(19));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.LoopExpander1' at Center.", repo.FormMe.LoopExpander1Info, new RecordItemIndex(20));
            repo.FormMe.LoopExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(21));
            repo.FormMe.Loop_A1.Click();
            Delay.Milliseconds(200);
            
            Libraries.PSULoad_Functions.verifyMax5VPSULoad("3.000", "FIM", ValueConverter.ArgumentFromString<int>("rowNumber", "12"));
            Delay.Milliseconds(0);
            
            Libraries.PSULoad_Functions.verify5VPSULoadValue("0.349", "FIM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(24));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProfileConsys1.txt_SearchProperties' at Center.", repo.ProfileConsys1.txt_SearchPropertiesInfo, new RecordItemIndex(25));
            repo.ProfileConsys1.txt_SearchProperties.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(26));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Libraries.Panel_Functions.ChangeCPUType("CPU 800");
            Delay.Milliseconds(0);
            
            Libraries.PSULoad_Functions.verify5VPSULoadValue("0.214", "FIM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.NodeExpander1' at Center.", repo.FormMe.NodeExpander1Info, new RecordItemIndex(29));
            repo.FormMe.NodeExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.LoopExpander1' at Center.", repo.FormMe.LoopExpander1Info, new RecordItemIndex(30));
            repo.FormMe.LoopExpander1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.Loop_A1' at Center.", repo.FormMe.Loop_A1Info, new RecordItemIndex(31));
            repo.FormMe.Loop_A1.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
