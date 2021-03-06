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

namespace Fireclass.DenmarkFCRecordingsModule
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateProject_Denmark_FC recording.
    /// </summary>
    [TestModule("e5acd6c5-02a2-4a5d-8fc7-d85fba7eca0e", ModuleType.Recording, 1)]
    public partial class CreateProject_Denmark_FC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Fireclass.NGConsysRepository repository.
        /// </summary>
        public static global::Fireclass.NGConsysRepository repo = global::Fireclass.NGConsysRepository.Instance;

        static CreateProject_Denmark_FC instance = new CreateProject_Denmark_FC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateProject_Denmark_FC()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateProject_Denmark_FC Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable sListIndex.
        /// </summary>
        [TestVariable("a91ee1e0-033a-42b0-846f-eab0504bc091")]
        public string sListIndex
        {
            get { return repo.sListIndex; }
            set { repo.sListIndex = value; }
        }

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

            TestProject.Libraries.Common_Functions.maximizeApplication();
            Delay.Milliseconds(0);
            
            TestProject.Libraries.Common_Functions.createNewProject("Denmark", "0");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
