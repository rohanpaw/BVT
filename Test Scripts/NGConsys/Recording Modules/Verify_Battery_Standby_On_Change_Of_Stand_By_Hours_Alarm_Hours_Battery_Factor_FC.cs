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
    ///The Verify_Battery_Standby_On_Change_Of_Stand_By_Hours_Alarm_Hours_Battery_Factor_FC recording.
    /// </summary>
    [TestModule("ef0bfe30-a9fa-4bf3-bed1-51ccf2ac3298", ModuleType.Recording, 1)]
    public partial class Verify_Battery_Standby_On_Change_Of_Stand_By_Hours_Alarm_Hours_Battery_Factor_FC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Battery_Standby_On_Change_Of_Stand_By_Hours_Alarm_Hours_Battery_Factor_FC instance = new Verify_Battery_Standby_On_Change_Of_Stand_By_Hours_Alarm_Hours_Battery_Factor_FC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Battery_Standby_On_Change_Of_Stand_By_Hours_Alarm_Hours_Battery_Factor_FC()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Battery_Standby_On_Change_Of_Stand_By_Hours_Alarm_Hours_Battery_Factor_FC Instance
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

            Libraries.PSULoad_Functions.verifyStandyByAlarmHourAndBatteryFactor("TC_71697_Verify_Battery_Standby_On_Change_Of_Stand_By_Hours_Alarm_Hours_Battery_Factor_FC", "Add Panels");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.SaveFCProject("TC_71697");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.Application_CloseFC(ValueConverter.ArgumentFromString<bool>("Save", "False"), ValueConverter.ArgumentFromString<bool>("SaveConfirmation", "False"), "");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
