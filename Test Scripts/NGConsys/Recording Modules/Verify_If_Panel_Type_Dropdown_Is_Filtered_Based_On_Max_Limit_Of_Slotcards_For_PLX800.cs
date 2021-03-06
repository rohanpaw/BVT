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
    ///The Verify_If_Panel_Type_Dropdown_Is_Filtered_Based_On_Max_Limit_Of_Slotcards_For_PLX800 recording.
    /// </summary>
    [TestModule("4b4e92db-9afe-47c2-8fbb-08f8fd9300e2", ModuleType.Recording, 1)]
    public partial class Verify_If_Panel_Type_Dropdown_Is_Filtered_Based_On_Max_Limit_Of_Slotcards_For_PLX800 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_If_Panel_Type_Dropdown_Is_Filtered_Based_On_Max_Limit_Of_Slotcards_For_PLX800 instance = new Verify_If_Panel_Type_Dropdown_Is_Filtered_Based_On_Max_Limit_Of_Slotcards_For_PLX800();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_If_Panel_Type_Dropdown_Is_Filtered_Based_On_Max_Limit_Of_Slotcards_For_PLX800()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_If_Panel_Type_Dropdown_Is_Filtered_Based_On_Max_Limit_Of_Slotcards_For_PLX800 Instance
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

            Libraries.SlotCards_Functions.VerifyPanelTypeDropdownOnSlotCardsPosition("TC_51999_Verify_If_Panel_Type_Dropdown_Is_Filtered_Based_On_Max_Limit_Of_Slotcards_For_PLX800", "Add Devices");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
