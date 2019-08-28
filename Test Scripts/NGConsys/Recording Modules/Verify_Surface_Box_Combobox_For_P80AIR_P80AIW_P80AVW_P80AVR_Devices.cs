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
    ///The Verify_Surface_Box_Combobox_For_P80AIR_P80AIW_P80AVW_P80AVR_Devices recording.
    /// </summary>
    [TestModule("893fef41-5d10-4cac-8a3f-cea287c70a18", ModuleType.Recording, 1)]
    public partial class Verify_Surface_Box_Combobox_For_P80AIR_P80AIW_P80AVW_P80AVR_Devices : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Surface_Box_Combobox_For_P80AIR_P80AIW_P80AVW_P80AVR_Devices instance = new Verify_Surface_Box_Combobox_For_P80AIR_P80AIW_P80AVW_P80AVR_Devices();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Surface_Box_Combobox_For_P80AIR_P80AIW_P80AVW_P80AVR_Devices()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Surface_Box_Combobox_For_P80AIR_P80AIW_P80AVW_P80AVR_Devices Instance
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
            
            Libraries.LinkedHardware_Fuctions.VerifySurfaceBoxParameters("TC_55046_55052_55056_Verify_Combobox_And_Shopping_List", "TC_55056");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveProject("55056");
            Delay.Milliseconds(0);
            
            //Libraries.Common_Functions.Application_Close(ValueConverter.ArgumentFromString<bool>("Save", "False"), ValueConverter.ArgumentFromString<bool>("SaveConfirmation", "False"), "");
            //Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ReopenProject("55056");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.SiteNode1' at Center.", repo.FormMe.SiteNode1Info, new RecordItemIndex(5));
            //repo.FormMe.SiteNode1.Click();
            //Delay.Milliseconds(200);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMe.tab_ShoppingList' at Center.", repo.FormMe.tab_ShoppingListInfo, new RecordItemIndex(7));
            repo.FormMe.tab_ShoppingList.Click();
            Delay.Milliseconds(200);
            
            //Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("S-BOXR Shallow box wallsdr Red", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            //Delay.Milliseconds(0);
            
            Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("557.080.007", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("557.080.011", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("557.080.008", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
            Libraries.Export_Functions.SearchDeviceInExportUsingSKUOrDescription("557.080.012", ValueConverter.ArgumentFromString<bool>("sExist", "True"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
