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
    ///The Verify_Acc_Gall_Update_On_Max_Limit_Of_IOBFBPCSPOS_Supported_By_Panel_Is_Reached recording.
    /// </summary>
    [TestModule("c57f3a20-042a-4304-b545-608f5a8c1659", ModuleType.Recording, 1)]
    public partial class Verify_Acc_Gall_Update_On_Max_Limit_Of_IOBFBPCSPOS_Supported_By_Panel_Is_Reached : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestProject.NGConsysRepository repository.
        /// </summary>
        public static global::TestProject.NGConsysRepository repo = global::TestProject.NGConsysRepository.Instance;

        static Verify_Acc_Gall_Update_On_Max_Limit_Of_IOBFBPCSPOS_Supported_By_Panel_Is_Reached instance = new Verify_Acc_Gall_Update_On_Max_Limit_Of_IOBFBPCSPOS_Supported_By_Panel_Is_Reached();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Acc_Gall_Update_On_Max_Limit_Of_IOBFBPCSPOS_Supported_By_Panel_Is_Reached()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Acc_Gall_Update_On_Max_Limit_Of_IOBFBPCSPOS_Supported_By_Panel_Is_Reached Instance
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

            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro16xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnPanelAccessoriesTab();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyEnableDisablePanelAccessoriesGallery("Accessories", "IOB800", "Enabled");
            Delay.Milliseconds(0);
            
            Libraries.SlotCards_Functions.VerifyAccessoriesGalleryUpdateOnMaxLimitSupportedByPanel("TC_61_Verify_Accessories_Gallery_Update_On_Max_Limit_Of_IOB_FB_PCS_POS_Supported_By_Panel_Is_Reached", "Add Devices");
            Delay.Milliseconds(0);
            
            //Libraries.Devices_Functions.SelectRowUsingLabelName("IOB800-1");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectFirstRowUsingLabelNameFromPanelAccessoriesTab("IOB800-1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnDeleteButton();
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnPanelAccessoriesTab();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyEnableDisablePanelAccessoriesGallery("Accessories", "IOB800", "Enabled");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Site");
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.DeletePanel(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Node1", ValueConverter.ArgumentFromString<int>("rowNumber", "1"));
            Delay.Milliseconds(0);
            
            Libraries.Panel_Functions.AddPanels(ValueConverter.ArgumentFromString<int>("NumberofPanels", "1"), "Pro32xD", "");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeExpander("Node");
            Delay.Milliseconds(0);
            
            Libraries.SlotCards_Functions.VerifyAccessoriesGalleryUpdateOnMaxLimitSupportedByPanel("TC_61_Verify_Accessories_Gallery_Update_On_Max_Limit_Of_IOB_FB_PCS_POS_Supported_By_Panel_Is_Reached", "Add POS Devices");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnPanelAccessoriesTab();
            Delay.Milliseconds(0);
            
            //Libraries.Devices_Functions.SelectRowUsingLabelName("POS800-M-7");
            //Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.SelectFirstRowUsingLabelNameFromPanelAccessoriesTab("POS800-M-1");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnDeleteButton();
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.ClickOnNavigationTreeItem("Node");
            Delay.Milliseconds(0);
            
            Libraries.Common_Functions.clickOnPanelAccessoriesTab();
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyEnableDisablePanelAccessoriesGallery("Accessories", "POS800-M", "Enabled");
            Delay.Milliseconds(0);
            
            Libraries.Devices_Functions.VerifyEnableDisablePanelAccessoriesGallery("Accessories", "POS800-S", "Enabled");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
