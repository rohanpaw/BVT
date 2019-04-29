﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TestProject.Recording_Modules
{
    public partial class Verify_Properties_For_LPS800_In_Points_Grid_And_Properties_Section_With_FIM
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void verifySKU(bool sSKU)
        {
			//Click on Points tab
			repo.ProfileConsys1.tab_Points.Click();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search SKU property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("SKU" +"{ENTER}" );
			
			// Click on SKU cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			// Retrieve SKU Visibility
			bool actualSKU = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.EnsureVisible();
			
			if(actualSKU.Equals(sSKU))
			{
				Report.Log(ReportLevel.Success,"SKU is displayed correctly");
			}
		else
			{
				Report.Log(ReportLevel.Failure,"SKU is displayed incorrectly");
			}
			//Click on Points tab
			repo.ProfileConsys1.tab_Points.Click();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }

        public void verifyZone(bool sZone)
        {
			//Click on Points tab
			repo.ProfileConsys1.tab_Points.Click();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Zone property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Zone" +"{ENTER}" );
			
			// Click on Zone cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			// Retrieve Zone Visibility
			bool actualZoneDescription = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.EnsureVisible();
			
	
			
			if(actualZoneDescription.Equals(sZone))
			{
				Report.Log(ReportLevel.Success,"Zone is displayed correctly");
			}
		else
			{
				Report.Log(ReportLevel.Failure,"Zone is displayed incorrectly");
			}
			//Click on Points tab
			repo.ProfileConsys1.tab_Points.Click();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }

    }
}
