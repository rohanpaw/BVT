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
    ///The Verify_cable_capacitance recording.
    /// </summary>
    [TestModule("4ee52b5d-398a-4876-8168-b3ffe53320a5", ModuleType.Recording, 1)]
    public partial class Verify_cable_capacitance : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_cable_capacitance instance = new Verify_cable_capacitance();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_cable_capacitance()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_cable_capacitance Instance
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Libraries.Devices_Functions.EnableISDevices();
            
            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro32xD", "");
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            
            //Libraries.Common_Functions.ClickOnNavigationTreeExpander("PFI");
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
            
            Libraries.Devices_Functions.CableCapacitance("TC_114_Verify_Cable_capacitance", "Devices");
            
            Libraries.Devices_Functions.ChangeCableLength("PFI", ValueConverter.ArgumentFromString<int>("fCableLength1", "500"), ValueConverter.ArgumentFromString<int>("fCableLength2", "500"));
            
            // Do update max AC Units on changing values in excel
            //Libraries.AC_Functions.verifyMaxACUnitsValue("128");
            
            // Do update max AC Units on changing values in excel
            Libraries.Devices_Functions.verifyMaxLoadingDetailsValue("128", "Signal (AC Units)");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
