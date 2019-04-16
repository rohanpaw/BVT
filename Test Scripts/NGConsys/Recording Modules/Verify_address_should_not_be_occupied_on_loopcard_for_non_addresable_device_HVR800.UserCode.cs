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
using TestProject.Libraries;

namespace TestProject.Recording_Modules
{
	public partial class Verify_address_should_not_be_occupied_on_loopcard_for_non_addresable_device_HVR800
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	
		public void verifyBlankDeviceAddress(string ExpectedPointGridRowCount, string ExpectedPointGridColumn)
		{
			// Retrieve Point grid rows and column count
			sColumn = Devices_Functions.getColumnNumberForPointsGrid(ExpectedPointGridColumn);
			sRow = ExpectedPointGridRowCount;
			
			Report.Log(ReportLevel.Success,"Row an column values are set as"+sColumn+sRow);
			
			string ActualPointGridProperty = repo.FormMe.txt_PointGridDeviceProperty.TextValue;
			// Compare Actual and Expected Point Grid Row count
			Report.Log(ReportLevel.Success,"Actual"+ActualPointGridProperty);
			
			if(ActualPointGridProperty==null)
			{
				Report.Log(ReportLevel.Success,"Device address is verified in Points grid as blank");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device address is not blank");
			}
		}
	
		

	}
}
