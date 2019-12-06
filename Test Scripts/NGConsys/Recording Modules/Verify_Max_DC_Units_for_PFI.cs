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
    ///The Verify_Max_DC_Units_for_PFI recording.
    /// </summary>
    [TestModule("0018cbaf-345a-47fa-8203-d06a50b382b4", ModuleType.Recording, 1)]
    public partial class Verify_Max_DC_Units_for_PFI : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Max_DC_Units_for_PFI instance = new Verify_Max_DC_Units_for_PFI();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Max_DC_Units_for_PFI()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Max_DC_Units_for_PFI Instance
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro32xD", "");
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            
            //Libraries.DC_Functions.verifyMaxDCUnits("4000");
            
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("4000", "Current (DC Units)");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
