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
    ///The Verify_Slot_Address_DIP_Switches_Are_Not_Available_In_NGDesigner recording.
    /// </summary>
    [TestModule("0735a449-8dab-4e04-b9b6-88a103cc9d01", ModuleType.Recording, 1)]
    public partial class Verify_Slot_Address_DIP_Switches_Are_Not_Available_In_NGDesigner : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Slot_Address_DIP_Switches_Are_Not_Available_In_NGDesigner instance = new Verify_Slot_Address_DIP_Switches_Are_Not_Available_In_NGDesigner();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Slot_Address_DIP_Switches_Are_Not_Available_In_NGDesigner()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Slot_Address_DIP_Switches_Are_Not_Available_In_NGDesigner Instance
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

            Libraries.SlotCards_Functions.VerifySlotCardsAndBackplanesDistributionWithOnePanel("TC_76691_Verify_Slot_Address_DIP_Switches_Are_Not_Available_In_NGDesigner", "Add Devices");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.verifyDIPSwitches();
            Delay.Milliseconds(0);
            
            //Libraries.Devices_Functions.SelectRowUsingLabelNameFromInventoryTab("PNI800-2");
            //Delay.Milliseconds(0);
            
            //Libraries.Devices_Functions.verifyDIPSwitches();
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
