/*
 * Created by Ranorex
 * User: jbhosash
 * Date: 8/27/2018
 * Time: 3:20 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Windows;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestProject.Libraries
{
	
	[UserCodeCollection]
	public class Devices_Functions
	{
		
		//Create instance of repository to access repository items
		static NGConsysRepository repo = NGConsysRepository.Instance;
		
		static string ModelNumber
		{
			
			get { return repo.ModelNumber; }
			set { repo.ModelNumber = value; }
		}
		
		static string sDeviceOrderRow
		{
			get { return repo.sDeviceOrderRow; }
			set { repo.sDeviceOrderRow = value; }
		}
		
		static string sRow
		{
			get { return repo.sRow; }
			set { repo.sRow = value; }
		}
		static string sLabelName
		{
			get { return repo.sLabelName; }
			set { repo.sLabelName = value; }
		}
		
		static string sGalleryIndex
		{
			get { return repo.sGalleryIndex; }
			set { repo.sGalleryIndex = value; }
		}
		
		static string sDeviceIndex
		{
			get { return repo.sDeviceIndex; }
			set { repo.sDeviceIndex = value; }
		}
		
		static string sACUnits
		{
			get { return repo.sACUnits; }
			set { repo.sACUnits = value; }
		}
		
		static string sMaxACUnits
		{
			get { return repo.sMaxACUnits; }
			set { repo.sMaxACUnits = value; }
		}
		static string sBase
		{
			get { return repo.sBase; }
			set { repo.sBase = value; }
		}
		
		static string sRowIndex
		{
			get { return repo.sRowIndex; }
			set { repo.sRowIndex = value; }
		}
		
		static string sDeviceSensitivity
		{
			get { return repo.sDeviceSensitivity; }
			set { repo.sDeviceSensitivity = value; }
		}
		
		static string sDeviceMode
		{
			get { return repo.sDeviceMode; }
			set { repo.sDeviceMode = value; }
		}
		
		static string sDayMode
		{
			get { return repo.sDayMode; }
			set { repo.sDayMode = value; }
		}
		
		static string sDaySensitivity
		{
			get { return repo.sDaySensitivity; }
			set { repo.sDaySensitivity = value; }
		}
		
		static string sMainProcessorGalleryIndex
		{
			get { return repo.sMainProcessorGalleryIndex; }
			set { repo.sMainProcessorGalleryIndex = value; }
		}
		
		static string sRBusGalleryIndex
		{
			get { return repo.sRBusGalleryIndex; }
			set { repo.sRBusGalleryIndex = value; }
		}
		
		static string sDeviceName
		{
			get { return repo.sDeviceName; }
			set { repo.sDeviceName = value; }
		}
		
		static string sAccessoriesGalleryIndex
		{
			get { return repo.sAccessoriesGalleryIndex; }
			set { repo.sAccessoriesGalleryIndex = value; }
		}
		
		static string sDeviceOrderName
		{
			get { return repo.sDeviceOrderName; }
			set { repo.sDeviceOrderName = value; }
		}
		
		static string sListIndex
		{
			get { return repo.sListIndex; }
			set { repo.sListIndex = value; }
		}
		
		static string sColumn
		{
			get { return repo.sColumn; }
			set { repo.sColumn = value; }
		}
		
		static string sPhysicalLayoutDeviceIndex
		{
			get { return repo.sPhysicalLayoutDeviceIndex; }
			set { repo.sPhysicalLayoutDeviceIndex = value; }
		}
		
		
		static string sDeviceAddress
		{
			get { return repo.sDeviceAddress; }
			set { repo.sDeviceAddress = value; }
		}
		
		static string sOtherSlotCardName
		{
			get { return repo.sOtherSlotCardName; }
			set { repo.sOtherSlotCardName = value; }
		}
		
		static string sGalleryName
		{
			get { return repo.sGalleryName; }
			set { repo.sGalleryName = value; }
		}
		
		static string sExpanderName
		{
			get { return repo.sExpanderName; }
			set { repo.sExpanderName = value; }
		}
		
		static string sTreeItem
		{
			get { return repo.sTreeItem; }
			set { repo.sTreeItem = value; }
		}
		
		static string sLoadingDetail
		{
			get { return repo.sLoadingDetail; }
			set { repo.sLoadingDetail = value; }
		}
		
		
		/********************************************************************
		 * Function Name: AddDevices
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : 29/03/2019 Alpesh Dhakad- Updated btn_MultiplePointWizard xpath and change script accordingly
		 ********************************************************************/
		[UserCodeMethod]
		public static void AddDevices(string sFileName,string sSheetName)
		{
			
			Excel_Utilities.OpenExcelFile(sFileName,sSheetName);
			//Excel_Utilities.OpenSheet(sSheetName);
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			repo.FormMe.btn_MultiplePointWizard.Click();
			//repo.ProfileConsys1.btn_MultiplePointWizard_DoNotUse.Click();
			repo.AddDevices.txt_AllDevices.Click();
			
			
			for(int i=8;i<=rows;i++)
			{
				string sDeviceName=  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				repo.AddDevices.txt_SearchDevices.Click();
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+sDeviceName);
				ModelNumber = sDeviceName;
				repo.AddDevices.txt_ModelNumber.Click();
				
			}
			
			repo.AddDevices.btn_AddDevices.Click();
			Delay.Milliseconds(200);
			for(int i=8;i<=rows;i++)
			{
				string sDeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				ModelNumber = sDeviceName;
				sRow=(i-7).ToString();
				repo.ProfileConsys1.PanelInvetoryGrid.InventoryGridCell.Click();
				Validate.AttributeEqual(repo.ProfileConsys1.PanelInvetoryGrid.txt_DeviceNameInfo, "Text", sDeviceName);
				Delay.Milliseconds(100);
			}
			
			
			
			Excel_Utilities.ExcelWB.Close(false, null, null);
			//Excel_Utilities.ExcelAppl.Quit();
		}
		
		
		/****************************************************************************************************
		 * Function Name: AddDevicesfromGallery
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Alpesh Dhakad - 26/07/2019 - Updated script as per new build xpaths
		 ****************************************************************************************************/
		[UserCodeMethod]
		public static void AddDevicesfromGallery(string sDeviceName,string sType)
		{
			ModelNumber=sDeviceName;

			//sGalleryIndex = SelectGalleryType(sType);
			
			repo.FormMe.btn_AllGalleryDropdown.Click();
			repo.FormMe.btn_AllGalleryDropdown.EnsureVisible();
			//repo.FormMe.btn_DevicesGalleryDropDown1.Click();
			
			//repo.FormMe.btn_DevicesGalleryDropDown1.EnsureVisible();
			
			repo.ContextMenu.txt_SelectDevice.Click();
			
			
//			sGalleryIndex = SelectGalleryType(sType);
//			ModelNumber=sDeviceName;
//			repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
//			repo.ContextMenu.txt_SelectDevice.Click();
			Report.Log(ReportLevel.Success, "Device "+sDeviceName+" Added Successfully");
		}
		
		/********************************************************************
		 * Function Name: AddDevicesfromGalleryNotHavingImages
		 * Function Details: Select devices from gallery using caption displayed for image
		 * Parameter/Arguments: Device name(Model Number) and type of gallery
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Created on :19/2/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void AddDevicesfromGalleryNotHavingImages(string sDeviceName,string sType)
		{
			sGalleryIndex = SelectGalleryType(sType);
			ModelNumber=sDeviceName;
			repo.FormMe.btn_AllGalleryDropdown.Click();
			repo.FormMe.btn_AllGalleryDropdown.EnsureVisible();
			
			//repo.ProfileConsys1.btn_DevicesGalleryDropDown1.Click();
			repo.ContextMenu.txt_galleryItem.Click();
		}
		
		/************************************************************************************************************
		 * Function Name: verifyDevicesfromGalleryNotHavingImages
		 * Function Details: verify Given device exist in gallery
		 * Parameter/Arguments: Device name(Model Number), type of gallery, Visibility
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Created on :11/3/2019 Alpesh Dhakad - 30/07/2019 & 21/08/2019 Updated script as per new build and xpath
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyDevicesfromGalleryNotHavingImages(string sDeviceName,string sType,bool Visibility)
		{
			sGalleryIndex = SelectGalleryType(sType);
			ModelNumber=sDeviceName;
			
			repo.FormMe.btn_AllGalleryDropdown.Click();
			//repo.FormMe.btn_DevicesGalleryDropDown1.Click();
			//repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
			if(Visibility)
			{
				if(repo.ContextMenu.txt_galleryItemInfo.Exists())
				{
					Report.Log(ReportLevel.Success, "Device "+sDeviceName+" exist in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Device "+sDeviceName+" not exist in gallery");
				}
			}
			else
			{
				if(repo.ContextMenu.txt_galleryItemInfo.Exists())
				{
					Report.Log(ReportLevel.Failure, "Device "+sDeviceName+" exist in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Device "+sDeviceName+" not exist in gallery");
				}
				
			}
			
		}
		/********************************************************************
		 * Function Name: SelectGalleryType
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static string SelectGalleryType(string sType)
		{
			switch (sType)
			{
				case "Detectors":
					sGalleryIndex="4";
					break;
				case "Call points":
					sGalleryIndex="5";
					break;
				case "Sounders/Beacons":
					sGalleryIndex="6";
					break;
				case "Ancillary":
					sGalleryIndex="7";
					break;
				case "Ancillary Conventional":
					sGalleryIndex="8";
					break;
				case "Ancillary Specific":
					sGalleryIndex="9";
					break;
				case "Other":
					sGalleryIndex="10";
					break;
				case "Conventional Sounders":
					sGalleryIndex="11";
					break;
				default:
					Console.WriteLine("Please specify correct gallery name");
					break;
			}
			return sGalleryIndex;
		}
		
		/********************************************************************
		 * Function Name: SelectDeviceFromPanelAccessories
		 * Function Details: to check if the device is enabled/disabled in panel accessories gallery
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static string SelectDeviceFromPanelAccessories(string DeviceName)
		{
			switch (DeviceName)
			{
				case "IOB800":
					sDeviceIndex="0";
					break;
				case "FB800":
					sDeviceIndex="1";;
					break;
				case "PCS800":
					sDeviceIndex="2";
					break;
				case "POS800-S":
					sDeviceIndex="3";
					break;
				case "POS800-M":
					sDeviceIndex="4";
					break;
				case "PBB801":
					sDeviceIndex="5";
					break;
					
				default:
					Console.WriteLine("Please specify correct Device name");
					break;
			}
			return sDeviceIndex;
		}
		
		/********************************************************************
		 * Function Name: DeleteDevices
		 * Function Details: To delete devices using excel
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void DeleteDevices(string sFileName,string sSheetName)
		{
			Excel_Utilities.OpenExcelFile(sFileName,sSheetName);
			//Excel_Utilities.OpenSheet(sSheetName);
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			for(int i=8;i<=rows;i++)
			{
				sLabelName =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
				
				SelectRowUsingLabelName(sLabelName);
				
				if(repo.FormMe.txt_LabelName1Info.Exists())
				{
					Common_Functions.clickOnDeleteButton();
					//Validate.AttributeEqual(repo.FormMe.txt_LabelName1Info, "Text", sLabelName);
					Report.Log(ReportLevel.Success, "Device "+sLabelName+" deleted successfully");
				}
				
				else
				{
					
					Report.Log(ReportLevel.Failure, "Device "+sLabelName+" not found");
				}

			}
			
			//Excel_Utilities.ExcelWB.Close(false, null, null);
			//Excel_Utilities.ExcelAppl.Quit();
			
		}
		

		
		/*****************************************************************************************************
		 * Function Name: CableCapacitance
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale/Alpesh Dhakad
		 * Last Update : 11/07/2019 - Alpesh Dhakad - Update script and added InventoryGridFirstRow xpath
		 *****************************************************************************************************/
		[UserCodeMethod]
		public static void CableCapacitance(string sFileName,string sSheetName)
		{
			Excel_Utilities.OpenExcelFile(sFileName,sSheetName);
			//Excel_Utilities.OpenSheet(sSheetName);
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			for(int i=8;i<=rows;i++)
			{
				sRow=(i-7).ToString();
				string sDeviceName =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				string sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				string sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,9]).Value.ToString();
				
				AddDevicesfromGallery(sDeviceName,sType);
				
				string state =  ((Range)Excel_Utilities.ExcelRange.Cells[i,4]).Value.ToString();
				//VerifyGalleryItem(sType,sDeviceName,state);
				
//				if(sRow.Equals("1"))
//				{
//					repo.FormMe.InventoryGridFirstRow.Click();
//				}
//				else
//				{
//					//repo.ProfileConsys1.PanelInvetoryGrid.InventoryGridRow.Click();
//					repo.FormMe.InventoryGridRowForEXI.Click();
//				}
				
				SelectRowUsingLabelNameForEXIDevice(sLabelName);
					
				string CableCapacitanceValue =  ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				repo.ProfileConsys1.cell_CableCapacitance.Click();
				string capacitance=repo.ProfileConsys1.txt_CableCapacitance.TextValue;
				
				if(capacitance.Equals(CableCapacitanceValue))
				{
					Report.Log(ReportLevel.Success,"default cable capacitance displayed as "+capacitance);
				}
				
				else
				{
					Report.Log(ReportLevel.Failure,"default cable capacitance displayed as "+capacitance+" instead of "+CableCapacitanceValue);
				}
				
				//=================================
				Common_Functions.clickOnPhysicalLayoutTab();
				
				string maxACUnits = ((Range)Excel_Utilities.ExcelRange.Cells[i,7]).Value.ToString();
				string sACLoopLoadingName = ((Range)Excel_Utilities.ExcelRange.Cells[2,7]).Value.ToString();
				
			    //verifyMaxACUnitsValue(maxACUnits);
				Devices_Functions.verifyMaxLoadingDetailsValue(maxACUnits,sACLoopLoadingName);
				
				Common_Functions.clickOnPointsTab();
				
				//===================================
				string ChangedValue =  ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
				repo.ProfileConsys1.cell_CableCapacitance.DoubleClick();
				repo.ProfileConsys1.txt_CableCapacitance.PressKeys((ChangedValue) +"{ENTER}");
				
				Report.Log(ReportLevel.Success,"Cable capacitance changed to "+ChangedValue);

				
				if(sRow.Equals("1"))
				{
					repo.FormMe.InventoryGridFirstRow.Click();
				}
				else
				{
					//repo.ProfileConsys1.PanelInvetoryGrid.InventoryGridRow.Click();
					repo.FormMe.InventoryGridRowForEXI.Click();
				}
				
				Common_Functions.clickOnPointsTab();
				
				state =  ((Range)Excel_Utilities.ExcelRange.Cells[i,6]).Value.ToString();
				//VerifyGalleryItem(sType,sDeviceName,state);
				
				if(sRow.Equals("1"))
				{
					repo.FormMe.InventoryGridFirstRow.Click();
				}
				else
				{
					//repo.ProfileConsys1.PanelInvetoryGrid.InventoryGridRow.Click();
					repo.FormMe.InventoryGridRowForEXI.Click();
				}
				
				//=================================
				Common_Functions.clickOnPhysicalLayoutTab();
				
				string changedmaxACUnits = ((Range)Excel_Utilities.ExcelRange.Cells[i,8]).Value.ToString();
				//verifyMaxACUnitsValue(changedmaxACUnits);
				Devices_Functions.verifyMaxLoadingDetailsValue(changedmaxACUnits,sACLoopLoadingName);
				
				
				
				Common_Functions.clickOnPointsTab();
				
				//===================================
			}
			
			Excel_Utilities.ExcelWB.Close(false, null, null);
			Excel_Utilities.ExcelAppl.Quit();
			
			
		}

		/****************************************************************************************************************
		 * Function Name: VerifyGalleryItem
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Alpesh Dhakad - 21/08/2019 - Updated with new navigation tree method, xpath and devices gallery
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyGalleryItem(string sType,string deviceName, string state)
		{
			if(state.Equals("Enabled"))
			{
				ModelNumber=deviceName;
				
				repo.FormMe.btn_AllGalleryDropdown.Click();
				
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + deviceName+ " Enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + deviceName+ " Disabled in gallery");
				}
			}
			else
			{
				
				ModelNumber=deviceName;
				
				repo.FormMe.btn_AllGalleryDropdown.Click();
				
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + deviceName+ " enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + deviceName+ " disabled in gallery");
				}
			}
			
		}
		
		
		
		/****************************************************************************************************************
		 * Function Name: ChangeCableLength
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Alpesh Dhakad - 30/07/2019 & 23/08/2019,12/06/2020 - Updated test scripts as per new build and xpaths
		 * Alpesh Dhakad - 07/01/2021 Added click on built in loop A node click event (twice)
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void ChangeCableLength(String sLoopType,int fCableLength1,int fCableLength2)
		{
			float fMaxACUnits;
			Common_Functions.clickOnPointsTab();
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view cable length;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("{LControlKey down}{Akey}{LControlKey up}Length" +"{ENTER}" );
			
			repo.FormMe.cell_CableLength.Click();
			
			if(sLoopType.Equals("PFI"))
			{
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+fCableLength1 + "{Enter}");
				//Common_Functions.clickOnPointsTab();
				
				// Click on Panel node
				Common_Functions.ClickOnNavigationTreeItem("Node");
				
				
				Delay.Duration(1000, false);
				
				// Click on Loop A node
				Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-B");
				
				
				Delay.Duration(1000, false);
				
				repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view cable length;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("{LControlKey down}{Akey}{LControlKey up}Length" +"{ENTER}" );
			
			repo.FormMe.cell_CableLength.Click();
				
			
				//repo.ProfileConsys1.cell_CableLength.Click();
				
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+fCableLength2 + "{Enter}");
				Delay.Duration(500, false);
				fMaxACUnits = (450-(fCableLength1+fCableLength2)/10);
			}
			else
			{
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+fCableLength1 + "{Enter}");
				fMaxACUnits = (450-(fCableLength1)/10);
			}
			Report.Log(ReportLevel.Success,"Cable length changed successfully");
		}
		
		
		/**********************************************************************************************************************
		 * Function Name: calculatePercentage
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :  Alpesh Dhakad - 27/01/2021 - Updated percentage i.e. 100% for Yellow color as per MX Designer Update
		 **********************************************************************************************************************/
		[UserCodeMethod]
		public static string calculatePercentage(float min,float max)
		{
			string expectedColorCode;
			float percentage =(min/max)*100;
			if(percentage!=0 && percentage<95)
			{
				expectedColorCode="GREEN";
			}
			else if(percentage>=95 && percentage<=100)
			{
				expectedColorCode="YELLOW";
			}
			else if(percentage>100)
			{
				expectedColorCode="PINK";
			}
			else
			{
				expectedColorCode="WHITE";
			}
			
			return expectedColorCode;
		}
		
		/********************************************************************
		 * Function Name: VerifyPercentage
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyPercentage(string expectedColorCode,string actualColour)
		{
			switch (expectedColorCode)
			{
				case "GREEN":
					if(actualColour.Equals("#FF90EE90"))
					{
						Report.Log(ReportLevel.Success,"Colour displayed is LightGreen and Units are less than 95% ");
					}
					else
					{
						Report.Log(ReportLevel.Failure,"Progressbar colour is not displayed as LightGreen" + " Colour code is: "+actualColour);
					}
					break;
					
				case "YELLOW":
					if(actualColour.Equals("#FFFFFF00"))
					{
						Report.Log(ReportLevel.Success,"Colour displayed is Yellow and Units are greater than and equal to 95% ");
					}
					else
					{
						Report.Log(ReportLevel.Failure,"Progressbar colour is not displayed as yellow" + " Colour code is: "+actualColour);
					}
					break;
				case "PINK":
					if(actualColour.Equals("#FFFFC0CB"))
					{
						Report.Log(ReportLevel.Success,"Colour displayed is Pink and Units are greater than and equal to 100% ");
					}
					else
					{
						Report.Log(ReportLevel.Failure,"Progressbar colour is not displayed as Pink" + " Colour code is: "+actualColour);
					}
					break;
				case "WHITE":
					if(actualColour.Equals("#FFFFFFFF"))
					{
						Report.Log(ReportLevel.Success,"Colour displayed is white and Units are 0");
					}
					else
					{
						Report.Log(ReportLevel.Failure,"Progressbar colour is not displayed as white" + " Colour code is: "+actualColour);
					}
					break;
					
			}
			
		}
		
		
		
		/****************************************************************************************************************
		 * Function Name: AssignDeviceBase
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Alpesh Dhakad - 09/09/2019 - Updated Base selection and added xpath for the same
		 * Alpesh DHakad - 14/05/2020 Updated xpath as per new build
		 * Alpesh Dhakad - 16/06/2020 Updated script as per new method to add base
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void AssignDeviceBase(string DeviceLabel, string sBaseofDevice, string sBasePropertyRowIndex)
		{
			int iRowIndex;
			string sExistingBase;
			sBase = sBaseofDevice;
			sRowIndex = sBasePropertyRowIndex;
			sLabelName = DeviceLabel;
			//repo.ProfileConsys1.PanelInvetoryGrid.LabelofDevice.Click();
			//repo.ProfileConsys1.BaseofDeviceRow.Click();
			//repo.ProfileConsys1.BaseofDeviceRow.PressKeys("{Right}");
			
			if(repo.FormMe.txt_LabelNameForOneRowInfo.Exists())
			{
				repo.FormMe.txt_LabelNameForOneRow.Click();
			}
			else
			{
			repo.FormMe.txt_LabelName1.Click();
			}
			repo.FormMe.BaseofDeviceRow.Click();
			repo.FormMe.BaseofDeviceRow.PressKeys("{Right}");
			
			int.TryParse(sRowIndex, out iRowIndex);
			iRowIndex = iRowIndex+1;
			sRowIndex = iRowIndex.ToString();
			//repo.ProfileConsys1.Cell_BaseofDevice.Click();
			repo.FormMe.Cell_BaseofDevice.Click();
			
			//sExistingBase = repo.ProfileConsys1.SomeText.TextValue;
			sExistingBase = repo.FormMe.txt_cellBaseOfDevice.TextValue;
			//sExistingBase = sExistingBase.Replace(@"\""",string.Empty);
			if(!sExistingBase.Equals(sBase))
			{
				repo.FormMe.BaseofDeviceRow.MoveTo("560;19");
				repo.FormMe.BaseofDeviceRow.Click("560;19");
				int.TryParse(sRowIndex, out iRowIndex);
				iRowIndex = iRowIndex-1;
				sRowIndex = iRowIndex.ToString();
				repo.FormMe.BaseofDeviceRow.MoveTo("560;19");
				repo.FormMe.BaseofDeviceRow.Click("560;19");
				
				Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfOnly;
				
				repo.ContextMenu.btn_BaseSelection.Click();
				
				Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfImprovedOnly;
				
				Report.Log(ReportLevel.Info, "Base change was performed successfully.");

			}
		}

		/******************************************************************************************************
		 * Function Name: AssignAdditionalBase
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Alpesh Dhakad - 22/05/2020 Updated script as per new implementation changes
		 * Alpesh Dhakad - 18/06/2020 Updated script as per new method to add base
		 ******************************************************************************************************/
		[UserCodeMethod]
		public static void AssignAdditionalBase(string DeviceLabel, string sBaseofDevice, string sBasePropertyRowIndex)
		{
			sLabelName = DeviceLabel;
			Common_Functions.clickOnPointsTab();
			//repo.ProfileConsys1.PanelInvetoryGrid.LabelofDevice.Click();
			if(repo.FormMe.txt_LabelNameForOneRowInfo.Exists())
			{
				repo.FormMe.txt_LabelNameForOneRow.Click();
			}
			else
			{
			repo.FormMe.txt_LabelName1.Click();
			}
			
			sBase = sBaseofDevice;
			sRowIndex = sBasePropertyRowIndex;
			//repo.ProfileConsys1.BaseofDeviceRow.MoveTo("760;19");
			//repo.ProfileConsys1.BaseofDeviceRow.Click("760;19");
			repo.FormMe.BaseofDeviceRow.MoveTo("560;19");
			repo.FormMe.BaseofDeviceRow.Click("560;19");
			
			
			Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfOnly;
				
				repo.ContextMenu.btn_BaseSelection.Click();
				
				Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfImprovedOnly;
				
				Report.Log(ReportLevel.Info, "Base change was performed successfully.");

		}
		
		/*****************************************************************************************************
		 * Function Name: RemoveBase
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :Alpesh Dhakad - 18/05/2020 Updated script and xpath as per new implementation changes
		 *****************************************************************************************************/
		[UserCodeMethod]
		public static void RemoveBase(string DeviceLabel, string sBasePropertyRowIndex)
		{
			int iRowIndex;
			sLabelName = DeviceLabel;
			Common_Functions.clickOnPointsTab();
			//repo.ProfileConsys1.PanelInvetoryGrid.LabelofDevice.Click();
			
			if(repo.FormMe.txt_LabelNameForOneRowInfo.Exists())
			{
				repo.FormMe.txt_LabelNameForOneRow.Click();
			}
			else{
				repo.FormMe.txt_LabelName1.Click();
			}
			
			
			sRowIndex = sBasePropertyRowIndex;
			//repo.ProfileConsys1.BaseofDeviceRow.Click();
			//repo.ProfileConsys1.BaseofDeviceRow.PressKeys("{Right}");
			
			repo.FormMe.BaseofDeviceRow.Click();
			repo.FormMe.BaseofDeviceRow.PressKeys("{Right}");
			
			
			int.TryParse(sRowIndex, out iRowIndex);
			iRowIndex = iRowIndex+1;
			sRowIndex = iRowIndex.ToString();
			//repo.ProfileConsys1.BaseofDeviceRow.MoveTo("760;19",560'19);
			//repo.ProfileConsys1.BaseofDeviceRow.Click("760;19");
			repo.FormMe.BaseofDeviceRow.MoveTo("558;18");
			repo.FormMe.BaseofDeviceRow.Click("558;18");
			
			Report.Log(ReportLevel.Info, "Base removed was performed successfully.");
		}

		/*****************************************************************************************************************
		 * Function Name: changeAndVerifyNumberOfAlarmLED
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Alpesh Dhakad - 29/07/2019 - Updated script as per new build xpaths
		 * Alpesh Dhakad - 16/08/2019 - Updated with new navigation tree method, xpath and devices gallery
		 *******************************************************************************************************************/
		[UserCodeMethod]
		public static void changeAndVerifyNumberOfAlarmLED(int LEDNumber, string rangeState, int expectedResult)
		{
			
			int Value,actualValue,revertTo;
			string sActualValue;
			
			// Click on Site node
			Common_Functions.ClickOnNavigationTreeItem("Site");
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			
			
			Delay.Duration(500);
			// repo.ProfileConsys1.NavigationTree.Node1Pro32xD.Click();
			
			repo.FormMe.cell_NumberOfAlarmLeds.Click();
			
			
			if((rangeState.Equals("Valid")))
			{
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+LEDNumber +"{ENTER}");
				
				//Ranorex.Keyboard.Press(System.Windows.Forms.Keys.Return);
				
				repo.FormMe.cell_NumberOfAlarmLeds.Click();
				sActualValue = repo.FormMe.txt_NumberOfAlarmLeds.TextValue;
				int.TryParse(sActualValue, out Value);
				if(Value==LEDNumber)
				{
					Report.Log(ReportLevel.Success,"Number of Alarm LEDs is changed to: "+LEDNumber);
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Number of Alarm LEDs is not changed to: "+LEDNumber);
				}
			}
			else if((rangeState.Equals("InvalidRange")))
			{
				string initialValue = repo.FormMe.txt_NumberOfAlarmLeds.TextValue;
				int.TryParse(initialValue,out revertTo);
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+LEDNumber +"{ENTER}");
				repo.FormMe.cell_NumberOfAlarmLeds.Click();
				string revertedValue = repo.FormMe.txt_NumberOfAlarmLeds.TextValue;
				int.TryParse(revertedValue, out actualValue);
				if(actualValue==revertTo)
				{
					Report.Log(ReportLevel.Success,"Number of Alarm LEDs is reverted to: "+revertTo);
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Number of Alarm LEDs is not reverted to: "+revertTo);
				}
			}
			else
			{
				
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+LEDNumber +"{ENTER}");
				repo.FormMe.cell_NumberOfAlarmLeds.Click();
				string revertedValue = repo.FormMe.txt_NumberOfAlarmLeds.TextValue;
				int.TryParse(revertedValue,out actualValue);
				if(actualValue==expectedResult)
				{
					Report.Log(ReportLevel.Success,"Number of Alarm LEDs is reverted to: "+expectedResult);
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Number of Alarm LEDs is not reverted to: "+expectedResult);
				}
				
			}
			
		}
		
		/********************************************************************
		 * Function Name: verifyMinMaxThroughSpinControl
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyMinMaxThroughSpinControl(string minLimit,string maxLimit)
		{
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+ maxLimit +"{ENTER}");
			repo.FormMe.cell_NumberOfAlarmLeds.Click();
			repo.FormMe.btn_NumberOfAlarmLedsSpinUpButton.Click();
			string actualValue = repo.FormMe.txt_NumberOfAlarmLeds.TextValue;
			if(actualValue.Equals(maxLimit))
			{
				Report.Log(ReportLevel.Success,"Spin control accepts values within specified max limit");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Spin control doesnot accepts values within specified max limit");
			}
			Keyboard.Press("{ENTER}");
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+ minLimit +"{ENTER}");
			repo.FormMe.cell_NumberOfAlarmLeds.Click();
			repo.FormMe.btn_NumberOfAlarmLedsSpinDownButton.Click();
			actualValue = repo.FormMe.txt_NumberOfAlarmLeds.TextValue;
			if(actualValue.Equals(minLimit))
			{
				Report.Log(ReportLevel.Success,"Spin control accepts values within specified min limit");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Spin control does not accepts values within specified min limit");
			}
		}
		
		
		/*********************************************************************************************
		 * Function Name: getProgressBarColor
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Alpesh Dhakad - 11/07/2019 - Added step to click on Physical Layout tab
		 *******************************************************************************************/
		[UserCodeMethod]
		public static string getProgressBarColor(string LoadingType)
		{
			Common_Functions.clickOnPhysicalLayoutTab();
			string actualColour;
			switch (LoadingType)
			{
				case "Signal (AC Units)":
					sRowIndex = "1";
					break;
				case "Current (DC Units)":
					sRowIndex = "2";
					break;
				case "Current (worst case)":
					sRowIndex = "3";
					break;
				default:
					Console.WriteLine("Specified loading type doesn't exist");
					break;
			}
			
			return actualColour = repo.ProfileConsys1.DCUnitProgressBar.GetAttributeValue<string>("foreground");
			
		}
		
		
		/********************************************************************
		 * Function Name: DeleteAllDevices
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void DeleteAllDevices()
		{
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
			Common_Functions.clickOnDeleteButton();
		}
		
		
		/**************************************************************************************************************
		 * Function Name: VerifyDCCalculationforPFI
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Alpesh Dhakad - 01/08/2019 & 30/08/2019- Updated test scripts as per new build and xpaths
		 ***************************************************************************************************************/
		[UserCodeMethod]
		public void VerifyDCCalculationforPFI(string sFileName, string sAddDevicesLoopA, string sAddDevicesLoopB,string sPanelLED, string sDeleteDevicesLoopA, string sDeleteDevicesLoopB)
		{
			//Add devies in loop A
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesLoopA);
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			string expectedDCUnits, sType, LabelName;
			for(int i=7; i<=rows; i++)
			{
				ModelNumber =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				sBase = ((Range)Excel_Utilities.ExcelRange.Cells[i,9]).Value.ToString();
				sRowIndex= ((Range)Excel_Utilities.ExcelRange.Cells[i,10]).Value.ToString();
				//sDeviceVolume = ((Range)Excel_Utilities.ExcelRange.Cells[i,8]).Value.ToString();
				//sFlashRate = ((Range)Excel_Utilities.ExcelRange.Cells[i,9]).Value.ToString();
				
				AddDevicesfromGallery(ModelNumber,sType);
				if(sBase!=null && sBase !="NA")
				{
					AssignDeviceBase(sLabelName,sBase,sRowIndex);
				}
				
				// Click on Loop A node
				Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
				
				Delay.Milliseconds(500);
			}
			
			//Verify DC Units of Loop A
			Report.Log(ReportLevel.Info,"Verification of DC Units of Loop A on addition of devices in Loop A");
			expectedDCUnits= ((Range)Excel_Utilities.ExcelRange.Cells[2,2]).Value.ToString();
			verifyDCUnitsValue(expectedDCUnits);
			
			//Verify DC Units of Loop B
			Report.Log(ReportLevel.Info,"Verification of DC Units of Loop B on addition of devices in Loop A");
			// Click on Loop B node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-B");
			
			expectedDCUnits= ((Range)Excel_Utilities.ExcelRange.Cells[3,2]).Value.ToString();
			verifyDCUnitsValue(expectedDCUnits);
			
			Excel_Utilities.CloseExcel();
			
			//Add devices in loop B
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesLoopB);
			rows= Excel_Utilities.ExcelRange.Rows.Count;
			repo.FormMe.Loop_B1.Click();
			
			for(int i=7; i<=rows; i++)
			{
				ModelNumber =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				sBase = ((Range)Excel_Utilities.ExcelRange.Cells[i,9]).Value.ToString();
				sRowIndex= ((Range)Excel_Utilities.ExcelRange.Cells[i,10]).Value.ToString();
				//sDeviceVolume = ((Range)Excel_Utilities.ExcelRange.Cells[i,8]).Value.ToString();
				//sFlashRate = ((Range)Excel_Utilities.ExcelRange.Cells[i,9]).Value.ToString();
				
				AddDevicesfromGallery(ModelNumber,sType);
				if(sBase!=null && sBase !="NA")
				{
					AssignDeviceBase(sLabelName,sBase,sRowIndex);
				}
				
				// Click on Loop B node
				Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-B");
				
				Delay.Milliseconds(500);
			}
			
			//Verify DC Units of Loop B
			Report.Log(ReportLevel.Info,"Verification of DC Units of Loop A on addition of devices in Loop B");
			expectedDCUnits= ((Range)Excel_Utilities.ExcelRange.Cells[2,2]).Value.ToString();
			verifyDCUnitsValue(expectedDCUnits);
			
			//Verify DC Units of Loop A
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			Report.Log(ReportLevel.Info,"Verification of DC Units of Loop B on addition of devices in Loop B");
			expectedDCUnits= ((Range)Excel_Utilities.ExcelRange.Cells[3,2]).Value.ToString();
			verifyDCUnitsValue(expectedDCUnits);
			
			Excel_Utilities.CloseExcel();
			Report.Log(ReportLevel.Info,"Verification of DC Units of on changing Panel LED");
			verifyPanelLEDEffectOnDC(sFileName,sPanelLED);
			
			Excel_Utilities.CloseExcel();
			
			//Delete Devices from loop A
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			Common_Functions.clickOnPointsTab();
			
			Excel_Utilities.OpenExcelFile(sFileName,sDeleteDevicesLoopA);
			rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			for(int i=3;i<=rows;i++)
			{
				LabelName =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				DeleteDeviceUsingLabel(LabelName);
			}
			
			//Verify DC Units of Loop A
			Report.Log(ReportLevel.Info,"Verification of DC Units of Loop A on deletion of devices from Loop A");
			expectedDCUnits= ((Range)Excel_Utilities.ExcelRange.Cells[1,2]).Value.ToString();
			verifyDCUnitsValue(expectedDCUnits);
			
			//Verify DC Units of Loop B
			Report.Log(ReportLevel.Info,"Verification of DC Units of Loop B on deletion of devices from Loop A");
			// Click on Loop B node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-B");
			
			verifyDCUnitsValue(expectedDCUnits);
			
			Excel_Utilities.CloseExcel();
			
			//Delete Devices from loop B
			// Click on Loop B node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-B");
			
			Common_Functions.clickOnPointsTab();
			
			Excel_Utilities.OpenExcelFile(sFileName,sDeleteDevicesLoopB);
			rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			for(int i=3;i<=rows;i++)
			{
				LabelName =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				DeleteDeviceUsingLabel(LabelName);
			}
			
			//Verify DC Units of Loop B
			Report.Log(ReportLevel.Info,"Verification of DC Units of Loop A on deletion of devices from Loop B");
			expectedDCUnits= ((Range)Excel_Utilities.ExcelRange.Cells[1,2]).Value.ToString();
			verifyDCUnitsValue(expectedDCUnits);
			
			//Verify DC Units of Loop A
			Report.Log(ReportLevel.Info,"Verification of DC Units of Loop B on deletion of devices from Loop B");
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			verifyDCUnitsValue(expectedDCUnits);
		}

		/********************************************************************
		 * Function Name: DeleteDeviceUsingLabel
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void DeleteDeviceUsingLabel(string LabelName)
		{
			sLabelName = LabelName;
			
			SelectRowUsingLabelName(sLabelName);
			
			if(repo.FormMe.txt_LabelName1Info.Exists())
			{
				if(repo.FormMe.btn_Delete.Visible){
					Common_Functions.clickOnDeleteButton();
					
					if(repo.FormDeleteSpur.btn_Ok_WarningInfo.Exists())
					{
						repo.FormDeleteSpur.btn_Ok_Warning.Click();
						Report.Log(ReportLevel.Info, "Delete device warning displayed");
					}
				}
				else{
					repo.FormMe.btn_DeleteFC.Click();
					
					if(repo.FormDeleteSpur.btn_Ok_WarningInfo.Exists())
					{
						repo.FormDeleteSpur.btn_Ok_Warning.Click();
						Report.Log(ReportLevel.Info, "Delete device warning displayed");
					}
				}
				//Validate.AttributeEqual(repo.FormMe.txt_LabelName1Info, "Text", sLabelName);
				Report.Log(ReportLevel.Success, "Device "+sLabelName+" deleted successfully");
			}
			
			else
			{
				
				Report.Log(ReportLevel.Failure, "Device "+sLabelName+" not found");
			}
		}
		
		/********************************************************************
		 * Function Name: VerifyDeviceSensitivity
		 * Function Details: To verify device sensitivity value
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To verify device sensitivity value as per the argument
		[UserCodeMethod]
		public static void VerifyDeviceSensitivity(string sDeviceSensitivity)
		{
			// Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}");
			
			// Click on Device Sensitivity cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceSensitivity.Click();
			
			// Get the text value of Device Sensitivity field
			string DeviceSensitivity = repo.ProfileConsys1.DeviceSensitivity.TextValue;
			
			//Comparing expected and actual Device Sensitivity value
			if(DeviceSensitivity.Equals(sDeviceSensitivity))
			{
				Report.Log(ReportLevel.Success,"Device Sensitivity " +DeviceSensitivity + " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device Sensitivity " +DeviceSensitivity+ " is not displayed correctly");
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			
		}
		
		/********************************************************************
		 * Function Name: ChangeDeviceSensitivity
		 * Function Details: To change device sensitivity
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To change device sensitivity value as per the argument
		[UserCodeMethod]
		public static void ChangeDeviceSensitivity(string changeDeviceSensitivity)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}" );
			
			// Click on Device Sensitivity cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceSensitivity.Click();
			
			// Enter the value to change device sensitivity
			repo.ProfileConsys1.PARTItemsPresenter.txt_changeDeviceSensitivity.PressKeys((changeDeviceSensitivity) +"{ENTER}" + "{ENTER}");
			
			// Click on Device Sensitivity cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceSensitivity.Click();
			
			// Get the text value of changed Device Sensitivity field
			string DeviceSensitivity = repo.ProfileConsys1.PARTItemsPresenter.txt_changeDeviceSensitivity.TextValue;
			
			//Comparing expected and actual changed Device Sensitivity value
			if(DeviceSensitivity.Equals(changeDeviceSensitivity))
			{
				Report.Log(ReportLevel.Success,"Device Sensitivity changed successfully to " +DeviceSensitivity + " and is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device Sensitivity is not changed to " +changeDeviceSensitivity + "and displayed incorrectly");
			}
			
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
		}
		
		/********************************************************************
		 * Function Name: VerifyDeviceMode
		 * Function Details: To verify device mode
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To verify device mode value as per the argument
		[UserCodeMethod]
		public static void VerifyDeviceMode(string sDeviceMode)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}" );
			
			// Click on Device Mode cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			// Get the text value of changed Device Mode field
			string DeviceMode = repo.ProfileConsys1.DeviceMode.TextValue;
			
			//Comparing expected and actual changed Device Mode value
			if(DeviceMode.Equals(sDeviceMode))
			{
				Report.Log(ReportLevel.Success,"Device mode " +DeviceMode+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device mode is not displayed correctly");
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
		}
		
		/********************************************************************
		 * Function Name: ChangeDeviceMode
		 * Function Details: To change device mode
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To change and verify device mode value as per the argument
		[UserCodeMethod]
		public static void ChangeDeviceMode(string changeDeviceMode)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}" );
			
			// Click on Device Mode cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			// Enter the value to change device mode
			repo.ProfileConsys1.PARTItemsPresenter.txt_changeDeviceMode.PressKeys((changeDeviceMode) +"{ENTER}" + "{ENTER}");
			
			// Click on Device Mode cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			// Get the text value of changed Device Mode field
			string DeviceMode = repo.ProfileConsys1.PARTItemsPresenter.txt_changeDeviceMode.TextValue;
			
			//Comparing expected and actual changed Device Mode value
			if(DeviceMode.Equals(changeDeviceMode))
			{
				Report.Log(ReportLevel.Success,"Device mode changed successfully to " +DeviceMode+ " and is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device mode is not changed to " +changeDeviceMode+ " and displayed incorrectly");
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
		}
		
		
		/********************************************************************
		 * Function Name: CheckUncheckDayMatchesNight
		 * Function Details: To check and uncheck day matches night checkbox
		 * Parameter/Arguments: boolean value
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To verify check box state of Day matches night field
		[UserCodeMethod]
		public static void CheckUncheckDayMatchesNight(bool ExpectedState)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Day Matches Night" +"{ENTER}" );

			// CLick on checkbox cell lower left corner
			repo.ProfileConsys1.PARTItemsPresenter.cell_DayMatchesNight.Click(Location.LowerLeft);
			// repo.ProfileConsys1.PARTItemsPresenter.chkbox_DayMatchesNight.EnsureVisible();
			
			// To retrieve the attribute value as boolean by its ischecked properties and store in actual state
			bool actualState =  repo.ProfileConsys1.PARTItemsPresenter.chkbox_DayMatchesNight.GetAttributeValue<bool>("ischecked");
			
			//As per actual state and expected state values verfiying day mode and day sensitivity field state and action performed on checkbox
			if(actualState)
			{
				if(ExpectedState)
				{
					// Verify Day mode field state
					VerifyDayModeField(ExpectedState);
					
					// Verify Day Sensitivity field state
					VerifyDaySensitivityField(ExpectedState);
				}
				else
				{
					// Click on Day Matches night checkbox
					repo.ProfileConsys1.PARTItemsPresenter.chkbox_DayMatchesNight.Click();
					
					// Verify Day mode field state
					VerifyDayModeField(ExpectedState);
					
					// Verify Day Sensitivity field state
					VerifyDaySensitivityField(ExpectedState);
				}
			}
			
			else
			{
				if(ExpectedState)
				{
					// Click on Day Matches night checkbox
					repo.ProfileConsys1.PARTItemsPresenter.chkbox_DayMatchesNight.Click();
					
					// Verify Day mode field state as disabled state
					VerifyDayModeField(ExpectedState);
					
					// Verify Day Sensitivity field state
					VerifyDaySensitivityField(ExpectedState);
				}
				else
				{
					// Verify Day mode field state as enabled state
					VerifyDayModeField(ExpectedState);
					
					// Verify Day Sensitivity field state
					VerifyDaySensitivityField(ExpectedState);
				}
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		
		/********************************************************************
		 * Function Name: VerifyDayModeField
		 * Function Details: To verify day mode field
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To verify day mode value field as per the argument
		[UserCodeMethod]
		public static void VerifyDayModeField(bool ExpectedDayModeState)
		{
			// To retrieve the attribute value as boolean by its "isreadonly" properties and store in verifyReadOnly
			bool verifyReadOnly = repo.ProfileConsys1.PARTItemsPresenter.row_DayModeField.GetAttributeValue<bool>("isreadonly");
			
			// Comparing verifyReadOnly and ExpectedDayModeState values
			if(verifyReadOnly.Equals(ExpectedDayModeState))
			{
				Report.Log(ReportLevel.Success,"Day mode field is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Day mode field is displayed incorrectly");
			}
		}
		
		/********************************************************************
		 * Function Name: VerifyDaySensitivityField
		 * Function Details: To verify day sensitivity field
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To verify day sensitivity value field as per the argument
		[UserCodeMethod]
		public static void VerifyDaySensitivityField(bool ExpectedDaySenstivityState)
		{
			// To retrieve the attribute value as boolean by its "isreadonly" properties and store in verifyReadOnly
			bool verifyReadOnly = repo.ProfileConsys1.PARTItemsPresenter.row_DaySensitivityField.GetAttributeValue<bool>("isreadonly");
			
			// Comparing verifyReadOnly and ExpectedDayModeState values
			if(verifyReadOnly.Equals(ExpectedDaySenstivityState))
			{
				Report.Log(ReportLevel.Success,"Day Sensitivity field is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Day Sensitivity field is displayed incorrectly");
			}
		}
		
		/********************************************************************
		 * Function Name: VerifyDayMode
		 * Function Details: To verify day mode
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To verify day mode value field as per the argument
		[UserCodeMethod]
		public static void VerifyDayMode(string sDayMode)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Day Matches Night" +"{ENTER}" );
			
			// Click on Day mode cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DayMode.Click();
			
			// Retrieve value of Day mode and store in DayMode
			string DayMode = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMode.Text;
			
			// Comparing DayMode and sDayMode values
			if(DayMode.Equals(sDayMode))
			{
				Report.Log(ReportLevel.Success,"Day mode " +DayMode+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Day mode is not displayed correctly");
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}

		
		
		/********************************************************************
		 * Function Name: ChangeDayMode
		 * Function Details: To change day mode
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		//  Purpose : To change and verify day mode value field as per the argument
		public static void ChangeDayMode(string changeDayMode)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Day Matches Night" +"{ENTER}" );
			
			// Click on Day mode cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DayMode.Click();
			
			// Enter the changeDayMode value and click Enter twice
			repo.ProfileConsys1.PARTItemsPresenter.txt_DayMode.PressKeys((changeDayMode) +"{ENTER}" + "{ENTER}");
			
			// Click on Day mode cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DayMode.Click();
			
			//Retrieve value of changed Day mode text and store in DayMode
			string DayMode = repo.ProfileConsys1.PARTItemsPresenter.txt_changeDayMode.TextValue;
			
			// Comparing DayMode and changeDayMode values
			if(DayMode.Equals(changeDayMode))
			{
				Report.Log(ReportLevel.Success,"Day mode changed successfully to " +DayMode+ " and is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Day mode is not changed to " +changeDayMode+ " and displayed incorrectly");
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name: VerifyDaySensitivity
		 * Function Details: To Verify day sensitivity
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To verify day sensitivity value field as per the argument
		[UserCodeMethod]
		public static void VerifyDaySensitivity(string sDaySensitivity)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Day Matches Night" +"{ENTER}" );
			
			// Click on Day Sensitivity cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DaySensitivity.Click();
			
			//Retrieve value of Day Sensitivity text and store in DaySensitivity
			string DaySensitivity = repo.ProfileConsys1.PARTItemsPresenter.txt_DaySensitivity.Text;
			
			// Comparing DaySensitivity and sDaySensitivity values
			if(DaySensitivity.Equals(sDaySensitivity))
			{
				Report.Log(ReportLevel.Success,"Day Sensitivity " +DaySensitivity+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Day Sensitivity is not displayed correctly");
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name: ChangeDaySensitivity
		 * Function Details: To change day sensitivity
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		// To change and verify day sensitivity value field as per the argument
		[UserCodeMethod]
		public static void ChangeDaySensitivity(string changeDaySensitivity)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Day Matches Night" +"{ENTER}" );
			
			// Click on Day Sensitivity cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DaySensitivity.Click();
			
			// Enter the changeDaySensitivity value and click Enter twice
			repo.ProfileConsys1.PARTItemsPresenter.txt_DaySensitivity.PressKeys((changeDaySensitivity) +"{ENTER}" + "{ENTER}");
			
			// Click on Day Sensitivity cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DaySensitivity.Click();
			
			//Retrieve value of changed Day Sensitivity text and store in DaySensitivity
			string DaySensitivity = repo.ProfileConsys1.PARTItemsPresenter.txt_changeDaySensitivity.TextValue;
			
			// Comparing DaySensitivity and changeDaySensitivity values
			if(DaySensitivity.Equals(changeDaySensitivity))
			{
				Report.Log(ReportLevel.Success,"Day Sensitivity changed successfully to " +DaySensitivity+ " and is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Day Sensitivity is not changed to " +changeDaySensitivity+ " and displayed incorrectly");
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/*************************************************************************************************************
		 *                Below functions are mapped to respective code libraries as per functionality
		 * ***********************************************************************************************************
		 *                                     NOTE : DO NOT REMOVE IT FROM HERE
		 * ************************************************************************************************************/
		
		public static void VerifyACCalculation(string sFileName,string sAddDevicesSheet, string sDeleteDevicesSheet)
		{
			AC_Functions.VerifyACCalculation(sFileName,sAddDevicesSheet,sDeleteDevicesSheet);
		}
		
		
		public static void VerifyACCalculationforFIM(string sFileName,string sAddDevicesSheet, string sDeleteDevicesSheet)
		{
			AC_Functions.VerifyACCalculationforFIM(sFileName,sAddDevicesSheet,sDeleteDevicesSheet);
			
		}
		
		public static void verifyMaxACUnitsValue(string expectedMaxACUnits)
		{
			AC_Functions.verifyMaxACUnitsValue(expectedMaxACUnits);
			
		}
		
		
		public static void verifyACUnitsValue(string expectedACUnits)
		{
			AC_Functions.verifyACUnitsValue(expectedACUnits);
		}
		
		public static void verifyMaxDCUnits(string expectedMaxDCUnits)
		{
			DC_Functions.verifyMaxDCUnits(expectedMaxDCUnits);
			
		}
		
		
		public static void verifyDCUnitsValue(string expectedDCUnits)
		{
			DC_Functions.verifyDCUnitsValue(expectedDCUnits);
		}
		
		
		public static void VerifyDCUnitsIndicators(string sFileName,string sAddDevicesSheet)
		{
			DC_Functions.VerifyDCUnitsIndicators(sFileName,sAddDevicesSheet);
		}
		
		
		public static void verifyPanelLEDEffectOnDC(string sFileName,string sPanelLED)
		{
			DC_Functions.verifyPanelLEDEffectOnDC(sFileName,sPanelLED);
		}
		
		
		public static void changeDeviceSensitivityAndVerifyDCUnit(string sFileName,string sAddDevicesSheet)
		{
			DC_Functions.changeDeviceSensitivityAndVerifyDCUnit(sFileName,sAddDevicesSheet);
		}
		
		
		public static void VerifyDCUnitsAndWorstCaseIndicators(string sFileName,string sAddDevicesSheet)
		{
			DC_Functions.VerifyDCUnitsAndWorstCaseIndicators(sFileName,sAddDevicesSheet);
		}
		
		
		// To verify voltage drop value on adding and removing devices
		public static void verifyVoltageDropOnAddingAndRemovingDevices(string sFileName,string sAddDevicesLoopA, string sDeleteDevicesLoopA)
		{
			VoltageDrop_Functions.verifyVoltageDropOnAddingAndRemovingDevices(sFileName,sAddDevicesLoopA,sDeleteDevicesLoopA);
		}
		
		// Verify max volt Drop value
		public static void verifyMaxVoltDrop(string expectedVoltDropMaxValue)
		{
			VoltageDrop_Functions.verifyMaxVoltDrop(expectedVoltDropMaxValue);
		}
		
		// Verify volt Drop value
		public static void verifyVoltDropValue(string expectedVoltDropValue)
		{
			VoltageDrop_Functions.verifyVoltDropValue(expectedVoltDropValue);
		}
		
		// Verify max volt Drop worst case value
		public static void verifyMaxVoltDropWorstCaseValue(string expectedVoltDropWorstCaseMaxValue)
		{
			VoltageDrop_Functions.verifyMaxVoltDropWorstCaseValue(expectedVoltDropWorstCaseMaxValue);
		}
		
		// Verify volt Drop worst case value
		public static void verifyVoltDropWorstCaseValue(string expectedVoltDropWorstCaseValue)
		{
			VoltageDrop_Functions.verifyVoltDropWorstCaseValue(expectedVoltDropWorstCaseValue);
		}
		
		// Verify Voltage Drop Calculation on Adding devices in loops
		public static void verifyVoltageDropCalculation(string sFileName,string sAddDevicesLoop)
		{
			VoltageDrop_Functions.verifyVoltageDropCalculation(sFileName,sAddDevicesLoop);
		}
		
		// Verify Voltage Drop percentage
		public static void verifyVoltageDropPercentage(string sFileName, string noLoadVoltDrop)
		{
			VoltageDrop_Functions.verifyVoltageDropPercentage(sFileName,noLoadVoltDrop);
		}
		
		

		/*************************************************************************************************************
		 *                Above functions are mapped to respective code libraries as per functionality
		 * ***********************************************************************************************************
		 *                                     NOTE : DO NOT REMOVE IT FROM HERE
		 * ************************************************************************************************************/
		

		
		/****************************************************************************************************************************************
		 * Function Name: AddMultipleDevices
		 * Function Details: To add multiple devices
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 29/03/2019 Alpesh Dhakad- Updated btn_MultiplePointWizard xpath and change script accordingly
		 * Alpesh Dhakad - 08/08/2019 - Updated script for model nuber text for multiple point wizard
		 ****************************************************************************************************************************************/
		[UserCodeMethod]
		public static void AddMultipleDevices(string sFileName, string sSheetName)
		{
			
			Common_Functions.clickOnPointsTab();
			Excel_Utilities.OpenExcelFile(sFileName,sSheetName);
			//Excel_Utilities.OpenSheet(sSheetName);
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			repo.FormMe.btn_MultiplePointWizard.Click();
			
			//repo.ProfileConsys1.btn_MultiplePointWizard_DoNotUse.Click();
			repo.AddDevices.txt_AllDevices.Click();
			
			string sDeviceName=  ((Range)Excel_Utilities.ExcelRange.Cells[8,1]).Value.ToString();
			int DeviceQty=  int.Parse(((Range)Excel_Utilities.ExcelRange.Cells[8,2]).Value.ToString());
			
			repo.AddDevices.txt_SearchDevices.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+sDeviceName);
			ModelNumber = sDeviceName;
			repo.AddDevices.txt_ModelNumberForMultiPointWizard.Click();
			repo.AddDevices.txt_Quantity.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+DeviceQty.ToString());
			
			
			repo.AddDevices.btn_AddDevices.Click();
			Report.Log(ReportLevel.Success,+DeviceQty+" \""+sDeviceName+ "\" Device Added successfully");
			Delay.Milliseconds(200);/*
			for(int i=1;i<=DeviceQty;i++)
			{
				string DeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[2,1]).Value.ToString();
				ModelNumber = DeviceName;
				sRow = (i).ToString();
				repo.ProfileConsys1.PanelInvetoryGrid.InventoryGridCell.Click();
				Validate.AttributeEqual(repo.ProfileConsys1.PanelInvetoryGrid.txt_DeviceNameInfo, "Text", DeviceName);
				Delay.Milliseconds(100);
				Report.Log(ReportLevel.Success,"Number "+i+" "+sDeviceName+ "Device verified in points grid successfully");
			}*/
			
			Excel_Utilities.ExcelWB.Close(false, null, null);
			//Excel_Utilities.ExcelAppl.Quit();
		}



		
//			[UserCodeMethod]
//			public static void GetList()
//			{
//
//				//Click on Points tab
//			Common_Functions.clickOnPointsTab();
//
//			// Click on SearchProperties text field
//			repo.ProfileConsys1.txt_SearchProperties.Click();
//
//			// Enter the Device text in Search Properties fields to view device related text
//			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}" );
//
//			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceSensitivity.Click();
//			repo.ProfileConsys1.PARTItemsPresenter.PARTItem.Click();
//			repo.ProfileConsys1.PARTItemsPresenter.PARTItem.Click();
//
//			IList<Ranorex.ListItem> dropDownListText = repo.ContextMenu.PARTContent.FindDescendants();
//
//			foreach (Ranorex.ListItem element in dropDownListText)
//			{
//				string s1 = dropDownListText.ElementAt(0);
//				int ab = dropDownListText.IndexOf("Low (60dB)");
//				Ranorex.ListItem s = repo.ContextMenu.PARTContent.Items;
//				Report.Log(ReportLevel.Success,s.ToString());
//			}
//			if (repo.ContextMenu.PARTContent.Items.Count > 0)
//			{
//				Report.Log(ReportLevel.Success,"Success ");
//			}
//			else
//			{
//				Report.Log(ReportLevel.Failure,"Failed");
//			}
//
		
//			7
		
//			//Click on Points tab
//			Common_Functions.clickOnPointsTab();
//
//			// Click on SearchProperties text field
//			repo.ProfileConsys1.txt_SearchProperties.Click();
//
//			// Enter the Device text in Search Properties fields to view device related text
//			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}" );
		//====================
//			// Click on Device Sensitivity cell
//			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceSensitivity.Click();
//			repo.ProfileConsys1.PARTItemsPresenter.PARTItem.Click();
//
//
//			repo.ProfileConsys1.PARTItemsPresenter.PARTItem.Click();
//
//			============================
		////			int count = repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.Element.Children.Count;
		////			for (int i=0; i<=count; i++)
//			{
//				string sensitivity = repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.Element.Children.IndexOf(i).ToString();
//				//string sensitivity = repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.Element.Children.IndexOf(i);
//			}
		
//
//			IList<ListItem> List = repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.FindChildren
//			foreach (ListItem Item in List)
//			{
//				string sensitivity = repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.Element.Children.(Item);
//			}
		//string expectedValue= "Low (60dB)";
		//Select(item => item.Text).
		//List<string> dropDownListText = repo.ContextMenu.PARTContent.Items;
//
//			//repo.ContextMenu.SomeListItem.Text();
//			try{
//				//string txt1 = repo.ContextMenu.PARTContent.Items;
//				Thread.Sleep(500);
//			IList<Ranorex.ListItem> dropDownListText = repo.ContextMenu.PARTContent.Items;
//
//			foreach (Ranorex.ListItem element in dropDownListText)
//			{
//				ListItem s = repo.ContextMenu.PARTContent.Items.ElementAt(0);
//				Report.Log(ReportLevel.Success,s.Text);
//
//			}
//
//			if (repo.ContextMenu.PARTContent.Items.Count > 0)
//			{
//				Report.Log(ReportLevel.Success,"Day Sensitivity changed successfully to ");
//			}
//			else
//			{
//				Report.Log(ReportLevel.Failure,"Day Sensitivity failed to ");
//			}
//			}
//			catch(Exception e){
//
//			}
//
		
//			if(dropDownListText.Where(item => item == expectedValue).Count() >0)
//			{
//				Report.Log(ReportLevel.Success,"Day Sensitivity changed successfully to ");
//			}
//			else
//			{
//				Report.Log(ReportLevel.Failure,"Day Sensitivity failed to ");
//			}
//			================================================
//			int count = repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.Element.Children.Count;
//			IList<ListItem> cmb = repo.ContextMenu.PARTContent.Items;
//
//			//string s = cmb.Text;
//			Report.Log(ReportLevel.Success, s);
//			for (int i=0; i<count; i++)
//			{
//			   foreach (Ranorex.Text txt in cmb.FindDescendants<Ranorex.Text>())
//				{
//						Report.Log(ReportLevel.Success, txt.TextValue);
//				}
//			}
		//}
		//===================================
//
//
		
		
		
//			foreach (ListItem listItem in repo.ContextMenu.PARTContent.Items)
//			{
//				dropDownListText.Add(listItem.Text);
//			}
//
		
//
//			//for (int i=0; i<=count; i++)
//			{
//				Ranorex.ComboBox cmb = repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceSensitivity.FindSingle(".//combobox", 60000);
//				cmb.Click();
//				IList<Ranorex.ListItem> Items = cmb.FindDescendants<Ranorex.ListItem>();
//
		//            	foreach (Ranorex.ListItem ListI in Items)
		//            	{
		//               	Report.Log(ReportLevel.Success, ListI.Text.ToString);
		//            	}
//
//
//			}

		
		
		//repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.
		

		//myCombobox.GetItemText(myCombobox.Items[index])
		

		//repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.Element.Children.IndexOf(ListItem i)
		
//			for (int i=0; i<=count; i++)
//			{
//				Ranorex.ComboBox cmb = repo.ProfileConsys1.PARTItemsPresenter.ComboboxList;
//
//
//
//
//				foreach (Ranorex.Text txt in cmb.FindDescendants<Ranorex.Text>())
//				{
//				Report.Log(ReportLevel.Success, txt.TextValue);
//				}
//
		////			}
		
//			Ranorex.ListItem
//
//			Ranorex.Container cont = "yourPath";
//			foreach(Ranorex.Text txt in cont.FindChildren<Ranorex.Text>())
//			{
		//    		Report.Log(ReportLevel.Success, txt.TextValue);
//			}
//
		
		//ComboBox cmb = repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.Element.Children;
		
		// IList<Ranorex.ListItem> MyListItems = cmb.FindDescendants<Ranorex.ListItem>();

		//            foreach (Ranorex.ComboBox ThisListItem in repo.ProfileConsys1.PARTItemsPresenter.ComboboxList.Element.Children)
		//            {
		//           	Report.Log(ReportLevel.Success, ThisListItem.Text);
//
		//            }
//	}
//		}
//		}
		
		//	}
		
		
		/*****************************************************************************************
		 * Function Name: ChangeCableLength
		 * Function Details: To change cable length
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : Alpesh Dhakad - 30/07/2019 - Updated scripts as per new build and xpath
		 * Alpesh Dhakad - 07/08/2019 - Updated scripts for cable length
		 * Alpesh Dhakad - 23/08/2019 - Updated with new navigation tree method, xpath
		 * Alpesh Dhakad - 08/01/2021 - Added 1 click event on Loop A node
		 *****************************************************************************************/
		// Change cable length method
		[UserCodeMethod]
		public static void ChangeCableLength(int fchangeCableLength)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view cable length;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("{LControlKey down}{Akey}{LControlKey up}Length" +"{ENTER}" );
			
			//Click on cable length cell
			repo.FormMe.cell_CableLength.Click();

			//Change the value of cable length
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+fchangeCableLength + "{Enter}");
			
			Report.Log(ReportLevel.Info,"Cable Length changed to " +fchangeCableLength+ " successfully");
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			Delay.Duration(1000, false);
		}
		
		/***************************************************************************************************
		 * Function Name: ChangeCableResistance
		 * Function Details: To change cable resistance
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : Alpesh Dhakad - 30/07/2019 - Updated script as per new build and xpath
		 * Alpesh Dhakad - 08/08/2019 - Updated code for cable resistance
		 * Alpesh Dhakad - 23/08/2019 - Updated with new navigation tree method, xpath
		 * Alpesh Dhakad - 19/01/2021 - Updated Resistance name as per new UI Change
		 ***************************************************************************************************/
		// Change cable resistance method
		[UserCodeMethod]
		public static void ChangeCableResistance(string fchangeCableResistance)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view cable length;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("{LControlKey down}{Akey}{LControlKey up}Resistance" +"{ENTER}" );
			
			//Click on cable resistance cell
			repo.FormMe.cell_CableLength.Click();

			//Change the value of cable resistance
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+fchangeCableResistance + "{Enter}");
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			Report.Log(ReportLevel.Info,"Cable Resistance changed to " +fchangeCableResistance+ " successfully");
		
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			Delay.Duration(1000, false);
		}
		
		/********************************************************************
		 * Function Name: AddDevicesForBVT
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Devendra Kulkarni
		 * Last Update : Purvi Bhasin - 22/08/2019 AddDevicesFromGalleryUsingIndex instead of AddDevicesFromGallery
		 ********************************************************************/
		[UserCodeMethod]
		public static void AddDevicesForBVT(string sFileName, string singleDevice, string multipleDevices)
		{
			if(!singleDevice.IsEmpty())
			{
				// Open the excel file and sheet with mentioned name in argument
				Excel_Utilities.OpenExcelFile(sFileName, singleDevice);
				
				// Count the number of rows in excel
				int rows= Excel_Utilities.ExcelRange.Rows.Count;
				
				// Declared various fields as String type
				string modelNumber, sType;
				
				// For loop to fetch values from the excel sheet and then add devices
				for(int i=8; i<=rows; i++)
				{
					modelNumber =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
					sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
					
					// Add devices from the gallery as per test data from the excel sheet
					AddDevicesFromGalleryUsingIndex(modelNumber, sType);
				}
				
				// Close the currently opened excel sheet
				Excel_Utilities.CloseExcel();
			}
			
			if(!multipleDevices.IsEmpty())
			{
				AddMultipleDevices(sFileName, multipleDevices);
			}
		}
		
		/********************************************************************
		 * Function Name: VerifyProperties_BVT
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Devendra Kulkarni
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyProperties_BVT()
		{/*
			repo.FormMe.PointsModel1.Click();
			string modelProperties = repo.FormMe.PropertyModel1.TextValue;
			if (model.Equals(modelProperties))
			{
				Report.Log(ReportLevel.Success, "Properties window displayed for device 1.");
			}
			else
			{
				Report.Log(ReportLevel.Error, "Properties window not displayed for device 1.");
			}
			
			model = repo.FormMe.PointsLabel2.TextValue;
			repo.FormMe.PointsLabel2.Click();
			modelProperties = repo.FormMe.PropertyLabel2.TextValue;
			if (model.Equals(modelProperties))
			{
				Report.Log(ReportLevel.Success, "Properties window displayed for device 2.");
			}
			else
			{
				Report.Log(ReportLevel.Error, "Properties window not displayed for device 2.");
			}*/
		}
		
		
		/**************************************************************************************
		 * Function Name: AssignDeviceBaseForMultipleDevices
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 22/03/2019 - Alpesh Dhakad - Updated code and also updated Xpath
		 * Alpesh Dhakad - 26/05/2020 Updated script as per new implementation changes
		 * Alpesh Dhakad - 17/06/2020 Updated script as per new method to add base
		 **************************************************************************************/
		[UserCodeMethod]
		public static void AssignDeviceBaseForMultipleDevices(string DeviceLabel, string sBaseofDevice, string sBasePropertyRowIndex)
		{
			int iRowIndex;
			string sExistingBase;
			sBase = sBaseofDevice;
			sRowIndex = sBasePropertyRowIndex;
			sLabelName = DeviceLabel;
//			repo.ProfileConsys1.PanelInvetoryGrid.LabelofDevice.Click();
//			repo.ProfileConsys1.BaseofDeviceRow.Click();
//			repo.ProfileConsys1.BaseofDeviceRow.PressKeys("{Right}");
//			
			if(repo.FormMe.txt_LabelNameForOneRowInfo.Exists())
			{
				repo.FormMe.txt_LabelNameForOneRow.Click();
			}
			else
			{
			repo.FormMe.txt_LabelName1.Click();
			}
			repo.FormMe.BaseofDeviceRow.Click();
			repo.FormMe.BaseofDeviceRow.PressKeys("{Right}");
			
			
			
			int.TryParse(sRowIndex, out iRowIndex);
			iRowIndex = iRowIndex+1;
			sRowIndex = iRowIndex.ToString();
			
			//repo.ProfileConsys1.Cell_BaseofDevice.Click();
			repo.FormMe.Cell_BaseofDevice.Click();
			//sExistingBase = repo.ProfileConsys1.SomeText.TextValue;
			sExistingBase = repo.FormMe.txt_cellBaseOfDevice.TextValue;
			////sExistingBase = sExistingBase.Replace(@"\""",string.Empty);
			if(!sExistingBase.Equals(sBase))
			{
				//repo.ProfileConsys1.BaseofDeviceRow.MoveTo("760;19");
				//repo.ProfileConsys1.BaseofDeviceRow.Click("760;19");
				repo.FormMe.BaseofDeviceRow.MoveTo("560;19");
				repo.FormMe.BaseofDeviceRow.Click("560;19");
				
				int.TryParse(sRowIndex, out iRowIndex);
				iRowIndex = iRowIndex-1;
				sRowIndex = iRowIndex.ToString();
				//repo.ProfileConsys1.BaseofDeviceRow.MoveTo("760;19");
				//repo.ProfileConsys1.BaseofDeviceRow.Click("760;19");
				repo.FormMe.BaseofDeviceRow.MoveTo("560;19");
				repo.FormMe.BaseofDeviceRow.Click("560;19");
				
				
				Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfOnly;
				

				
				if(repo.ContextMenu.btn_BaseSelectionInfo.Exists())
				{
					repo.ContextMenu.btn_BaseSelection.Click();
				}
				else
				{
					repo.ContextMenu.btn_Base_Selection_Multiple.Click();
				}
				
				Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfImprovedOnly;
				
				Report.Log(ReportLevel.Info, "Base change was performed successfully.");
			}
		}


		
		/********************************************************************
		 * Function Name: SelectPointsGridRow
		 * Function Details: To select points grid row
		 * Parameter/Arguments: sRowNumber
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 31/12/2018
		 ********************************************************************/
		// Change cable resistance method
		[UserCodeMethod]
		public static void SelectPointsGridRow(string sRowNumber)
		{
			sRowIndex=sRowNumber;
			//Click on row from points grid
			repo.FormMe.PointsGridRow.Click();
		}

		/******************************************************************************************************************************
		 * Function Name: AddDevicesfromMainProcessorGallery
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 03/01/2019  Updated on 28/01/2019 - Added Report Log
		 * Alpesh Dhakad - 16/08/2019 - Updated with new navigation tree method, xpath and devices gallery
		 ******************************************************************************************************************************/
		[UserCodeMethod]
		public static void AddDevicesfromMainProcessorGallery(string sDeviceName,string sType, string PanelType)
		{
			ModelNumber=sDeviceName;
			repo.FormMe.btn_AllGalleryDropdown.Click();
			repo.FormMe.btn_AllGalleryDropdown.EnsureVisible();
			repo.ContextMenu.txt_SelectDevice.Click();
			Report.Log(ReportLevel.Success, "Device "+sDeviceName+" Added Successfully");
//			sMainProcessorGalleryIndex = SelectMainProcessorGalleryType(sType, PanelType);
//			ModelNumber=sDeviceName;
//			repo.FormMe.btn_MainProcessorGalleryDropDown.Click();
//			repo.ContextMenu.txt_SelectDevice.Click();
//			Report.Log(ReportLevel.Info, "Device "+sDeviceName+" added successfully");
		}
		
		
		/***********************************************************************************************************************
		 * Function Name: SelectMainProcessorGalleryType
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 03/01/2018    Updated:23/01/2019 -  Shweta Bhosale-Added panel type check
		                 Updated 02/08/2019 - Purvi Bhasin Index changes in 81.1.20
		 * Updated:02/08/2019 - Updated code with conventional sounders additionin gallery and updated index for others
		 ********************************************************************/
		[UserCodeMethod]
		public static string SelectMainProcessorGalleryType(string sType,string PanelType)
		{
			switch (sType)
			{
				case "Repeaters":
					sMainProcessorGalleryIndex="3";
					break;
				case "Loops":
					sMainProcessorGalleryIndex="4";
					break;
				case "Slot Cards":
					sMainProcessorGalleryIndex="5";
					break;
				case "Miscellaneous":
					if(PanelType.Equals("FIM"))
					{
						sMainProcessorGalleryIndex="5";
					}
					else
					{
						sMainProcessorGalleryIndex="6";
					}
					break;
					
				case "Conventional Sounders":
					if(PanelType.Equals("FIM"))
					{
						sMainProcessorGalleryIndex="6";
					}
					else
					{
						sMainProcessorGalleryIndex="7";
					}
					break;
					
				case "Printers":

					if(PanelType.Equals("FIM"))
					{
						sMainProcessorGalleryIndex="7";
					}
					else
					{
						sMainProcessorGalleryIndex="8";
					}
					break;
				case "Attached Functionality":
					if(PanelType.Equals("FIM"))
					{
						sMainProcessorGalleryIndex="8";
					}
					else
					{
						sMainProcessorGalleryIndex="9";
					}
					break;
				default:
					Console.WriteLine("Please specify correct gallery name");
					break;
			}
			return sMainProcessorGalleryIndex;
		}
		
		/********************************************************************
		 * Function Name: getProgressBarColorForISUnits
		 * Function Details: Method to verify progress bar color for IS units
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 31/12/2018
		 ********************************************************************/
		[UserCodeMethod]
		public static string getProgressBarColorForISUnits()
		{
			string actualColour;
			return actualColour = repo.FormMe.ISUnitProgressBar.GetAttributeValue<string>("foreground");
			
		}
		
		
		/********************************************************************
		 * Function Name: VerifyProgressBarIndicatorForISUnits
		 * Function Details: Verify progress bar indicator for Intrinsically-safe Units
		 * Parameter/Arguments: sFileName, sAddDevicesSheet, sAddIsDevicesSheet
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 12/31/2018
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyProgressBarIndicatorForISUnits(string sFileName,string sAddEXIDevicesSheet)
		{
			//Open excel sheet and read its values
			Excel_Utilities.OpenExcelFile(sFileName,sAddEXIDevicesSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			
			// Declared string type
			string sType, sLabelName, PanelType, sExpectedColorCode, sActualColorCode;
			
			for(int i=8; i<=rows; i++)
			{
				
				ModelNumber =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sExpectedColorCode= ((Range)Excel_Utilities.ExcelRange.Cells[i,11]).Value.ToString();
				
				PanelType = ((Range)Excel_Utilities.ExcelRange.Cells[4,7]).Value.ToString();
				Report.Log(ReportLevel.Info,"All data imported from excel sheet");
				
				if(PanelType.Equals("FIM"))
				{
					sRow = (i+5).ToString();
				}
				else
				{
					sRow = (i+2).ToString();
				}
				
				//Add EXI devices from gallery
				Devices_Functions.AddDevicesfromGallery(ModelNumber,sType);
				Report.Log(ReportLevel.Info,"Device "+ModelNumber+" Added");
				
				//Click physical layout tab
				Common_Functions.clickOnPhysicalLayoutTab();
				sRowIndex=(i+1).ToString();
				
				//Verify Progress bar color code for extra IS units
				sActualColorCode= getProgressBarColorForISUnits();
				Devices_Functions.VerifyPercentage(sExpectedColorCode, sActualColorCode);
				Report.Log(ReportLevel.Info,"Progress bar color code for EXI row " + (i-7) + " verified as: "+sExpectedColorCode);
				
				//Click physical layout tab
				Common_Functions.clickOnPointsTab();
			}
			
			//Setting the row count l to 8 to set sRow value and fetch values from excel
			int m=8;
			sExpectedColorCode= ((Range)Excel_Utilities.ExcelRange.Cells[m,11]).Value.ToString();
			sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[m,1]).Value.ToString();
			
			//Delete IS device
			Devices_Functions.DeleteDeviceUsingLabel(sLabelName);
			Report.Log(ReportLevel.Info,"Device "+sLabelName+" deleted");
			
			//Click physical layout tab
			Common_Functions.clickOnPhysicalLayoutTab();
			sRowIndex=(m+1).ToString();
			
			//Verify Progress bar color code for extra IS units
			sActualColorCode= getProgressBarColorForISUnits();
			Devices_Functions.VerifyPercentage(sExpectedColorCode, sActualColorCode);
			Report.Log(ReportLevel.Info,"Progress bar color code for EXI row " + (m-7) + " verified as: "+sExpectedColorCode);
			
		}
		
		/********************************************************************
		 * Function Name: SelectInventoryGridRow
		 * Function Details: To select inventory grid row
		 * Parameter/Arguments: sRowNumber, sSkuNumber
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 2/1/2018
		 ********************************************************************/
		// Change cable resistance method
		[UserCodeMethod]
		public static void SelectInventoryGridRow(string sRowNumber)
		{
			sRow=sRowNumber;
			
			repo.FormMe.InventoryGridRow.Click();
			Report.Log(ReportLevel.Success, "Inventory grid row selected");
		}
		
		/********************************************************************************************************************************
		 * Function Name: AddDevicefromPanelAccessoriesGallery
		 * Function Details: Add devices from panel accessories
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 04/01/2019, 18/01/2019 - Alpesh Dhakad - Updated Report log
		 * Alpesh Dhakad - 16/08/2019 - Updated with new navigation tree method, xpath and devices gallery
		 ********************************************************************************************************************************/
		[UserCodeMethod]
		public static void AddDevicefromPanelAccessoriesGallery(string sDeviceName,string sType)
		{
			ModelNumber=sDeviceName;
			repo.FormMe.btn_AllGalleryDropdown.Click();
			repo.FormMe.btn_AllGalleryDropdown.EnsureVisible();
			repo.ContextMenu.txt_SelectDevice.Click();
			Report.Log(ReportLevel.Success, "Device "+sDeviceName+" Added Successfully");
			
			
//			sAccessoriesGalleryIndex= SelectPanelAccessoriesGalleryType(sType);
//			ModelNumber=sDeviceName;
//			repo.FormMe.btn_PanelAccessoriesDropDown.Click();
//			repo.ContextMenu.txt_SelectDevice.Click();
//			Report.Log(ReportLevel.Success,"Panel Accessories device " + sDeviceName + " added successfully " );
		}
		
		/********************************************************************
		 * Function Name: SelectPanelAccessoriesGalleryType
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : 23/01/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static string SelectPanelAccessoriesGalleryType(string sType)
		{
			switch (sType)
			{
				case "Accessories":
					sAccessoriesGalleryIndex="2";
					break;
				default:
					Console.WriteLine("Please specify correct gallery name");
					break;
			}
			return sAccessoriesGalleryIndex;
		}
		
		
		/*****************************************************************************************************************
		 * Function Name: additionOfDevicesOnEthernet
		 * Function Details: To add devices on main processor ethernet connection using excel test data
		 * Parameter/Arguments: filename and add devices sheet name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 03/01/2019
		 *****************************************************************************************************************/
		[UserCodeMethod]
		public static void additionOfDevicesOnEthernet(string sFileName,string sAddDevicesSheet,string PanelType)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			
			// Declared string type
			string sType,sLabelName;
			
			
			// For loop to iterate on data present in excel
			for(int i=8; i<=rows; i++)
			{
				ModelNumber =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				
				AddDevicesfromMainProcessorGallery(ModelNumber,sType,PanelType);
				Report.Log(ReportLevel.Info, "Device "+ModelNumber+" added successfully");
			}
			//Close opened excel sheet
			Excel_Utilities.CloseExcel();
		}
		
		/*****************************************************************************************************************
		 * Function Name: additionOfDevicesOnRBus
		 * Function Details: To add devices on main processor RBus connection using excel test data
		 * Parameter/Arguments: Filename and add devices sheet
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 04/01/2019
		 *****************************************************************************************************************/
		[UserCodeMethod]
		public static void additionOfDevicesOnRBus(string sFileName,string sAddDevicesSheet,string PanelType)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			
			// Declared string type
			string sType,sLabelName;
			
			// For loop to iterate on data present in excel
			for(int i=8; i<=rows; i++)
			{
				ModelNumber =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				
				AddDevicesfromMainProcessorGallery(ModelNumber,sType,PanelType);
				Report.Log(ReportLevel.Info, "Device "+ModelNumber+" added successfully");
			}
			//Close opened excel sheet
			Excel_Utilities.CloseExcel();
		}
		
		
		/*****************************************************************************************************************
		 * Function Name: additionOfDevicesOnXBus
		 * Function Details: To add XBus devices using excel test data using RBus devices
		 * Parameter/Arguments: File name and add devices sheet name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 07/01/2019
		 *****************************************************************************************************************/
		[UserCodeMethod]
		public static void additionOfDevicesForXBus(string sFileName,string sAddDevicesSheet,string PanelType)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			
			// Declared string type
			string sType,sLabelName;
			
			// For loop to iterate on data present in excel
			for(int i=8; i<=rows; i++)
			{
				ModelNumber =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				
				AddDevicesfromMainProcessorGallery(ModelNumber,sType,PanelType);
				Report.Log(ReportLevel.Info, "Device "+ModelNumber+" added successfully");
				
				Thread.Sleep(4000);
			}
			
			//Close opened excel sheet
			Excel_Utilities.CloseExcel();
		}
		
		
		/********************************************************************
		 * Function Name: VerifyAlarmLoad
		 * Function Details: To verify alarm load of sounder
		 * Parameter/Arguments:expected alarm load
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :19/2/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyAlarmLoad(string sAlarmLoad)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Alarm Load" +"{ENTER}" );
			
			// Click on Alarm Load cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			// Retrieve value alarm load
			string actualAlarmLoad = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
			
			// Comparing DayMode and sDayMode values
			if(actualAlarmLoad.Equals(sAlarmLoad))
			{
				Report.Log(ReportLevel.Success,"Alarm Load " +sAlarmLoad+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Alarm Load is not displayed as "+actualAlarmLoad+ " instead of "+ sAlarmLoad);
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelName
		 * Function Details: To select item from grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : 21/2/2019 Alpesh Dhakad - 31/01/2020 Added xpath and updated below script
		 * 16/09/2021 - Added if else statement to verify Logical template label name xpath as well
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelName(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			//repo.FormMe.txt_LabelName1.Click();			
			
			if(repo.FormMe.txt_LabelName1Info.Exists())
			{
				repo.FormMe.txt_LabelName1.Click();
			}
			else
			{
				repo.FormMe.txt_LabelNameForLogicalTemplate.Click();
			}
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
				
		}
		
		
		/********************************************************************
		 * Function Name: RightClickOnSelectedRow
		 * Function Details: To open the context menu options using right click
		 * Parameter/Arguments: RowNumber
		 * Output:
		 * Function Owner: Purvi
		 * Last Update : 11/4/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void RightClickOnSelectedRow(string RowNumber)
		{
			sRowIndex = RowNumber;
			
			if(sRowIndex.Equals("1"))
			{
				repo.FormMe.PointsGridRow_SingleRow.Click(System.Windows.Forms.MouseButtons.Right);
			}
			else
			{
			repo.FormMe.PointsGridRow.Click(System.Windows.Forms.MouseButtons.Right);
			}
		}
		
		/********************************************************************
		 * Function Name: DeleteDevicesPresentInCustomGallery
		 * Function Details: To delete devices from custom gallery
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta
		 * Last Update : 11/4/2019 Updated on 10/07/2019 by Purvi Bhasin
		 ********************************************************************/
		[UserCodeMethod]
		public static void DeleteDevicesPresentInCustomGallery()
		{
			if(repo.FormMe.btn_CustomDevices.Enabled)
			{
				Report.Log(ReportLevel.Info, "Custom devices are present in gallery");
				repo.FormMe.btn_CustomDevices.Click();
				int numberOfCustomDevices= repo.CustomDevices.Custom_Gallery_Container.Children.Count;
				Report.Log(ReportLevel.Info, "No of Custom devices are "+numberOfCustomDevices);
				for(int i=2;i<numberOfCustomDevices;i++)
				{
					int j=0;
					sListIndex=j.ToString();
					repo.CustomDevices.CustomGalleyListItem.Click(System.Windows.Forms.MouseButtons.Right);
					repo.ContextMenu.btn_DeleteDevice_CustomGallery.Click();
				}
				repo.CustomDevices.ButtonOK_CustomGallery.Click();
			}
			else
			{
				Report.Log(ReportLevel.Info, "Custom devices are not present in gallery");
			}
			
		}
		/********************************************************************
		 * Function Name: VerifyDeviceUsingLabelName
		 * Function Details: To verify item with label name
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : 12/3/2019
		 ********************************************************************/
		// Change cable resistance method
		[UserCodeMethod]
		public static void VerifyDeviceUsingLabelName(string sLabel)
		{
			sLabelName = sLabel;
			if(repo.FormMe.txt_LabelName1Info.Exists())
			{
				Report.Log(ReportLevel.Success,"Device with label name " +sLabel+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device with label name " +sLabel+ " not is displayed correctly");
			}
		}
		/********************************************************************
		 * Function Name: changeAndVerifyAlarmLoad
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :Alpesh Dhakad - 21/05/2020 Updated script as per new implementation changes
		 ********************************************************************/
		[UserCodeMethod]
		public static void changeAndVerifyAlarmLoad(int AlarmLoad, string rangeState, int expectedResult)
		{
			
			int Value,actualValue,revertTo;
			string actualAlarmLoad;
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Alarm Load" +"{ENTER}" );
			
			// Click on Alarm Load cell
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			repo.FormMe.cell_Properties.Click();
			
			if((rangeState.Equals("Valid")))
			{
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+AlarmLoad +"{ENTER}");
				
				// Click on Alarm Load cell
				//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
				repo.FormMe.cell_Properties.Click();
				
				// Retrieve value alarm load
				//actualAlarmLoad = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
				actualAlarmLoad = repo.FormMe.txt_AlarmLoad.TextValue;

				
				int.TryParse(actualAlarmLoad, out Value);
				if(Value==AlarmLoad)
				{
					Report.Log(ReportLevel.Success,"Number of Alarm Load is changed to: "+AlarmLoad);
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Number of Alarm Load is not changed to: "+AlarmLoad);
				}
			}
			else if((rangeState.Equals("InvalidRange")))
			{
				//string initialValue = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
				string initialValue = repo.FormMe.txt_AlarmLoad.TextValue;
				
				int.TryParse(initialValue,out revertTo);
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+AlarmLoad +"{ENTER}");
				// Click on Alarm Load cell
				//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
				repo.FormMe.cell_Properties.Click();
				
				//string revertedValue = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
				string revertedValue = repo.FormMe.txt_AlarmLoad.TextValue;
				
				int.TryParse(revertedValue, out actualValue);
				if(actualValue==revertTo)
				{
					Report.Log(ReportLevel.Success,"Number of Alarm Load is reverted to: "+revertTo);
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Number of Alarm Load is not reverted to: "+revertTo);
				}
			}
			else
			{
				
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+AlarmLoad +"{ENTER}");
				// Click on Alarm Load cell
				//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
				repo.FormMe.cell_Properties.Click();
				
				//string revertedValue = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
				string revertedValue = repo.FormMe.txt_AlarmLoad.TextValue;
				int.TryParse(revertedValue,out actualValue);
				if(actualValue==expectedResult)
				{
					Report.Log(ReportLevel.Success,"Number of Alarm Load is reverted to: "+expectedResult);
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Number of Alarm Load is not reverted to: "+expectedResult);
				}
				
			}
			
		}
		
		/********************************************************************
		 * Function Name: verifyMinMaxThroughSpinControlForAlarmLoad
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyMinMaxThroughSpinControlForAlarmLoad(string minLimit,string maxLimit)
		{
			// Click on Alarm Load cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+ maxLimit +"{ENTER}");
			
			// Click on Alarm Load cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			repo.FormMe.AlarmLoadSpinUpButton.Click();
			string actualValue = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
			if(actualValue.Equals(maxLimit))
			{
				Report.Log(ReportLevel.Success,"Spin control accepts values within specified max limit");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Spin control doesnot accepts values within specified max limit");
			}
			Keyboard.Press("{ENTER}");
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+ minLimit +"{ENTER}");
			
			// Click on Alarm Load cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			repo.FormMe.AlarmLoadSpinDownButton.Click();
			actualValue = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
			if(actualValue.Equals(minLimit))
			{
				Report.Log(ReportLevel.Success,"Spin control accepts values within specified min limit");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Spin control does not accepts values within specified min limit");
			}
		}
		
		
		/****************************************************************************************************************************
		 * Function Name: AddDevicesfromMultiplePointWizard
		 * Function Details: To add multiple devices using multiple point wizard
		 * Parameter/Arguments: Device name and its quantity
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 29/03/2019 Alpesh Dhakad- Updated btn_MultiplePointWizard xpath and change script accordingly
		 ****************************************************************************************************************************/
		[UserCodeMethod]
		public static void AddDevicesfromMultiplePointWizard(string sDeviceName,int DeviceQty )
		{
			repo.FormMe.btn_MultiplePointWizard.Click();
			//repo.ProfileConsys1.btn_MultiplePointWizard_DoNotUse.Click();
			repo.AddDevices.txt_AllDevices.Click();
			
			repo.AddDevices.txt_SearchDevices.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+sDeviceName);
			ModelNumber = sDeviceName;
			repo.AddDevices.txt_ModelNumber1.Click();
//			repo.AddDevices.txt_ModelNumber.Click();
			repo.AddDevices.txt_Quantity.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+DeviceQty.ToString());
			
			repo.AddDevices.btn_AddDevices.Click();
			Report.Log(ReportLevel.Success,+DeviceQty+" \""+sDeviceName+ "\" Device Added successfully");
			Delay.Milliseconds(200);

		}
		
		/***********************************************************************************************************
		 * Function Name: CreateProject
		 * Function Details: To create project with different market with List Index Mentioned in the argument
		 * Parameter/Arguments: sMarket, iListIndex
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 05/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void CreateProject(string sMarket,int iListIndex )
		{
			repo.ProfileConsys1.File.Click();
			
			repo.ProfileConsys1.TextNew.Click();
			
			repo.ProfileConsys1.PARTRight.txt_MarketNew.Click();
			Keyboard.Press(sMarket);
			
			sListIndex=iListIndex.ToString();
			repo.ProfileConsys1.lst_Market.Click();
			
			repo.ProfileConsys1.PARTRight.btn_CreateNewProject.Click();
			
			// Enter Project name
			repo.CreateNewProject.CreateNewProjectContainer.txt_ProjectName.Click();
			Delay.Duration(1000, false);
			Keyboard.Press("Verify");
			
			// Enter text in Client Name field
			repo.CreateNewProject.CreateNewProjectContainer.txt_ClientName.Click();
			Keyboard.Press("JCI");
			
			// Enter text Client Address field
			repo.CreateNewProject.CreateNewProjectContainer.txt_ClientAddress.Click();
			Keyboard.Press("JCI");
			
			// Enter text in Installer Name field
			repo.CreateNewProject.CreateNewProjectContainer.txt_InstallerName.Click();
			Keyboard.Press("JCI");
			
			// Enter text in Installer Address field
			repo.CreateNewProject.CreateNewProjectContainer.txt_InstallerAddress.Click();
			Keyboard.Press("JCI");

			// Click on Ok Button
			repo.CreateNewProject.CreateNewProjectContainer.btn_OK.Click();


		}
		
		/***********************************************************************************************************
		 * Function Name: verifyShoppingListDevices
		 * Function Details: To verify shopping list devices via clicking on its row
		 * Parameter/Arguments: sFileName,sDeviceSheet
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 07/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyShoppingListDevices(string sFileName, string sDeviceSheet )
		{
			Excel_Utilities.OpenExcelFile(sFileName,sDeviceSheet);
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			string sDeviceName,sType,sLabelName;
			
			for(int i=8; i<=rows; i++)
			{
				sDeviceName=  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				sRow=  ((Range)Excel_Utilities.ExcelRange.Cells[i,4]).Value.ToString();
				
				repo.FormMe.ShoppingListDevices1.Click();
				
				repo.FormMe.ShoppingListDevices1.EnsureVisible();
				Report.Log(ReportLevel.Info,"Device is successfully displayed in shopping list as " +sDeviceName);
				
				
			}
			Excel_Utilities.CloseExcel();
			
		}
		
		
		/***********************************************************************************************************
		 * Function Name: verifyShoppingList
		 * Function Details: To verify Shopping List row count
		 * Parameter/Arguments: ShoppingListDeviceCount
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 07/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyShoppingList(int ShoppingListDeviceCount)
		{
			int ActualShoppingListDeviceCount = repo.FormMe.ShoppingListContainer.Children.Count();

			if(ActualShoppingListDeviceCount.Equals(ShoppingListDeviceCount))
			{
				Report.Log(ReportLevel.Success,"Devices is displayed correctly in shopping list");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Devices not displayed correctly in shopping list");
			}
			
		}
		
		/***********************************************************************************************************
		 * Function Name: AddDeviceOrderColumn
		 * Function Details: To add device order column
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 07/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void AddDeviceOrderColumn()
		{
			
			// Select Point grid and right click on it
			Mouse.Click(repo.FormMe.HeadersPanel1, System.Windows.Forms.MouseButtons.Right);
			
			// Click Show column chooser to select column
			repo.ContextMenu.ShowColumnChooser.Click();
			
			// Click on Device order checkbox to add the column in points grid
			repo.ProfileConsys.chkBox_DeviceOrder1.Click();
			Report.Log(ReportLevel.Info," Device order column added successfully ");
			
			// Close column choose window
			repo.ProfileConsys.btn_CloseColumnChooser.Click();
			
		}
		
		/***********************************************************************************************************
		 * Function Name: VerifyDeviceOrder
		 * Function Details: To add device order column
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 04/04/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceOrder(string DeviceOrderRow, string DeviceOrder, bool Present)
		{
			sDeviceOrderRow = DeviceOrderRow;
			repo.FormMe.DeviceOrder_txt.Click();
			string ActualDeviceOrder = repo.FormMe.DeviceOrder_txt.TextValue;
			if(Present)
			{
				if(ActualDeviceOrder.Equals(DeviceOrder))
				{
					Report.Log(ReportLevel.Success,"Device Order is displayed correctly");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Device Order not displayed correctly");
				}
			}
			else
			{
				if(ActualDeviceOrder.Equals(DeviceOrder))
				{
					Report.Log(ReportLevel.Failure,"Wrong Device Order is present");
				}
				else
				{
					Report.Log(ReportLevel.Success,"Device Order not displayed");
				}
			}
			
			
		}
		
		
		/***********************************************************************************************************
		 * Function Name: EditAlarmLoad
		 * Function Details: EditAlarmLoad
		 * Parameter/Arguments: Alarm Load to be entered
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : 11/03/2019 Alpesh Dhakad - 28/05/2020 Updated script as per new xpaths
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void EditAlarmLoad(string AlarmLoad)
		{
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Alarm Load" +"{ENTER}" );
			
			// Click on Alarm Load cell
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			repo.FormMe.cell_LabelNameProperties.Click();
			
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.PressKeys(AlarmLoad);
			
			repo.FormMe.txt_LabelNameProperties.PressKeys("{LControlKey down}{Akey}{Delete}{LControlKey up}"+(AlarmLoad)+"{ENTER}" + "{ENTER}");
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			
		}
		
		/***********************************************************************************************************
		 * Function Name: VerifyAlarmCurrentLoadProperty
		 * Function Details: VerifyAlarmCurrentLoad property
		 * Parameter/Arguments: IsReadOnly
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : 12/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyAlarmCurrentLoadProperty(bool isReadOnly)
		{
			
			bool result = repo.FormMe.AlarmCurrent.Enabled;
			if(result==isReadOnly)
			{
				Report.Log(ReportLevel.Success,"AlarmCurrent Property is as expected");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"AlarmCurrent property is "+ result + " instead of" +isReadOnly);
			}
			
		}
		

		/***********************************************************************************************************
		 * Function Name: verifyPointsGridColumn
		 * Function Details: To verify points grid columns text
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 15/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyPointsGridColumn(string expectedColumnText, string ColumnNumber)
		{
			// Click on points tab
			Common_Functions.clickOnPointsTab();
			
			// Set sColumn value
			sColumn = ColumnNumber;
			
			// Retrieve Column text value
			string actualColumnText = repo.FormMe.PointsGridHeaderColumn1.TextValue;
			
			// Compare actual and expected column value
			if(actualColumnText.Equals(expectedColumnText))
			{
				Report.Log(ReportLevel.Success,"Column is "+expectedColumnText+ " which is displayed correctly in points grid");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Column is "+actualColumnText+ " which is displayed incorrectly instead of " +expectedColumnText+ " in points grid ");
			}
			
		}
		/***************************************************************************************************************
		 * Function Name: verifyDescription
		 * Function Details: To verify description from properties
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 13/03/2019  24/05/2019 - Updated script, added if statement for tab_Points and cell_properties
		 * Alpesh Dhakad - 05/09/2019& 06/09/2019 - Updated xpath for cell_properties,txt_PropertiesTextValue & code
		 ***************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyDescription(string sDescription)
		{
			if(repo.ProfileConsys1.tab_PointsInfo.Exists())
			{
				//Click on Points tab
				Common_Functions.clickOnPointsTab();
			}
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Description" +"{ENTER}" );
			
			
			
			if(repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceModeInfo.Exists())
			{
				// Click on Alarm Load cell
				repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			}
			else
			{
				// Click on Properties cell
				repo.FormMe.cell_Properties_backplane1.Click();
				
			}

			if(repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNightInfo.Exists())
			{
				// Retrieve value alarm load
				string actualDescription = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
				
				// Comparing DayMode and sDayMode values
				if(actualDescription.Equals(sDescription))
				{
					Report.Log(ReportLevel.Success,"Description " +sDescription+ " is displayed correctly");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Description is displayed as "+actualDescription+ " instead of "+ sDescription);
				}
				
			}
			else
			{
				
				
				string actualDescription =	repo.FormMe.cell_Properties_backplane1.Text;
				
				// Comparing DayMode and sDayMode values
				if(actualDescription.Equals(sDescription))
				{
					Report.Log(ReportLevel.Success,"Description " +sDescription+ " is displayed correctly");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Description is displayed as "+actualDescription+ " instead of "+ sDescription);
				}
				
				
			}
			
			
			
			if(repo.ProfileConsys1.tab_PointsInfo.Exists())
			{
				//Click on Points tab
				Common_Functions.clickOnPointsTab();
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		
		
		/***********************************************************************************************************
		 * Function Name: verifyAdditionOfSoundersInLPS800
		 * Function Details: To verify sounder properties i.e. Description and alarm load from Properties
		 * Parameter/Arguments: filename and device sheetname
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 14/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyAdditionOfSoundersInLPS800(string sFileName, string sDeviceSheet)
		{
			Common_Functions.clickOnPointsTab();
			
			Excel_Utilities.OpenExcelFile(sFileName,sDeviceSheet);
			
			// Count the number of rows in excel
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			string sType,expectedDescription,expectedAlarmLoad,sourceDeviceIndex,targetDeviceIndex;
			
			for(int i=9; i<=rows; i++)
			{
				string sDeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				expectedDescription = ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
				expectedAlarmLoad = ((Range)Excel_Utilities.ExcelRange.Cells[i,6]).Value.ToString();
				
				SelectRowUsingLabelName(sLabelName);
				
				verifyDescription(expectedDescription);
				
				VerifyAlarmLoad(expectedAlarmLoad);
				
			}
			
			//Click on Physical Layout tab
			Common_Functions.clickOnPhysicalLayoutTab();
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			//Click on Physical Layout tab
			Common_Functions.clickOnPhysicalLayoutTab();
			
			// Retrieve value of sourceDeviceIndex & targetDeviceIndex from sheet
			sourceDeviceIndex= ((Range)Excel_Utilities.ExcelRange.Cells[3,6]).Value.ToString();
			targetDeviceIndex= ((Range)Excel_Utilities.ExcelRange.Cells[4,6]).Value.ToString();
			
			// Assigning first EXI index value to Physical Layout index
			sPhysicalLayoutDeviceIndex =  sourceDeviceIndex;
			
			// Create a adapter and stored in source adapter element
			Adapter sourceE = repo.FormMe.lst_PhysicalLayoutDevice;
			
			// Assigning first EXI index value to Physical Layout index
			sPhysicalLayoutDeviceIndex =  targetDeviceIndex;
			
			// Create a adapter and stored in targer adapter element
			Adapter targetE = repo.FormMe.PhysicalLayoutDevice;

			// Drag and drop EXI or LI device from First position to its defined position
			Ranorex.AutomationHelpers.UserCodeCollections.DragNDropLibrary.DragAndDrop(sourceE,targetE);
			
			// Close Excel sheet
			Excel_Utilities.CloseExcel();
			
			
		}
		
		
		
		/***********************************************************************************************************
		 * Function Name: verifySavedOpenProjectOnLPS800Addition
		 * Function Details: To verify saved open project on LPS800 addition
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 13/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifySavedOpenProjectOnLPS800Addition(string sFileName, string sDeviceSheet)
		{
			// Select Point grid and right click on it
			Mouse.Click(repo.FormMe.HeadersPanel1, System.Windows.Forms.MouseButtons.Right);
			
			// Click Show column chooser to select column
			repo.ContextMenu.ShowColumnChooser.Click();
			
			// Click on Device order checkbox to add the column in points grid
			repo.ProfileConsys.chkBox_DeviceOrder1.Click();
			Report.Log(ReportLevel.Info," Device order column added successfully ");
			
			// Close column choose window
			repo.ProfileConsys.btn_CloseColumnChooser.Click();
			
			// Open Another excel to verify IS devices state
			Excel_Utilities.OpenExcelFile(sFileName,sDeviceSheet);
			
			// Count the number of rows in excel
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			// Set sDeviceOrderRow value
			sDeviceOrderRow = (1).ToString();
			
			// Retrieve LPS800DeviceOrder value from excel sheet
			string LPS800DeviceOrder = ((Range)Excel_Utilities.ExcelRange.Cells[8,7]).Value.ToString();
			
			// Click on Device order label
			repo.FormMe.DeviceOrder_txt.Click();
			
			// Retrieve value from Device order
			string actualLPSDeviceOrderValue = repo.FormMe.DeviceOrder_txt.TextValue;
			
			// Compare actualDeviceOrderValue and sDeviceOrderName values and then displaying result
			if(actualLPSDeviceOrderValue.Equals(LPS800DeviceOrder))
			{
				Report.Log(ReportLevel.Success, "Device " +sDeviceName+ " with " +LPS800DeviceOrder+ " added successfully and displaying correct device order");
			}
			else
			{
				Report.Log(ReportLevel.Failure, "Device " +sDeviceName+ " with " +LPS800DeviceOrder+ " not added or not displaying correct device order");
			}
			
			
			for(int i=9; i<=rows; i++)
			{
				sDeviceOrderRow= (i-6).ToString();
				string changedDeviceOrder = ((Range)Excel_Utilities.ExcelRange.Cells[i,7]).Value.ToString();
				
				// Click on Device Order
				repo.FormMe.DeviceOrder_txt.Click();
				
				// Retrieve value from Device order
				string actualDeviceOrderValue = repo.FormMe.DeviceOrder_txt.TextValue;
				
				// Compare actualDeviceOrderValue and sDeviceOrderName values and then displaying result
				if(actualDeviceOrderValue.Equals(changedDeviceOrder))
				{
					Report.Log(ReportLevel.Success, "Device " +sDeviceName+ " with " +changedDeviceOrder+ " added successfully and displaying correct device order");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Device " +sDeviceName+ " with " +changedDeviceOrder+ " not added or not displaying correct device order");
				}
				
			}
			// Close Excel sheet
			Excel_Utilities.CloseExcel();
		}
		
		
		/***********************************************************************************************************
		 * Function Name: verifyDeletionOfSoundersInLPS800
		 * Function Details: To verify deletion of Sounders in LPS800
		 * Parameter/Arguments: filename and device sheetname
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 14/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyDeletionOfSoundersInLPS800(string sFileName, string sDeviceSheet, string sDeleteDeviceSheet)
		{
			// Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Open excel sheet
			Excel_Utilities.OpenExcelFile(sFileName,sDeviceSheet);
			
			// Count the number of rows in excel
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			string sType,expectedDescription,expectedAlarmLoad;
			
			for(int i=8; i<=rows; i++)
			{
				string sDeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				expectedDescription = ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
				expectedAlarmLoad = ((Range)Excel_Utilities.ExcelRange.Cells[i,6]).Value.ToString();
				
				SelectRowUsingLabelName(sLabelName);
				
				verifyDescription(expectedDescription);
				
				VerifyAlarmLoad(expectedAlarmLoad);
				
			}
			// Close Excel sheet
			Excel_Utilities.CloseExcel();
			
			// Open Excel sheet
			Excel_Utilities.OpenExcelFile(sFileName,sDeleteDeviceSheet);
			
			// Count the number of rows in excel
			rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			for(int i=8; i<=rows; i++)
			{
				string sDeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				
				SelectRowUsingLabelName(sLabelName);
				Common_Functions.clickOnDeleteButton();
				
				Validate.AttributeEqual(repo.FormMe.txt_LabelName1Info, "Text", sLabelName);
				Report.Log(ReportLevel.Success, "Device "+sLabelName+" deleted successfully");
				
				
			}
			// Close Excel sheet
			Excel_Utilities.CloseExcel();
		}
		
		
		/***********************************************************************************************************
		 * Function Name: verifyPointGridRowCount
		 * Function Details: To verify points grid row count
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 14/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyPointGridRowCount(int ExpectedPointGridRowCount)
		{
			// Retrieve Point grid rows count
			int ActualPointGridRowCount = repo.FormMe.PointsGridContainer.Children.Count();

			// Compare Actual and Expected Point Grid Row count
			if(ActualPointGridRowCount.Equals(ExpectedPointGridRowCount))
			{
				Report.Log(ReportLevel.Success,"Devices is displayed correctly in Points grid");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Devices not displayed correctly in Points grid");
			}
			
		}
		
		
		
		/***********************************************************************************************************
		 * Function Name: verifySoundersDeviceOrderInLPS800
		 * Function Details: To verify Sounders DeviceOrder In LPS800
		 * Parameter/Arguments: filename and device sheetname
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 15/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifySoundersDeviceOrderInLPS800(string sFileName, string sDeviceSheet)
		{
			Excel_Utilities.OpenExcelFile(sFileName,sDeviceSheet);
			
			// Count the number of rows in excel
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			string sType;
			
			for(int i=8; i<=rows; i++)
			{
				//sDeviceOrderRow= (i-3).ToString();
				sDeviceOrderRow= ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
				string sDeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				string changedDeviceOrder = ((Range)Excel_Utilities.ExcelRange.Cells[i,4]).Value.ToString();
				
				// Click on Device Order
				repo.FormMe.txt_DeviceOrderLabel.Click();
				
				// Retrieve Device order value
				string actualDeviceOrderValue = repo.FormMe.txt_DeviceOrderLabel.TextValue;
				Report.Log(ReportLevel.Info,"Actual"+actualDeviceOrderValue+"expected"+changedDeviceOrder);
				// Compare actualDeviceOrderValue and sDeviceOrderName values and then displaying result
				if(actualDeviceOrderValue.Equals(changedDeviceOrder))
				{
					Report.Log(ReportLevel.Success, "Device " +sDeviceName+ " with " +changedDeviceOrder+ " added successfully and displaying correct device order");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Device " +sDeviceName+ " with " +changedDeviceOrder+ " not added or not displaying correct device order");
				}
				
				// Click on Label name in points grid
				SelectRowUsingLabelName(sLabelName);
				
				
				// Retrieve label name
				string actualLabelName = repo.FormMe.txt_LabelName1.TextValue;
				
				// Compare actualDeviceOrderValue and sDeviceOrderName values and then displaying result
				if(actualLabelName.Equals(sLabelName))
				{
					Report.Log(ReportLevel.Success, "Device " +sDeviceName+ " with " +sLabelName+ " displaying correctly in correct device order");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Device " +sDeviceName+ " with " +sLabelName+ " not displaying correctly in correct device order");
				}
				
			}
			// Close excel sheet
			Excel_Utilities.CloseExcel();
		}
		
		
		/********************************************************************
		 * Function Name: AddISDevicesfromMultiplePointWizard
		 * Function Details: To verify IS devices present in Multiple Point Wizard
		 * Parameter/Arguments: Device name
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 15/03/2019 and 29/03/2019 Alpesh Dhakad- Updated btn_MultiplePointWizard xpath and change script accordingly
		 ********************************************************************/
		[UserCodeMethod]
		public static void AddISDevicesfromMultiplePointWizard(string sDeviceName )
		{
			repo.FormMe.btn_MultiplePointWizard.Click();
			//repo.ProfileConsys1.btn_MultiplePointWizard_DoNotUse.Click();
			repo.AddDevices.txt_AllDevices.Click();
			
			repo.AddDevices.txt_SearchDevices.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+sDeviceName);
			ModelNumber = sDeviceName;
			if(repo.AddDevices.txt_ModelNumberInfo.Exists())
			{
				Report.Log(ReportLevel.Failure,"IS Devices are present in Multiple Point Wizard");
				
			}
			else
			{
				Report.Log(ReportLevel.Success,"IS Devices are absent in Multiple Point Wizard");
				
			}
			
			Delay.Milliseconds(200);

		}

		/********************************************************************
		 * Function Name: VerifyISDevicesGetPasted
		 * Function Details: To verify IS devices get pasted only on Exi800
		 * Parameter/Arguments: Device name
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 18/03/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyISDevicesGetPasted(bool sExi800Selected )
		{
			if(sExi800Selected)
			{
				if(repo.FormMe.btn_PasteInfo.Exists())
				{
					
					Report.Log(ReportLevel.Success,"IS Devices can be pasted in Exi800");
					Common_Functions.clickOnPasteButton();
				}
				else
				{
					Report.Log(ReportLevel.Failure,"IS Devices cannot be pasted in Exi800");
					
				}
			}
			
			else
			{
				if(repo.FormMe.btn_PasteInfo.Exists())
				{
					Report.Log(ReportLevel.Failure,"IS Devices can be pasted in Exi800");
					
				}
				else
					
				{
					Report.Log(ReportLevel.Success,"IS Devices cannot be pasted in non-Ex devices");
					Common_Functions.clickOnPasteButton();
					
				}
			}
		}
		
		/********************************************************************
		 * Function Name:
		 * Function Details:
		 * Parameter/Arguments: boolean value
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyIsolatorCheckbox(bool ExpectedState)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Isolator" +"{ENTER}" );

			// Click on Isolator  cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DayMatchesNight.Click();
			
			
			// To retrieve the attribute value as boolean by its ischecked properties and store in actual state
			bool actualState =  repo.ProfileConsys1.chkbox_Isolator.GetAttributeValue<bool>("ischecked");
			
			//As per actual state and expected state values
			if(actualState.Equals(ExpectedState))
			{
				Report.Log(ReportLevel.Success, "Isolator device is displayed as expected ");
			}
			else
			{
				Report.Log(ReportLevel.Failure, "Isolator device is not displayed as expected ");
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		

		/****************************************************************************************************************
		 * Function Name: verifyTripCurrentOnBaseChange
		 * Function Details: To verify trip current details on base change and isolator properties check
		 * Parameter/Arguments: sfilename and sheetname
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : Alpesh Dhakad - 12/12/2019 - Updated test scripts with new method for loading details
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyTripCurrentOnBaseChange(string sFileName, string sDeviceSheet)
		{
			// Open Excel sheet
			Excel_Utilities.OpenExcelFile(sFileName,sDeviceSheet);
			
			// Count the number of rows in excel
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			
			string sType,expectedDCUnits,expectedDCUnitsAfterBaseChange,expectedIsolatorState,DCUnitLoadingDetailName;
			bool expectedIsolatorCheckboxState;
			
			for (int i=8; i<=rows; i++)
			{
				sDeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				expectedDCUnits = ((Range)Excel_Utilities.ExcelRange.Cells[i,4]).Value.ToString();
				expectedDCUnitsAfterBaseChange = ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
				
				DCUnitLoadingDetailName = ((Range)Excel_Utilities.ExcelRange.Cells[2,6]).Value.ToString();
				
				
				expectedIsolatorState = ((Range)Excel_Utilities.ExcelRange.Cells[i,6]).Value.ToString();
				
				
				sBase = ((Range)Excel_Utilities.ExcelRange.Cells[i,9]).Value.ToString();
				sRowIndex= ((Range)Excel_Utilities.ExcelRange.Cells[i,10]).Value.ToString();
				
				
				bool.TryParse(expectedIsolatorState, out expectedIsolatorCheckboxState);
				
				
				Devices_Functions.AddDevicesfromGallery(sDeviceName,sType);
				//verifyIsolatorCheckbox(expectedIsolatorCheckboxState);
				
				//DC_Functions.verifyDCUnitsValue(expectedDCUnits);
				Devices_Functions.verifyLoadingDetailsValue(expectedDCUnits,DCUnitLoadingDetailName);
				
				//AssignDeviceBase(sLabelName,sBase,sRowIndex);
				
				AssignDeviceBaseForMultipleDevices(sLabelName,sBase,sRowIndex);
				
				Report.Log(ReportLevel.Info, "Base " + sBase + " assigned to "+ sLabelName);
				
				//DC_Functions.verifyDCUnitsValue(expectedDCUnitsAfterBaseChange);
				Devices_Functions.verifyLoadingDetailsValue(expectedDCUnitsAfterBaseChange,DCUnitLoadingDetailName);
				
			}
			//Close Excel sheet
			Excel_Utilities.CloseExcel();
		}

		/********************************************************************
		 * Function Name: VerifyBaseIsVisibleInList
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : Purvi Bhasin - Updated on 28/06/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyBaseIsVisibleInList(string DeviceLabel, string sBaseofDevice, string sBasePropertyRowIndex,bool IsVisible)
		{
			int iRowIndex;
			sBase = sBaseofDevice;
			sRowIndex = sBasePropertyRowIndex;
			sLabelName = DeviceLabel;
			repo.ProfileConsys1.PanelInvetoryGrid.LabelofDevice.Click();
			repo.ProfileConsys1.BaseofDeviceRow.Click();
			repo.ProfileConsys1.BaseofDeviceRow.PressKeys("{Right}");
			int.TryParse(sRowIndex, out iRowIndex);
			iRowIndex = iRowIndex+1;
			sRowIndex = iRowIndex.ToString();
			repo.ProfileConsys1.Cell_BaseofDevice.Click();
			repo.ProfileConsys1.BaseofDeviceRow.MoveTo("760;19");
			repo.ProfileConsys1.BaseofDeviceRow.Click("760;19");
			int.TryParse(sRowIndex, out iRowIndex);
			iRowIndex = iRowIndex-1;
			sRowIndex = iRowIndex.ToString();
			repo.ProfileConsys1.BaseofDeviceRow.MoveTo("760;19");
			repo.ProfileConsys1.BaseofDeviceRow.Click("760;19");
			
		}

		
		/*****************************************************************************************************************
		 * Function Name:verifySwitchingAllowedPowerSource
		 * Function Details: To verify Switching Allowed PowerSource
		 * Parameter/Arguments: filename and sheetname
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 29/03/2019
		 *****************************************************************************************************************/
		[UserCodeMethod]
		public static void verifySwitchingAllowedPowerSource(string sFileName,string sAddDevicesSheet)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			
			// Declared variables type
			string sDeviceName,sType,PanelType,sLabel,sPowerSupply,sChangePowerSupply;
			
			// For loop to iterate on data present in excel
			for(int i=8; i<=rows; i++)
			{
				sDeviceName=  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sLabel=  ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				sPowerSupply = ((Range)Excel_Utilities.ExcelRange.Cells[i,4]).Value.ToString();
				sChangePowerSupply = ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
				
				PanelType= ((Range)Excel_Utilities.ExcelRange.Cells[5,5]).Value.ToString();
				
				AddDevicesfromMainProcessorGallery(sDeviceName,sType,PanelType);
				
				//SelectRowUsingLabelName(sLabel);
				
				SelectRowUsingLabelNameForRBUSOneRow(sLabel);
				
				// To verify power supply value
				VerifyPowerSupply(sPowerSupply);
				
				// To change power supply value
				ChangePowerSupply(sChangePowerSupply);
			}
			Excel_Utilities.CloseExcel();
		}
		
		
		
		
		/********************************************************************
		 * Function Name: VerifyPowerSupply
		 * Function Details: To verify power supply value
		 * Parameter/Arguments: sPowerSupply
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 30/03/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyPowerSupply(string sPowerSupply)
		{
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Power Supply" +"{ENTER}");
			
			// Click on Power Supply cell
			repo.FormMe.cell_PowerSupply.Click();
			
			
			// Get the text value of Device Sensitivity field
			string PowerSupply = repo.FormMe.txt_PowerSupply.TextValue;
			
			//Comparing expected and actual Device Sensitivity value
			if(PowerSupply.Equals(sPowerSupply))
			{
				Report.Log(ReportLevel.Success,"Power supply value " +PowerSupply + " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Power supply value " +PowerSupply+ " is not displayed correctly as"+sPowerSupply);
			}

			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
		}

		

		
		/********************************************************************
		 * Function Name: VerifyPowerSupplyAfterReopenProject
		 * Function Details: To verify power supply value  after Reopening project
		 * Parameter/Arguments: sPowerSupply
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 30/03/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyPowerSupplyAfterReopenProject(string sPowerSupply)
		{
			// Click on SearchProperties text field
			repo.FormMe.txt_SearchProperties_AfterReopen.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Power Supply" +"{ENTER}");
			
			// Click on Power Supply cell
			repo.FormMe.cell_PowerSupply.Click();
			
			
			// Get the text value of Device Sensitivity field
			string PowerSupply = repo.FormMe.txt_PowerSupply.TextValue;
			
			//Comparing expected and actual Device Sensitivity value
			if(PowerSupply.Equals(sPowerSupply))
			{
				Report.Log(ReportLevel.Success,"Power supply value " +PowerSupply + " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Power supply value " +PowerSupply+ " is not displayed correctly");
			}

			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
		}
		
		/********************************************************************
		 * Function Name: ChangePowerSupply
		 * Function Details: To change power supply value
		 * Parameter/Arguments: ChangePowerSupply value
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 30/03/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void ChangePowerSupply(string sChangePowerSupply)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view Power supply related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Power Supply" +"{ENTER}" );
			
			// Click on Power Supply cell
			repo.FormMe.cell_PowerSupply.Click();
			
			// Enter the value to change Power Supply value
			repo.FormMe.txt_PowerSupply.PressKeys((sChangePowerSupply) +"{ENTER}" + "{ENTER}");
			
			// Click on Power Supply cell
			repo.FormMe.cell_PowerSupply.Click();
			
			// Get the text value of Power supply field
			string PowerSupply = repo.FormMe.txt_PowerSupply.TextValue;
			
			Report.Log(ReportLevel.Info,"Power supply value changed to " +PowerSupply+"  "+sChangePowerSupply);
			//Comparing expected and actual power supply value
			if(PowerSupply.Equals(sChangePowerSupply))
			{
				Report.Log(ReportLevel.Success,"Power supply value  changed successfully to " +PowerSupply + " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Power supply value is not changed to " +sChangePowerSupply+ " and displayed incorrectly");
			}

			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");

		}
		
		
		/********************************************************************
		 * Function Name: VerifyErrorMessageFor5V
		 * Function Details: To verify power supply value
		 * Parameter/Arguments: sPowerSupply
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 1/04/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyErrorMessageFor5V(string sPowerSupply, bool sWarningSign)
		{
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Power Supply" +"{ENTER}");
			
			// Click on Power Supply cell
			repo.FormMe.cell_PowerSupply.Click();
			
			
			if(sWarningSign)
			{
				if(repo.FormMe.Error_Symbol_PowerSupplyInfo.Exists())
				{
					Report.Log(ReportLevel.Success,"Error message is displayed ");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Error message is not displayed ");
				}
			}
			else
			{
				if(repo.FormMe.Error_Symbol_PowerSupplyInfo.Exists())
				{
					Report.Log(ReportLevel.Failure,"Error message is displayed ");
				}
				else
				{
					Report.Log(ReportLevel.Success,"Error message is not displayed ");
				}
			}
			
			
		}
		
		/********************************************************************************************************************
		 * Function Name: ChangeLabelName
		 * Function Details: To change Label Name
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update :Alpesh Dhakad - 20/05/2020 Updated script as per new xpath
		 ********************************************************************************************************************/
		[UserCodeMethod]
		public static void ChangeLabelName(string changeLabelName)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Label" +"{ENTER}" );
			
			// Click on Label Name cell
			//repo.ProfileConsys1.cell_LabelName.Click();
			repo.FormMe.cell_LabelNameProperties.Click();
			
			// Enter the value to change Label Name
			//repo.ProfileConsys1.PARTItemsPresenter.txt_changeDeviceSensitivity.PressKeys("{LControlKey down}{Akey}{Delete}{LControlKey up}"+(changeLabelName)+"{ENTER}" + "{ENTER}");
			repo.FormMe.txt_LabelNameProperties.PressKeys("{LControlKey down}{Akey}{Delete}{LControlKey up}"+(changeLabelName)+"{ENTER}" + "{ENTER}");
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			
			
		}
		
		
		/***********************************************************************************************************
		 * Function Name: verifyPointGridProperties
		 * Function Details: To verify points grid properties for a device
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 03/04/2019 Alpesh Dhakad - 20/08/2019 - Updated log text
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyPointGridProperties(string ExpectedPointGridRowCount, string ExpectedPointGridColumn, string ExpectedDeviceProperty)
		{
			// Retrieve Point grid rows and column count
			sColumn = getColumnNumberForPointsGrid(ExpectedPointGridColumn);
			sRow = ExpectedPointGridRowCount;
			
			Report.Log(ReportLevel.Success,"Row and column values are set as " +sRow+ " And " +sColumn+ " respectively");
			
			string ActualPointGridProperty = repo.FormMe.txt_PointGridDeviceProperty.TextValue;
			
			// Compare Actual and Expected Point Grid Row count
			Report.Log(ReportLevel.Success,"Actual "+ActualPointGridProperty+"  Expected "+ExpectedDeviceProperty);
			
			if(ActualPointGridProperty.Equals(ExpectedDeviceProperty))
			{
				Report.Log(ReportLevel.Success,"Device property is verified in Points grid");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device property is not verified not in Points grid");
			}
		}
		
		/******************************************************************************************************************
		 * Function Name: verifyBlankDeviceAddress
		 * Function Details: To verify points grid for blank device address
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 03/04/2019  05/07/2019-Alpesh Dhakad - Updated report log for row & column in readable format
		 *****************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyBlankDeviceAddress(string ExpectedPointGridRowCount, string ExpectedPointGridColumn)
		{
			// Retrieve Point grid rows and column count
			sColumn = getColumnNumberForPointsGrid(ExpectedPointGridColumn);
			sRow = ExpectedPointGridRowCount;
			
			Report.Log(ReportLevel.Success,"Row and column values are set as "+sRow+  "and "+sColumn+ " respectively");
			
			string ActualPointGridProperty = repo.FormMe.txt_PointGridDeviceProperty.TextValue;
			// Compare Actual and Expected Point Grid Row count
			Report.Log(ReportLevel.Success,"Actual "+ActualPointGridProperty);
			
			if(ActualPointGridProperty==null)
			{
				Report.Log(ReportLevel.Success,"Device address is verified in Points grid as blank");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device address is not blank");
			}
			
		}
		
		
		/********************************************************************
		 * Function Name: getColumnNumberForPointsGrid
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static string getColumnNumberForPointsGrid(string columnName)
		{
			string columnNumber="";
			switch (columnName)
			{
				case "SKU":
					columnNumber="1";
					Report.Log(ReportLevel.Success,"Column number is set as "+columnNumber);
					break;
					
				case "Model":
					columnNumber="2";
					Report.Log(ReportLevel.Success,"Column number is set as "+columnNumber);
					break;
					
				case "Label":
					columnNumber="3";
					Report.Log(ReportLevel.Success,"Column number is set as "+columnNumber);
					break;
					
				case "Address":
					columnNumber="4";
					Report.Log(ReportLevel.Success,"Column number is set as "+columnNumber);
					break;
					
				case "Sensitivity":
					columnNumber="5";
					Report.Log(ReportLevel.Success,"Column number is set as "+columnNumber);
					break;
					
				case "Device Order":
					columnNumber="3";
					Report.Log(ReportLevel.Success,"Column number is set as "+columnNumber);
					break;
						
					
			}
			return columnNumber;
			
		}
		
		/***********************************************************************************************************
		 * Function Name: verifyDeviceProperties
		 * Function Details: To verify properties from properties section
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 05/04/2019
		 * Alpesh Dhakad - 20/05/2020 Updated script as per new xpaths
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyDeviceProperties(string sPropertyLabel, string sPropertyValue)
		{
			if(repo.ProfileConsys1.tab_PointsInfo.Exists())
			{
				//Click on Points tab
				Common_Functions.clickOnPointsTab();
			}
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search for the expcted property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys(sPropertyLabel +"{ENTER}" );
			
			// Click on property cell
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			repo.FormMe.cell_LabelNameProperties.Click();
			
			// Retrieve value for the property
			//string actualPropertyValue = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
			string actualPropertyValue = repo.FormMe.txt_LabelNameProperties.TextValue;
			
			// Comparing actual and expected property value
			if(actualPropertyValue.Equals(sPropertyValue))
			{
				Report.Log(ReportLevel.Success,"Property value " +sPropertyValue+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Property value is displayed as "+actualPropertyValue+ " instead of "+ sPropertyValue);
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/***********************************************************************************************************
		 * Function Name: editDeviceLabel
		 * Function Details: To edit device label from properties section
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 05/04/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void editDeviceLabel(string sPropertyLabel, string sNewLabel)
		{
			if(repo.ProfileConsys1.tab_PointsInfo.Exists())
			{
				//Click on Points tab
				Common_Functions.clickOnPointsTab();
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search for the Label property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys(sPropertyLabel +"{ENTER}" );
			
			if(repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceModeInfo.Exists())
			{
				// Click on Label property cell
				repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
				
				//Modifying the label
				repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.PressKeys("{LControlKey down}{Akey}{Delete}{LControlKey up}");
				repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.PressKeys(sNewLabel +"{ENTER}" );
				Report.Log(ReportLevel.Success,"Label is editied to " +sNewLabel);
				
			}
			else
			{
				// Click on label cell
				repo.FormMe.cell_Properties.Click();
				
				//Modifying the label
				repo.FormMe.cell_Properties.PressKeys("{LControlKey down}{Akey}{Delete}{LControlKey up}");
				repo.FormMe.cell_Properties.PressKeys(sNewLabel +"{ENTER}" );
				Report.Log(ReportLevel.Success,"Label is edited to " +sNewLabel);
				
			}
			
			if(repo.ProfileConsys1.tab_PointsInfo.Exists())
			{
				//Click on Points tab
				Common_Functions.clickOnPointsTab();
			}
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name: DeleteAccessoryFromPanelAccessoriesTab
		 * Function Details: To delete Accessory from panel acccessories tab
		 * Parameter/Arguments: sRowNumber, sSkuNumber
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 8/4/2019
		 ********************************************************************/
		
		[UserCodeMethod]
		public static void DeleteAccessoryFromPanelAccessoriesTab()
		{
			repo.FormMe.PanelAccessoriesLabel.Click();
			Report.Log(ReportLevel.Success, "Accessory is Selected");
			Common_Functions.clickOnDeleteButton();
			Report.Log(ReportLevel.Success, "Accessory is deleted");
		}
		
		/********************************************************************
		 * Function Name: PressControlButton
		 * Function Details: To press control button from keyboard
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam kadam
		 * Last Update : 09/4/19
		 ********************************************************************/
		[UserCodeMethod]
		public static void PressControlButton()
		{
			Keyboard.Press("{LControlKey down}");
			Report.Log(ReportLevel.Success, "Control button pressed");
		}
		
		/********************************************************************
		 * Function Name: ReleaseControlButton
		 * Function Details: To release control button from keyboard
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam kadam
		 * Last Update : 09/4/19
		 ********************************************************************/
		[UserCodeMethod]
		public static void ReleaseControlButton()
		{
			Keyboard.Press("{LControlKey up}");
			Report.Log(ReportLevel.Success, "Control button released");
		}
		
		/********************************************************************
		 * Function Name: SelectMultipleDevices
		 * Function Details: To Select multiple devices
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam kadam
		 * Last Update : 10/4/19
		 ********************************************************************/
		[UserCodeMethod]
		public static void SelectMultipleDevices(string strRow)
		{
			PressControlButton();
			SelectPointsGridRow(strRow);
			Keyboard.Press("{LControlKey up}");
			Keyboard.Press("{LControlKey up}");
			Report.Log(ReportLevel.Success, "Control button released");
		}
		
		/********************************************************************
		 * Function Name: VerifyDeviceDisplayedInPhysicalLayout
		 * Function Details: Verify if device is displayed in physical layout at expected position
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam kadam
		 * Last Update : 11/4/19
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceDisplayedInPhysicalLayout(string DeviceIndex, string ExpectedDeviceAddress, string ExpectedDeviceName)
		{
			sPhysicalLayoutDeviceIndex = DeviceIndex;
			sDeviceAddress = ExpectedDeviceAddress;
			repo.FormMe.lst_PhysicalLayoutDevice.Click();
			string ActualDeviceName = repo.FormMe.lst_PhysicalLayoutDevice.TextValue;
			string ActualDeviceAddress=repo.FormMe.txt_PhysicalLayoutDeviceAddress.TextValue;
			Report.Log(ReportLevel.Success,"Expected "+ActualDeviceName + ActualDeviceAddress);
			Report.Log(ReportLevel.Success,"Expected "+ExpectedDeviceName + ExpectedDeviceAddress);
			
			// Compare actualIndex and sPhysicalLayoutDeviceIndex values and then displaying result
			if(ActualDeviceName.Equals(ExpectedDeviceName)&&(ActualDeviceAddress.Equals(ExpectedDeviceAddress)))
			{
				Report.Log(ReportLevel.Success, "Device " +ExpectedDeviceName+ " added successfully and displaying correctly in Physical Layout");
			}
			else
			{
				Report.Log(ReportLevel.Failure, "Device " +ExpectedDeviceName+ " not added or not displaying correctly in Physical Layout");
			}
		}
		
		
		/*****************************************************************************************************************************************
		 * Function Name: ChangeCableCapacitance
		 * Function Details: To change cable capacitance
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 19/04/2019 Alpesh Dhakad - 21/08/2019,08/09/2019 - Updated with new navigation tree method, xpath and devices gallery
		 *****************************************************************************************************************************************/
		// Change cable capacitance method
		[UserCodeMethod]
		public static void ChangeCableCapacitance(int fchangeCableCapacitance, string sLabelName)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			
			SelectRowUsingLabelName(sLabelName);
			
			//Click on cable capacitance cell
			repo.ProfileConsys1.cell_CableCapacitance.Click();
			
			//Change the value of cable length
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+fchangeCableCapacitance + "{Enter}");
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeExpander("Node");
			
			Delay.Duration(1000, false);
		}
		
		/****************************************************************************************************************
		 * Function Name: VerifyCableLength
		 * Function Details: To verify cable length
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/04/2019 Alpesh Dhakad - 01/08/2019 - Updated test scripts as per new build and xpaths
		 * Alpesh Dhakad - 06/08/2019 Updated cable length code
		 * Alpesh Dhakad - 23/08/2019 - Updated with new navigation tree method, xpath
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyCableLength(string sCableLength)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			//Click on cable length cell
			//repo.FormMe.cell_CableLength1.Click();
			//repo.ProfileConsys1.cell_CableLength.Click();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view cable length;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("{LControlKey down}{Akey}{LControlKey up}Length" +"{ENTER}" );
			
			//Click on cable length cell
			repo.FormMe.cell_CableLength.Click();

			string actualCableLength = repo.FormMe.txt_CableLength.TextValue;
			//string actualCableLength = repo.ProfileConsys1.txt_CableLength.TextValue;
			
			
			// Comparing actual and expected value
			if(actualCableLength.Equals(sCableLength))
			{
				Report.Log(ReportLevel.Success,"Cable length value " +sCableLength+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Cable length value is displayed as "+actualCableLength+ " instead of "+ sCableLength);
			}


			
		}
		
		/**********************************************************************************************
		 * Function Name: VerifyCableLengthInNodeGalleryItems
		 * Function Details: To verify cable length
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/04/2019 Alpesh Dhakad - 07/08/2019 - Updated xpath for cell_cableLength
		 * 05/05/2020 - Alpesh Dhakad - Updated script and xpath of cell_CableLength and txt_CableLength
		 **********************************************************************************************/
		[UserCodeMethod]
		public static void VerifyCableLengthInNodeGalleryItems(string sCableLength)
		{
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view cable length;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("{LControlKey down}{Akey}{LControlKey up}Length" +"{ENTER}" );
			
			repo.FormMe.cell_CableLength.Click();
			
			//string actualCableLength = repo.FormMe.txt_InventoryProperty.TextValue;
			string actualCableLength = repo.FormMe.txt_CableLength.TextValue;
			
			// Comparing actual and expected value
			if(actualCableLength.Equals(sCableLength))
			{
				Report.Log(ReportLevel.Success,"Cable length value " +sCableLength+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Cable length value is displayed as "+actualCableLength+ " instead of "+ sCableLength);
			}

			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		
		/**********************************************************************************************************************************
		 * Function Name: verifyMinMaxThroughSpinControlForCableLength
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/04/2019  Alpesh Dhakad - 07/08/2019 - Updated xpath for spin up down button
		 * 05/05/2020 - Alpesh Dhakad - Updated script and xpath of cell_CableLength and txt_CableLength
		 **********************************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyMinMaxThroughSpinControlForCableLength(string minLimit,string maxLimit)
		{
			// Click on Cable Length cell
			repo.FormMe.cell_CableLength.Click();
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+ maxLimit +"{ENTER}");
			
			// Click on Cable Length cell
			repo.FormMe.cell_CableLength.Click();
			
			repo.FormMe.cableLengthSpinUpButton.Click();
			
			//string actualCableLengthValue = repo.FormMe.txt_InventoryProperty.TextValue;
			string actualCableLengthValue = repo.FormMe.txt_CableLength.TextValue;
			
			if(actualCableLengthValue.Equals(maxLimit))
			{
				Report.Log(ReportLevel.Success,"Spin control accepts values within specified max limit");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Spin control does not accepts values within specified max limit");
			}
			Keyboard.Press("{ENTER}");
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+ minLimit +"{ENTER}");
			
			// Click on Cable Length cell
			repo.FormMe.cell_CableLength.Click();
			
			repo.FormMe.cableLengthSpinDownButton.Click();
			
			//actualCableLengthValue =repo.FormMe.txt_InventoryProperty.TextValue;
		    actualCableLengthValue = repo.FormMe.txt_CableLength.TextValue;
			
			if(actualCableLengthValue.Equals(minLimit))
			{
				Report.Log(ReportLevel.Success,"Spin control accepts values within specified min limit");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Spin control does not accepts values within specified min limit");
			}
		}
		
		/********************************************************************
		 * Function Name: SelectNodeInventoryLabel
		 * Function Details: To select points grid row
		 * Parameter/Arguments: sRowNumber
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 25/04/2018
		 ********************************************************************/
		[UserCodeMethod]
		public static void SelectNodeInventoryLabel(string sRowNumber)
		{
			sRow=sRowNumber;
			//Click on row from points grid
			repo.FormMe.NodeInventoryLabel.Click();
		}
		
		/***********************************************************************************************************
		 * Function Name: verifyShoppingListDevicesTextForPxD
		 * Function Details: To verify shopping list devices via clicking on its row
		 * Parameter/Arguments: sFileName,sDeviceSheet
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :  26/04/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyShoppingListDevicesTextForPxD(string sExpectedText)
		{
			
			string actualText = repo.ShoppingListCompatibilityModeE.Cell18.Text;
			
			if(actualText.Equals(sExpectedText))
			{
				Report.Log(ReportLevel.Success,"Model name " +actualText+ " is displayed successfully");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Model name" +sExpectedText+ " is not displayed correctly instead " +actualText+  " is displayed " );
			}
		}
		
		
		/***********************************************************************************************************
		 * Function Name: verifyShoppingListDevicesTextForPSC
		 * Function Details: To verify shopping list devices via clicking on its row
		 * Parameter/Arguments: sFileName,sDeviceSheet
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 26/04/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyShoppingListDevicesTextForPSC(string sExpectedText)
		{
			
			string actualText = repo.ShoppingListCompatibilityModeE.CellF22.Text;
			
			if(actualText.Equals(sExpectedText))
			{
				Report.Log(ReportLevel.Success,"Model name " +actualText+ " is displayed successfully");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Model name" +sExpectedText+ " is not displayed correctly instead " +actualText+  "is displayed " );
			}
		}
		
		
		/***********************************************************************************************************
		 * Function Name: VerifyDeleteButton
		 * Function Details: VerifyDeleteButton state
		 * Parameter/Arguments: IsReadOnly
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 30/04/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyDeleteButton(bool isReadOnly)
		{
			//Common_Functions.changeConfiguratonToUIA();
			
			bool result = repo.FormMe.btn_Delete.Enabled;
			if(result==isReadOnly)
			{
				Report.Log(ReportLevel.Success,"Delete button displaying is as expected");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Delete button displaying is not as expected");
			}
			
			//Common_Functions.changeConfiguratonToWPF();
			
		}
		
		
		/*****************************************************************************************************************
		 * Function Name:  VerifyCurrentDCUnitscalculation
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasim
		 * Last Update : 08/01/2019  Alpesh Dhakad - 30/07/2019 & 30/08/2019 - Updated scripts as per new build and xpaths
		 *****************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyCurrentDCUnitscalculation(string sFileName,string sAddPanelSheet)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddPanelSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			
			// Declared variables
			string ModelNumber,sType,sLabelName,sAssignedBase,expectedDCUnits,DefaultDCUnits,ChangedDCUnit,sPanelLEDCount;
			int PanelLED;
			
			PanelLED=0;
			ChangedDCUnit=string.Empty;
			expectedDCUnits=string.Empty;
			DefaultDCUnits=string.Empty;
			// For loop to iterate on data present in excel
			for(int i=8; i<=rows; i++)
			{
				
				ModelNumber = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sLabelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				sAssignedBase = ((Range)Excel_Utilities.ExcelRange.Cells[i,4]).Value.ToString();
				sRowIndex= ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
				expectedDCUnits = ((Range)Excel_Utilities.ExcelRange.Cells[i,6]).Value.ToString();
				DefaultDCUnits = ((Range)Excel_Utilities.ExcelRange.Cells[i,7]).Value.ToString();
				sPanelLEDCount = ((Range)Excel_Utilities.ExcelRange.Cells[i,8]).Value.ToString();
				ChangedDCUnit = ((Range)Excel_Utilities.ExcelRange.Cells[i,9]).Value.ToString();
				
				int.TryParse(sPanelLEDCount,out PanelLED);
				
				// Click on Expander node
				Common_Functions.ClickOnNavigationTreeExpander("Node");
				
				// Click on Loop Card node
				Common_Functions.ClickOnNavigationTreeExpander("PFI");
				
				// Click on Loop A node
				Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
				
				
				Devices_Functions.AddDevicesfromGallery(ModelNumber,sType);
				
				//Assign Base to the device
				Devices_Functions.AssignDeviceBase(sLabelName,sAssignedBase,sRowIndex);
				

				//Verify Default DC Units
				verifyDCUnitsValue(expectedDCUnits);
				
				// Click on Site node
				Common_Functions.ClickOnNavigationTreeItem("Site");
				
				
			}
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			//go to points grid
			Common_Functions.clickOnPointsTab();
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
			
			//Copy Devices
			repo.FormMe.btn_Copy.Click();
			
			// Click on Loop C node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-C");
			
			//Paste the devices
			Common_Functions.clickOnPasteButton();
			
			//Verify DC Units
			verifyDCUnitsValue(expectedDCUnits);
			
			// Click on Site node
			Common_Functions.ClickOnNavigationTreeItem("Site");
			
			
			// Click on Loop C node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-C");
			
			//go to points grid
			Common_Functions.clickOnPointsTab();
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
			
			//Copy Devices
			Common_Functions.clickOnCutButton();
			
			//Verify Default DC Units
			verifyDCUnitsValue(DefaultDCUnits);
			
			// Click on Site node
			Common_Functions.ClickOnNavigationTreeItem("Site");
			
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			
			Panel_Functions.changePanelLED(PanelLED);
			
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			//Verify Default DC Units
			verifyDCUnitsValue(ChangedDCUnit);

		}
		
		
		/********************************************************************
		 * Function Name: AddMaxNumberOfPanelAccessories(
		 * Function Details: Add devices from panel accessories
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Date: 26/4/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void AddAndVerifyMaxNumberOfPanelAccessories(string sFileName, string sDeviceSheet)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sDeviceSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;

			// Declared string type
			string ModelNumber,sType,Maxnumber;
			
			// For loop to iterate on data present in excel
			for(int i=8; i<=rows; i++)
			{
				ModelNumber = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				Maxnumber = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				
				int MaxNumber = Convert.ToInt32(Maxnumber);
				
				
				for(int j=1; j<=MaxNumber; j++)
				{
					AddDevicefromPanelAccessoriesGallery(ModelNumber,sType);
				}
				
				bool EnabledStatus = false;
				//Verify gallery disabled
				VerifyDeviceIsDisabledOrEnabled(ModelNumber,sType,EnabledStatus);
				
				//Verify slot cards
//				if(MaxNumber>6)
//				{
//					int remainingSlots = MaxNumber-6;
//					string sremainingSlots = remainingSlots.ToString();
//					string expectedText = "Other Slot Cards ("+MaxNumber+" of 18)";
//
//					Common_Functions.ClickOnNavigationTreeItem("Other Slot Cards");
//					//Verify Other slot cards 1
//					string actualSlotText = repo.FormMe.OtherSlotCards_Text.TextValue;
//					if(actualSlotText.Equals(expectedText))
//					{
//						Report.Log(ReportLevel.Success,"Other slot cards are dispayed correctly ");
//					}
//					else
//					{
//						Report.Log(ReportLevel.Success,"Other slot cards are not dispayed correctly ");
//					}
//
//					string expectedText2 = "Other Slot Cards ("+remainingSlots+" of 18)";
//					repo.FormMe.Backplane2_Expander.Click();
//
//					//Verify Other slot cards 2
//					string actualSlotText2 = repo.FormMe.OtherSlotCards2_Text.TextValue;
//
//					if(actualSlotText2.Equals(expectedText2))
//					{
//						Report.Log(ReportLevel.Success,"Other slot cards are dispayed correctly ");
//					}
//					else
//					{
//						Report.Log(ReportLevel.Success,"Other slot cards are not dispayed correctly ");
//					}
//				}
//				else
//				{
//					//Verify other slot cards 1
//					string expectedText = "Other Slot Cards ("+MaxNumber+" of 18)";
//				}
				
				//Delete slot cards from Panel Accessories
				for(int j=1; j<=MaxNumber; j++)
				{
					string labelName= ModelNumber+"-"+j;
					
					//Delete device using label name
					DeleteAccessoryFromPanelAccessoriesTab();
					
					
					if(j==1)
					{
						//Verify Gallery
						EnabledStatus = true;
						//Verify gallery disabled
						VerifyDeviceIsDisabledOrEnabled(ModelNumber,sType,EnabledStatus);
					}
				}
				
				
				
				
				
			}
			
		}
		
		
		/********************************************************************
		 * Function Name: VerifyCustomDeviceDisplayedInCustomGallery
		 * Function Details: Verify if custom device is displayed in custom Gallery
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 16/4/19
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifySounderCustomDeviceDisplayedInCustomGallery(string DeviceName, bool isEnabled)
		{
			//DeleteDevicesPresentInCustomGallery();
			if(isEnabled)
			{
				if(repo.FormMe.Custom_Item_In_Gallery_For_Sounders.Enabled)
				{
					repo.FormMe.Custom_Item_In_Gallery_For_Sounders.Click();
					Report.Log(ReportLevel.Success, "Device " +DeviceName+ " is enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Device " +DeviceName+ " is disabled in gallery");
				}
				
			}
			else
			{
				if(repo.FormMe.Custom_Item_In_Gallery_For_Others.Enabled)
				{
					Report.Log(ReportLevel.Failure, "Device " +DeviceName+ " is enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Device " +DeviceName+ " is disabled in gallery");
				}
			}
		}
		
		/********************************************************************
		 * Function Name: VerifyDeviceIsDisabledOrEnabled
		 * Function Details:Verify device is enabled in panel accessories
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 26/04/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceIsDisabledOrEnabled(string sDeviceName,string sType,bool sEnabled)
		{
			sAccessoriesGalleryIndex= SelectPanelAccessoriesGalleryType(sType);
			ModelNumber=sDeviceName;
			sDeviceIndex = SelectDeviceFromPanelAccessories(ModelNumber);
			repo.FormMe.btn_PanelAccessoriesDropDown.Click();
			
			
			
			if(sEnabled)
			{
				if(repo.ContextMenu.PanelAccessories_Device.Enabled)
				{
					Report.Log(ReportLevel.Success,"Panel Accessories device " + sDeviceName + " is enabled" );
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Panel Accessories device " + sDeviceName + " is not enabled" );
				}
			}
			else
			{
				if(repo.ContextMenu.PanelAccessories_Device.Enabled)
				{
					Report.Log(ReportLevel.Failure,"Panel Accessories device " + sDeviceName + " is not disabled even after reaching max limit " );
				}
				else
				{
					Report.Log(ReportLevel.Success,"Panel Accessories device " + sDeviceName + " is disabled even after reaching max limit " );
				}
			}
			
			
			
		}

		
		
		/********************************************************************************************************************************************
		 * Function Name: VerifyPanelNodePanelAccessoriesGallery
		 * Function Details: To verify day mode field
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 06/05/2019 Alpesh Dhakad - 16/08/2019 - Updated with new navigation tree method, xpath and devices gallery
		 ********************************************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyPanelNodePanelAccessoriesGallery(string sDeviceName,string sType,string state)
		{
			if(state.Equals("Enabled"))
			{
				//sAccessoriesGalleryIndex= SelectPanelAccessoriesGalleryType(sType);
				ModelNumber=sDeviceName;
				//repo.FormMe.btn_PanelAccessoriesDropDown.Click();
				repo.FormMe.btn_AllGalleryDropdown.Click();
				
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + sDeviceName+ " Enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + sDeviceName+ " Disabled in gallery");
				}
			}
			else
			{
				//sAccessoriesGalleryIndex= SelectPanelAccessoriesGalleryType(sType);
				ModelNumber=sDeviceName;
				//repo.FormMe.btn_PanelAccessoriesDropDown.Click();
				repo.FormMe.btn_AllGalleryDropdown.Click();
				
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + sDeviceName+ " enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + sDeviceName+ " disabled in gallery");
				}
			}
			
		}
		
		/********************************************************************
		 * Function Name: SelectPanelNodePanelAccessoriesRow
		 * Function Details: To select item from grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 06/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void SelectPanelNodePanelAccessoriesRow(string RowNumber)
		{
			sRow = RowNumber;
			repo.FormMe.SelectPanelAccessoriesLabel.Click();
			Report.Log(ReportLevel.Success, "Device with Label name selected");
		}
		

		/**************************************************************************************************************************************
		 * Function Name: AddDevicesfromPanelNodeGallery
		 * Function Details: Add devices from panel node gallery
		 * Parameter/Arguments: devicename , device type and panel type
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 10/05/2019  Alpesh Dhakad - 16/08/2019 - Updated with new navigation tree method, xpath and devices gallery
		 **************************************************************************************************************************************/
		[UserCodeMethod]
		public static void AddDevicesfromPanelNodeGallery(string sDeviceName,string sType, string PanelType)
		{
			ModelNumber=sDeviceName;
			repo.FormMe.btn_AllGalleryDropdown.Click();
			repo.FormMe.btn_AllGalleryDropdown.EnsureVisible();
			repo.ContextMenu.txt_SelectDevice.Click();
			Report.Log(ReportLevel.Success, "Device "+sDeviceName+" Added Successfully");

//			sMainProcessorGalleryIndex = SelectMainProcessorGalleryType(sType, PanelType);
//			ModelNumber=sDeviceName;
//			repo.FormMe.btn_PanelNodelGalleryDropDown.Click();
//			repo.ContextMenu.txt_SelectDevice.Click();
//			Report.Log(ReportLevel.Info, "Device "+sDeviceName+" added successfully");
		}
		
		/****************************************************************************************************************
		 * Function Name: VerifyNodeGallery
		 * Function Details: To verify node gallery
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 14/05/2019  Alpesh Dhakad - 02/08/2019 - Updated test scripts as per new build and xpaths
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyNodeGallery(string sDeviceName,string sType,string state,string PanelType)
		{
			if(state.Equals("Enabled"))
			{
				//sAccessoriesGalleryIndex= SelectMainProcessorGalleryType(sType,PanelType);
				ModelNumber=sDeviceName;
				repo.FormMe.btn_AllGalleryDropdown.Click();
				//repo.FormMe.btn_PanelNodelGalleryDropDown.Click();
				
				
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + sDeviceName+ " Enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + sDeviceName+ " Disabled in gallery");
				}
			}
			else
			{
				//sAccessoriesGalleryIndex= SelectMainProcessorGalleryType(sType,PanelType);
				ModelNumber=sDeviceName;
				repo.FormMe.btn_AllGalleryDropdown.Click();
				//repo.FormMe.btn_PanelNodelGalleryDropDown.Click();
				
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + sDeviceName+ " enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + sDeviceName+ " disabled in gallery");
				}
			}
			
		}
		/********************************************************************
		 * Function Name: RightClickOnSelectedGridRow
		 * Function Details: To open the context menu options using right click in grid
		 * Parameter/Arguments: RowNumber
		 * Output:
		 * Function Owner: Poonam
		 * Last Update : 15/5/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void RightClickOnSelectedInventoryGridRow(string RowNumber)
		{
			sRow = RowNumber;
			repo.FormMe.InventoryGridRow.Click(System.Windows.Forms.MouseButtons.Right);
			
		}
		
		/********************************************************************
		 * Function Name: VerifyPanelType
		 * Function Details: To Verify panel type
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 15/05/2019  Alpesh Dhakad - 01/08/2019 - Updated test scripts as per new build and xpaths
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyPanelType(string sFileName,string sAddDevicesSheet, string sPanelName)
		{
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			// Click on Site node
			Common_Functions.ClickOnNavigationTreeItem("Site");
			
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			// Click on Site node
			Common_Functions.ClickOnNavigationTreeItem("Site");
			
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			
			
			Common_Functions.clickOnPanelAccessoriesTab();
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Panel type ext in Search Properties fields to view Panel type text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Panel Type" +"{ENTER}" );
			
			// Click on Panel type cell
			repo.FormMe.cell_NumberOfAlarmLeds.Click();
			
			//Retrieve value of Panel type text and store in PanelType
			string actualPanelName = repo.FormMe.PanelType.TextValue;

			if(actualPanelName.Equals(sPanelName))
			{
				Report.Log(ReportLevel.Success, "Panel name " +actualPanelName+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure, "Panel name is not displayed correctly");
				
			}
			
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			int columns = Excel_Utilities.ExcelRange.Columns.Count;

			
			string PanelTypeName = ((Range)Excel_Utilities.ExcelRange.Cells[10,17]).Value.ToString();
			
			
			VerifyPanelTypeNames(PanelTypeName);
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");

		}
		/*****************************************************************************************************
		 * Function Name: clickContextMenuOptionOnRightClick
		 * Function Details: To verify if paste button is enabled
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam
		 * Last Update : 20/5/2019 Alpesh Dhakad - 29/07/2019 - Updated argument spelling
		 * Alpesh Dhakad - 22/06/2020 Updated script and xpath as per new method of object identification
		 ******************************************************************************************************/
		[UserCodeMethod]
		public static void clickContextMenuOptionOnRightClick(string sContextMenuOption)
		{
			sListIndex=sContextMenuOption;
			
			Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfOnly;
				
			repo.ContextMenu.ContextMenuOption.Click();
				
			Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfImprovedOnly;

			Report.Log(ReportLevel.Success, sContextMenuOption+" button is clicked");
		}
		
		/**************************************************************************************************************
		 * Function Name:verifyContextMenuOptionOnRightClickEnabledOrDisabled
		 * Function Details: To verify if context menu option is enabled or disabled when we right click on grid row
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 20/5/2019  03/07/2019 - Alpesh Dhakad - Updated sContectMenuOptions to sContextMenuOption spelling
		 **************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyContextMenuOptionOnRightClickEnabledOrDisabled(string sContextMenuOption)
		{
			sListIndex=sContextMenuOption;
			if(repo.ContextMenu.ContextMenuOption.Enabled)
			{
				Report.Log(ReportLevel.Success, sContextMenuOption+" button is enabled");
			}
			else{
				Report.Log(ReportLevel.Success, sContextMenuOption+" button is disabled");
			}
		}
		/********************************************************************
		 * Function Name: verifyPasteButtonEnabled
		 * Function Details: To verify if paste button is enabled in ribbon
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam
		 * Last Update : 20/5/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyPasteButtonEnabled()
		{
			if (repo.FormMe.btn_Paste.Enabled)
			{
				Report.Log(ReportLevel.Success, "Paste button is enabled");
			}
			else
			{
				Report.Log(ReportLevel.Failure, "Paste button is disabled");
			}
		}
		
		/********************************************************************
		 * Function Name: VerifyPanelTypeNames
		 * Function Details: To Verify panel type
		 * Parameter/Arguments:PanelTypeNameList
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 16/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyPanelTypeNames(string PanelTypeNameList)
		{
			// Split Paneltype name and then add panels in the collection list
			List<string>  splitPanelTypesNames  = PanelTypeNameList.Split(',').ToList();
			
			foreach(string item in splitPanelTypesNames)
			{
				bool found=false;
				foreach(ListItem listitem in repo.ContextMenu.PanelTypeList.Items)
				{
					if(item == listitem.Text)
					{
						found = true;
						Report.Log(ReportLevel.Success, "Panel name " +listitem.Text+ " is displayed correctly in panel type dropdown list");
						break;
					}
					
				}
				
				if(found == false)
				{
					Report.Log(ReportLevel.Info,"Panel " +item+ " not  found in the list");
					

				}
				
				
			}
			
			
			
		}
		
		
		/********************************************************************
		 * Function Name: verifyPasteButtonDisabled
		 * Function Details: To verify if paste button is disabled in ribbon
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam
		 * Last Update : 20/5/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyPasteButtonDisabled()
		{
			if (repo.FormMe.btn_Paste.Enabled)
			{
				Report.Log(ReportLevel.Failure, "Paste button is enabled");
			}
			else
			{
				Report.Log(ReportLevel.Success, "Paste button is disabled");
			}
		}

		
		/******************************************************************************************************************************************
		 * Function Name: VerifyPanelType
		 * Function Details: To Verify panel type
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 15/05/2019  Alpesh Dhakad - 01/08/2019 & 23/08/2019 - Updated test scripts as per new build and xpaths
		 ******************************************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyPanelTypeInDropdown(string PanelName, string PanelTypeNameList,string PanelTypeNameListNotAvailable)
		{
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			// Click on Site node
			Common_Functions.ClickOnNavigationTreeItem("Site");
			
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			// Click on Site node
			//Common_Functions.ClickOnNavigationTreeItem("Site");
			
			// Click on Panel node
			//Common_Functions.ClickOnNavigationTreeItem("Node");
			
			
			Common_Functions.clickOnPanelAccessoriesTab();
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeItem("Node");
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Panel type ext in Search Properties fields to view Panel type text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Panel Type" +"{ENTER}" );
			
			// Click on Panel type cell
			repo.FormMe.cell_NumberOfAlarmLeds.Click();
			
			//Retrieve value of Panel type text and store in PanelType
			string actualPanelName = repo.FormMe.PanelType.TextValue;

			if(actualPanelName.Equals(PanelName))
			{
				Report.Log(ReportLevel.Success, "Panel name " +actualPanelName+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure, "Panel name is not displayed correctly");
				
			}
			
			VerifyPanelTypeNames(PanelTypeNameList);
			VerifyPanelTypeNamesNotAvailable(PanelTypeNameListNotAvailable);
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");

		}
		
		/********************************************************************
		 * Function Name: VerifyPanelTypeNames
		 * Function Details: To Verify panel type
		 * Parameter/Arguments:PanelTypeNameList
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 16/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyPanelTypeNamesNotAvailable(string PanelTypeNameListNotAvailable)
		{
			// Split Paneltype name and then add panels in the collection list
			List<string>  splitPanelTypesNamesNotAvailable  = PanelTypeNameListNotAvailable.Split(',').ToList();
			
			foreach(string item in splitPanelTypesNamesNotAvailable)
			{
				bool found=true;
				foreach(ListItem listitem in repo.ContextMenu.PanelTypeList.Items)
				{
					if(item == listitem.Text)
					{
						found = false;
						Report.Log(ReportLevel.Failure, "Panel name " +listitem.Text+ " is displayed incorrectly in panel type dropdown list");
						break;
					}
					
				}
				
				if(found == true)
				{
					Report.Log(ReportLevel.Success, "Panel " +item+ " not  found in the list as expected");
					

				}
				
				
			}
			
			
			
		}
		
		/************************************************************************************************************************
		 * Function Name: VerifyEnableDisablePanelAccessoriesGallery
		 * Function Details:
		 * Parameter/Arguments: sType,deviceName,state
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 23/05/2019 Alpesh Dhakad - 20/08/2019 - Updated script as per new build updated xpath
		 ************************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyEnableDisablePanelAccessoriesGallery(string sType,string deviceName, string state)
		{
			if(state.Equals("Enabled"))
			{
				sAccessoriesGalleryIndex= SelectPanelAccessoriesGalleryType(sType);
				ModelNumber=deviceName;
				
				repo.FormMe.btn_AllGalleryDropdown.Click();
				
				//repo.FormMe.btn_PanelAccessoriesDropDown.Click();
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Success, "Accessories : " + deviceName+ " Enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Accessories : " + deviceName+ " Disabled in gallery");
				}
			}
			else
			{
				sAccessoriesGalleryIndex= SelectPanelAccessoriesGalleryType(sType);
				ModelNumber=deviceName;
				
				repo.FormMe.btn_AllGalleryDropdown.Click();
				
				//repo.FormMe.btn_PanelAccessoriesDropDown.Click();
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Failure, "Accessories : " + deviceName+ " enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Accessories: " + deviceName+ " disabled in gallery");
				}
			}
			
		}


		
		/********************************************************************
		 * Function Name: VerifyLabelInSearchProperties
		 * Function Details: To verify label in search properties
		 * Parameter/Arguments:expected Label text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyLabelInSearchProperties(string sLabel)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Label" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Properties.Click();
			
			// Retrieve value of label
			string actualLabel = repo.FormMe.txt_PropertiesTextValue.TextValue;
			
			// Comparing actualLabel and sLabel values
			if(actualLabel.Equals(sLabel))
			{
				Report.Log(ReportLevel.Success,"Label text " +sLabel+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Label text is not displayed as "+actualLabel+ " instead of "+ sLabel);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name: VerifySKUInSearchProperties
		 * Function Details: To verify SKU in search properties
		 * Parameter/Arguments:expected Label text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifySKUInSearchProperties(string sSKU)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("SKU" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Properties.Click();
			
			// Retrieve value of label
			string actualSKUValue = repo.FormMe.txt_PropertiesTextValue.TextValue;
			
			// Comparing actualLabel and sLabel values
			if(actualSKUValue.Equals(sSKU))
			{
				Report.Log(ReportLevel.Success,"Actual SKU value " +actualSKUValue+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Actual SKU Value is displayed as "+actualSKUValue+ " instead of "+ sSKU);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name: VerifyModelInSearchProperties
		 * Function Details: To verify Model in search properties
		 * Parameter/Arguments:expected Model text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyModelInSearchProperties(string sModel)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Model" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Properties.Click();
			
			// Retrieve value of label
			string actualModelText = repo.FormMe.txt_PropertiesTextValue.TextValue;
			
			// Comparing actualModelText and sModel values
			if(actualModelText.Equals(sModel))
			{
				Report.Log(ReportLevel.Success,"Model text " +actualModelText+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Model text is displayed as "+actualModelText+ " instead of "+ sModel);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		
		/********************************************************************
		 * Function Name: VerifyFOMInSearchProperties
		 * Function Details: To verify FOM in search properties
		 * Parameter/Arguments:expected FOM text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyFOMInSearchProperties(string sFOM)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("FOM" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Properties.Click();
			
			// Retrieve value of label
			string actualFOM = repo.FormMe.txt_PropertiesTextValue.TextValue;
			
			// Comparing actualModelText and sModel values
			if(actualFOM.Equals(sFOM))
			{
				Report.Log(ReportLevel.Success,"FOM text " +actualFOM+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"FOM text is displayed as "+actualFOM+ " instead of "+ sFOM);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name: VerifyFOMInSearchProperties
		 * Function Details: To verify FOM in search properties
		 * Parameter/Arguments:expected FOM text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyMPMInSearchProperties()
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("MPM" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Properties.Click();
			
			
			// To retrieve the attribute value as boolean by its ischecked properties and store in actual state
			bool actualState =  repo.FormMe.chkbox_MPM800.GetAttributeValue<bool>("ischecked");
			
			//As per actual state and expected state values verfiying day mode and day sensitivity field state and action performed on checkbox
			if(actualState)
			{
				Report.Log(ReportLevel.Info,"MPM checkbox is available and is checked");
			}
			else
			{
				Report.Log(ReportLevel.Info,"MPM checkbox is available and is not checked");
			}

			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		
		/********************************************************************
		 * Function Name: VerifyDescriptionTextRowInSearchProperties
		 * Function Details: To verify Verify Description Text Row in Search Properties
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 25/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDescriptionTextRowInSearchProperties()
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Description" +"{ENTER}" );
			
			// Click on
			repo.FormMe.txt_PropertiesTextRow.Click();
			
			if(repo.FormMe.txt_PropertiesTextRowInfo.Exists())
			{
				Report.Log(ReportLevel.Success,"Description text row available");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Description text row is not available");
			}
			
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}

		
		/********************************************************************
		 * Function Name: ChangeFOMInSearchProperties
		 * Function Details: To selected FOM in search properties
		 * Parameter/Arguments:expected FOM text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void ChangeFOMInSearchProperties(string changeFOMValue)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("FOM" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_PropertiesFOM.Click();
			
			// Enter the value to change FOM value
			repo.FormMe.txt_PropertiesTextValueFOM.PressKeys((changeFOMValue) +"{ENTER}" + "{ENTER}");
			
			// Click on label cell
			repo.FormMe.cell_PropertiesFOM.Click();
			
			// Retrieve value of label
			string actualFOM = repo.FormMe.txt_PropertiesTextValueFOM.TextValue;
			
			//Comparing expected and actual changed values for FOM
			if(actualFOM.Equals(changeFOMValue))
			{
				Report.Log(ReportLevel.Success,"FOM text changed successfully to  " +actualFOM+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"FOM text is not changed to "+changeFOMValue+ " and displayed incorrectly");
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		
		/********************************************************************
		 * Function Name: CheckUncheckMPMCheckboxInSearchProperties
		 * Function Details: To Check Uncheck MPMCheckbox In SearchProperties
		 * Parameter/Arguments:expected FOM text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 27/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void CheckUncheckMPMCheckboxInSearchProperties(bool ExpectedState)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("MPM" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_PropertiesMPM.Click();

			// To retrieve the attribute value as boolean by its ischecked properties and store in actual state
			bool actualState =  repo.FormMe.chkbox_MPM800.GetAttributeValue<bool>("ischecked");
			
			//As per actual state and expected state values verfiying day mode and day sensitivity field state and action performed on checkbox
			if(actualState.Equals(ExpectedState))
			{
				Report.Log(ReportLevel.Success,"MPM checkbox is displayed as expected");
			}
			else
			{
				// Click on MPM checkbox
				repo.FormMe.chkbox_MPM800.Click();
				Report.Log(ReportLevel.Success,"Action performed on MPM checkbox");
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		
		
		/***********************************************************************************************************
		 * Function Name: verifyShoppingListDevicesTextForThirdDevice
		 * Function Details: To verify shopping list devices via clicking on its row
		 * Parameter/Arguments: sFileName,sDeviceSheet
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 27/05/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyShoppingListDevicesTextForThirdDevice(string sExpectedText)
		{
			
			string actualText = repo.ShoppingListCompatibilityModeE.CellF26.Text;
			
			if(actualText.Equals(sExpectedText))
			{
				Report.Log(ReportLevel.Success,"Model name " +actualText+ " is displayed successfully");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Model name" +sExpectedText+ " is not displayed correctly instead " +actualText+  "is displayed " );
			}
		}
		
		/***********************************************************************************************************
		 * Function Name: verifyShoppingListDevicesTextForCell3And14
		 * 		 * Function Details: To verify shopping list devices via clicking on its row
		 * Parameter/Arguments: sFileName,sDeviceSheet
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 01/06/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyShoppingListDevicesTextForCell3And14(string sExpectedPanelText, string sExpectedDeviceText)
		{
			repo.ShoppingListCompatibilityModeE.CellF3.Click();
			
			string actualPanelText = repo.ShoppingListCompatibilityModeE.CellF3.Text;
			
			if(actualPanelText.Equals(sExpectedPanelText))
			{
				Report.Log(ReportLevel.Success,"Model name " +actualPanelText+ " is displayed successfully");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Model name" +sExpectedPanelText+ " is not displayed correctly instead " +actualPanelText+  "is displayed " );
			}
			
			repo.ShoppingListCompatibilityModeE.CellF14.Click();
			
			string actualDeviceText = repo.ShoppingListCompatibilityModeE.CellF14.Text;
			
			if(actualDeviceText.Equals(sExpectedDeviceText))
			{
				Report.Log(ReportLevel.Success,"Model name " +actualDeviceText+ " is displayed successfully");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Model name" +sExpectedDeviceText+ " is not displayed correctly instead " +actualDeviceText+  "is displayed " );
			}
		}
		
		
		/***********************************************************************************************************
		 * Function Name: verifyShoppingListDevicesTextForCell17And21
		 * 		 * Function Details: To verify shopping list devices via clicking on its row
		 * Parameter/Arguments: sFileName,sDeviceSheet
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 01/06/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyShoppingListDevicesTextForCell17And21(string sExpectedPanelText, string sExpectedDeviceText)
		{
			repo.ShoppingListCompatibilityModeE.CellF17.Click();
			
			string actualPanelText = repo.ShoppingListCompatibilityModeE.CellF17.Text;
			
			if(actualPanelText.Equals(sExpectedPanelText))
			{
				Report.Log(ReportLevel.Success,"Model name " +actualPanelText+ " is displayed successfully");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Model name" +sExpectedPanelText+ " is not displayed correctly instead " +actualPanelText+  "is displayed " );
			}
			
			repo.ShoppingListCompatibilityModeE.CellF21.Click();
			
			string actualDeviceText = repo.ShoppingListCompatibilityModeE.CellF21.Text;
			
			if(actualDeviceText.Equals(sExpectedDeviceText))
			{
				Report.Log(ReportLevel.Success,"Model name " +actualDeviceText+ " is displayed successfully");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Model name" +sExpectedDeviceText+ " is not displayed correctly instead " +actualDeviceText+  "is displayed " );
			}
			
		}
		
		/************************************************************************************************************************
		 * Function Name: AddDevicesfromMultiplePointWizardWithRegion
		 * Function Details: To add multiple devices using multiple point wizard with different loop
		 * Parameter/Arguments: Device name, Region and its quantity
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 23/05/19 Alpesh Dhakad - 19/08/2019 & 27/08/2019 - Updated script for model number selection
		 ************************************************************************************************************************/
		[UserCodeMethod]
		public static void AddDevicesfromMultiplePointWizardWithRegion(string sDeviceName,int DeviceQty, string sRegion )
		{
			repo.FormMe.btn_MultiplePointWizard.Click();
			//repo.ProfileConsys1.btn_MultiplePointWizard_DoNotUse.Click();
			repo.AddDevices.txt_AllDevices.Click();
			
			repo.AddDevices.txt_SearchDevices.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+sDeviceName);
			ModelNumber = sDeviceName;
			//repo.AddDevices.txt_ModelNumber.Click();
			repo.AddDevices.txt_ModelNumber1.Click();
			
			//repo.AddDevices.txt_ModelNumber.Click();
			repo.AddDevices.txt_Quantity.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+DeviceQty.ToString());
			repo.AddDevices.MPWRegionBox.Click();
			repo.AddDevices.MultiPointWizardRegionDropDownBtn.Click();
			sRowIndex=sRegion;
			Report.Log(ReportLevel.Success,"sRowIndex="+sRowIndex);
			repo.ContextMenu.MultiPointWizardRegionComboBox.Click();
			repo.AddDevices.btn_AddDevices.Click();
			Report.Log(ReportLevel.Success,+DeviceQty+" \""+sDeviceName+ "\" Device Added successfully");
			Delay.Milliseconds(200);

		}
		
		
		/********************************************************************
		 * Function Name: VerifySelectedNode
		 * Function Details: To move scroll bar down vertically in points grid
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 23/05/19
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifySelectedNode()
		{
			string stext=repo.FormMe.NavigationTree.SelectedItems.ToString();
			Report.Log(ReportLevel.Success," Device Added successfully"+stext);
		}

		/********************************************************************
		 * Function Name: MoveScrollBarDownInPointsGrid
		 * Function Details: To verify selected node
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 27/05/19
		 ********************************************************************/
		[UserCodeMethod]
		public static void MoveScrollBarDownInPointsGrid()
		{
			// Create a adapter and stored in source adapter element
			//Adapter sourceE = repo.FormMe.UpArrowScrollButtonPointsGrid;//HorizontalScrollBarPointsGrid;
			
			// Create a adapter and stored in targer adapter element
			//Adapter targetE = repo.FormMe.DownArrowScrollButtonPointsGrid;

			// Drag scroll bar from First position to its defined position
			//Ranorex.AutomationHelpers.UserCodeCollections.DragNDropLibrary.DragAndDrop(sourceE,targetE);
			//Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
			//repo.FormMe.HorizontalScrollBarPointsGrid.
			SelectPointsGridRow("1");
			Keyboard.Press("{PageDown}");
			Keyboard.Press("{PageDown}");
			Keyboard.Press("{PageDown}");
			Keyboard.Press("{PageDown}");
			Keyboard.Press("{PageDown}");
			Keyboard.Press("{PageDown}");
		}
		
		/********************************************************************
		 * Function Name:verifyExportButtonInGalleryEnabledOrDisabled
		 * Function Details: To verify if Export button is enabled or disabled in Ribbon
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 03/6/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyExportButtonInGalleryEnabledOrDisabled()
		{
			if(repo.FormMe.Export2ndTime.Enabled)
			{
				Report.Log(ReportLevel.Success, "Export button is enabled");
			}
			else
			{
				Report.Log(ReportLevel.Success,"Export button is disabled");
			}
		}
		
		/********************************************************************
		 * Function Name: VerifyLabelInPanelAccessories
		 * Function Details: To verify label text  in Panel Accessories
		 * Parameter/Arguments:expected Label text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 04/06/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyLabelInPanelAccessories(string sLabel)
		{
			repo.FormMe.PanelAccessoriesLabel.Click();
			
			// Retrieve value of label
			string actualLabel = repo.FormMe.PanelAccessoriesLabel.TextValue;
			
			// Comparing actualLabel and sLabel values
			if(actualLabel.Equals(sLabel))
			{
				Report.Log(ReportLevel.Success,"Label text " +actualLabel+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Label text is displayed as "+actualLabel+ " instead of "+ sLabel);
			}
		}
		
		/*****************************************************************************************************************
		 * Function Name: ChangeCableLengthFromInventory
		 * Function Details: To change cable length from inventory properties section
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update :07/Jun/19 Alpesh Dhakad - 20/08/2019 &  30/08/2019- Updated xpath for cell_cableLength
		 * Alpesh Dhakad - 26/11/2019 Added a step to select cable length text
		 * 05/05/2020 and 22/06/2020 - Alpesh Dhakad - Updated script and xpath of cell_CableLength and txt_CableLength
		 *****************************************************************************************************************/
		// Change cable length method
		[UserCodeMethod]
		public static void ChangeCableLengthFromInventory(int fchangeCableLength)
		{
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view cable length;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Leng" +"{ENTER}" );
			
			//Click on cable length cell
			repo.FormMe.cell_CableLength.Click();
			//repo.FormMe.txt_InventoryProperty.Click();
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
			
			//Change the value of cable length
			repo.FormMe.txt_CableLength.PressKeys(fchangeCableLength + "{ENTER}");
			//repo.FormMe.txt_InventoryProperty.PressKeys(fchangeCableLength + "{ENTER}");
			Report.Log(ReportLevel.Info, "Cable length changed to "+fchangeCableLength+"  successfully");
			
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/**************************************************************************************************************************************
		 * Function Name:verifyContextMenuOptionTextOnRightClickInPointsGrid
		 * Function Details: To verify if context menu option text when we right click on points grid row
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam
		 * Last Update : 14/6/2019 Alpesh Dhakad 30/01/2020 Updated method and xpath for ColumnChooserListsText
		 **************************************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyContextMenuOptionTextOnRightClickInPointsGrid(string sContextMenuOption)
		{
			
			Common_Functions.changeConfiguratonToUIA();
			sGalleryName=sContextMenuOption;
			
			if(repo.ContextMenu.ColumnChooserListsText.Visible)
			{
				Report.Log(ReportLevel.Success, sContextMenuOption+" option is displayed");
			}
			else{
				Report.Log(ReportLevel.Success, sContextMenuOption+" option is not displayed");
			}	
				
			Common_Functions.changeConfiguratonToWPF();
				
//			sListIndex=sContextMenuOption;
//			if(repo.ContextMenu.ColumnChooserListText.Visible)
//			{
//				Report.Log(ReportLevel.Success, sContextMenuOption+" option is displayed");
//			}
//			else{
//				Report.Log(ReportLevel.Success, sContextMenuOption+" option is not displayed");
//			}
		}
		
		
		/***********************************************************************************************************
		 * Function Name: ChangeDeviceSensitivityInPointsGrid
		 * Function Details: To change device sensitivity in points grid
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : Alpesh Dhakad - 27/08/2019 - Updated GridSensitivityCombo1 for change device sensitivity
		 ***********************************************************************************************************/
		// To change device sensitivity value as per the argument
		[UserCodeMethod]
		public static void ChangeDeviceSensitivityInPointsGrid(string changeDeviceSensitivity)
		{
			
			// Click on Device Sensitivity cell
			repo.FormMe.GridSensitivityCombo1.Click();
			
			// Enter the value to change device sensitivity
			repo.FormMe.GridSensitivityCombo1.PressKeys((changeDeviceSensitivity) +"{ENTER}" + "{ENTER}");
			Report.Log(ReportLevel.Info," Device sensitivity changed successfully ");
			
		}
		
		/***********************************************************************************************************
		 * Function Name: AddColumnFromColumnChooser
		 * Function Details: To add Sensitivity column from column chooser
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 18/06/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void AddColumnFromColumnChooser(string sColumnName)
		{
			
			// Select Point grid and right click on it
			Mouse.Click(repo.FormMe.HeadersPanel1, System.Windows.Forms.MouseButtons.Right);
			
			// Click Show column chooser to select column
			repo.ContextMenu.ShowColumnChooser.Click();
			
			// Click on Device order checkbox to add the column in points grid
			repo.ProfileConsys.txt_ColumnChooserSearch.PressKeys((sColumnName) +"{ENTER}" + "{ENTER}");
			repo.ProfileConsys.ColumnChooserSearchCheckbox.Click();
			Report.Log(ReportLevel.Info,sColumnName+" column added successfully ");
			
			// Close column choose window
			repo.ProfileConsys.btn_CloseColumnChooser.Click();
			
		}
		
		/******************************************************************************************************************************************
		 * Function Name: VerifyNodeGalleryforPFI
		 * Function Details: To verify node gallery for pro panels
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 19/06/2019 Alpesh Dhakad - 16/08/2019 - Updated with new navigation tree method, xpath and devices gallery
		 ******************************************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyNodeGalleryForPFI(string sDeviceName,string sType,string state)
		{
			if(state.Equals("Enabled"))
			{
				//sAccessoriesGalleryIndex= SelectMainProcessorGalleryType(sType,"PFI");
				ModelNumber=sDeviceName;
				//repo.FormMe.btn_PanelNodelGalleryDropDown.Click();
				repo.FormMe.btn_AllGalleryDropdown.Click();
				
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + sDeviceName+ " Enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + sDeviceName+ " Disabled in gallery");
				}
			}
			else
			{
				//sAccessoriesGalleryIndex= SelectMainProcessorGalleryType(sType,"PFI");
				ModelNumber=sDeviceName;
				//repo.FormMe.btn_PanelNodelGalleryDropDown.Click();
				repo.FormMe.btn_AllGalleryDropdown.Click();
				
				if (repo.ContextMenu.txt_SelectDevice.Enabled)
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + sDeviceName+ " enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + sDeviceName+ " disabled in gallery");
				}
			}
			repo.ProfileConsys1.txt_SearchProperties.Click();
		}
		
		/********************************************************************************************************************
		 * Function Name: verifyNonDroppedGalleryWithImage
		 * Function Details: To verify non dropped gallery with image and text
		 * Parameter/Arguments:GalleryType, Device1,Device2
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 25/06/2019   26/06/2019 - Alpesh Dhakad - Updated code to execute it
		 *********************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyNonDroppedGalleryWithImage(string GalleryType,string Device1,string Device2)
		{
			string firstGalleryItemText;
			sGalleryIndex = Devices_Functions.SelectGalleryType(GalleryType);
			//string firstGalleryItemText = repo.FormMe.GalleryList.Text;
			Devices_Functions.AddDevicesfromGallery(Device1,GalleryType);
			sDeviceName = Device1;
			firstGalleryItemText = repo.FormMe2.NonDroppedGalleryDeviceName.TextValue;
			if(firstGalleryItemText.Equals(Device1))
			{
				Report.Log(ReportLevel.Success, "Gallery: " + Device1+ " displayed as favourite device");
			}
			
			else
			{
				Report.Log(ReportLevel.Failure, "Gallery: " + Device1+ " not displayed as favourite device");
			}
			
			Devices_Functions.AddDevicesfromGallery(Device2,GalleryType);
			sDeviceName = Device2;
			firstGalleryItemText = repo.FormMe2.NonDroppedGalleryDeviceName.TextValue;
			if(firstGalleryItemText.Equals(Device2))
			{
				Report.Log(ReportLevel.Success, "Gallery: " + Device2+ " displayed as favourite device");
			}
			
			else
			{
				Report.Log(ReportLevel.Failure, "Gallery: " + Device2+ " not displayed as favourite device");
			}
			
			
			//repo.FormMe.GalleryPARTDown.Click();
			sDeviceName = Device2;
			
			if(repo.FormMe2.NonDroppedGalleryDeviceName.EnsureVisible())
			{
				Report.Log(ReportLevel.Success, "Gallery: " + Device1+ " remains as 2nd favourite device");
			}
			
			else
			{
				Report.Log(ReportLevel.Failure, "Gallery: " + Device1+ " not remains as 2nd favourite device");
			}
			
		}
		
		/********************************************************************
		 * Function Name: VerifyBaseVisibilityInList
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update :28/06/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyBaseVisibilityInList(string sBaseofDevice,bool IsVisible)
		{
			sBase = sBaseofDevice;
			if(IsVisible)
			{
				if(repo.ContextMenu.Button_BaseSelectionInfo.Exists())
				{
					Report.Log(ReportLevel.Success,"Base "+ sBase +" exist in list");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Base "+ sBase +" doesn't exist in list");
				}
			}
			else
			{
				if(repo.ContextMenu.Button_BaseSelectionInfo.Exists())
				{
					Report.Log(ReportLevel.Success,"Base "+ sBase +" doesn't exist in list");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Base "+ sBase +" exist in list");
				}
			}
		}


		/********************************************************************
		 * Function Name: VerifyBaseAfterReopening
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 28/06/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyBaseAfterReopening(string DeviceLabel,string sBasePropertyRowIndex,string sBaseName)
		{
			int iRowIndex;
			string sExistingBase;
			sRowIndex = sBasePropertyRowIndex;
			sLabelName = DeviceLabel;
			//repo.ProfileConsys1.PanelInvetoryGrid.LabelofDevice.Click();
			//repo.ProfileConsys1.BaseofDeviceRow.Click();
			//repo.ProfileConsys1.BaseofDeviceRow.PressKeys("{Right}");
			
			
			if(repo.FormMe.txt_LabelNameForOneRowInfo.Exists())
			{
				repo.FormMe.txt_LabelNameForOneRow.Click();
			}
			else
			{
			repo.FormMe.txt_LabelName1.Click();
			}
			repo.FormMe.BaseofDeviceRow.Click();
			repo.FormMe.BaseofDeviceRow.PressKeys("{Right}");
			
			
			
			int.TryParse(sRowIndex, out iRowIndex);
			iRowIndex = iRowIndex+1;
			sRowIndex = iRowIndex.ToString();
			repo.ProfileConsys1.Cell_BaseofDevice_Reopen.Click();
			
			
			sExistingBase = repo.ProfileConsys1.SomeText_Reopen.TextValue;
			
			if(sExistingBase.Equals(sBaseName))
			{
				Report.Log(ReportLevel.Success,"Base value is retained");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Base value is not retained");
			}
		}

		/*************************************************************************************************
		 * Function Name: VerifyDeviceOrderForGalleryExpansionAndContextMenu
		 * Function Details: To verify device order when gallery is expanded
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 24/06/2019 Alpesh Dhakad - 29/07/2019 - Updated script as per new build xpaths
		 * Alpesh Dhakad - 16/08/2019 - Updated with new navigation tree method, xpath and devices gallery
		 *************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceOrderForGalleryExpansion(string sFileName,string sAddDevicesSheet)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;

			// Declared string type
			string sType,DeviceIndex,sDeviceName;
			
			// For loop to iterate on data present in excel
			for(int i=10; i<=rows; i++)
			{
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				DeviceIndex = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				sDeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				
				sGalleryIndex = SelectGalleryType(sType);
				sDeviceIndex = DeviceIndex;
				//ModelNumber = sDeviceName;
				//Click on Expand for gallery
				//repo.FormMe.btn_DevicesGalleryDropDown1.Click();
				//repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
				
				ModelNumber=sDeviceName;

			repo.FormMe.btn_AllGalleryDropdown.Click();
				
				//repo.FormMe.DetectorGalleryDropDown.Click();
				
				string ActualDeviceName = repo.ContextMenu.DeviceOrder_GalleryExpanded.TextValue;
				
				if(ActualDeviceName.Equals(sDeviceName))
				{
					Report.Log(ReportLevel.Success,"Device " +sDeviceName+ " is placed correctly");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Device " +sDeviceName+ " is placed incorrectly");
				}
				
				//Click on Points Tab
				Common_Functions.clickOnPointsTab();
				
			}
			
			//Close Excel Sheet
			Excel_Utilities.CloseExcel();
			
		}
		
		/********************************************************************
		 * Function Name: VerifyDeviceOrderForGalleryExpansionAndContextMenu
		 * Function Details: To verify device order when gallery is expanded
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 24/06/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceOrderForContextMenu(string sFileName,string sAddDevicesSheet)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddDevicesSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;
			// Declared string type
			string sType,DeviceIndex,DeviceName;
			
			// For loop to iterate on data present in excel
			for(int j=2; j<=2; j++)
			{
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[j,1]).Value.ToString();
				
				string RowIndex = "1";
				RightClickOnSelectedRow(RowIndex);
				
			//	Common_Functions.changeConfiguratonToUIA();
				
				sGalleryName = sType;
				repo.ContextMenu.Gallery_In_Context_Menu.Click();

				//Common_Functions.changeConfiguratonToWPF();
				
				for(int i=2; i<=rows; i++)
				{
					DeviceIndex = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
					DeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
					
					sDeviceIndex = DeviceIndex;
					sDeviceName = DeviceName;
					string ActualDeviceName = repo.ContextMenu.DeviceOrder_ContextMenu.TextValue;
					
					if(ActualDeviceName.Equals(sDeviceName))
					{
						Report.Log(ReportLevel.Success,"Device " +sDeviceName+ "is placed correctly");
					}
					else
					{
						Report.Log(ReportLevel.Failure,"Device " +sDeviceName+ "is placed incorrectly");
					}
				}
				
				
			}
			
		}
		
		/***********************************************************************************************************
		 * Function Name: verifyPicture
		 * Function Details: To verify Picture from properties
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 3/07/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyPicture()
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Picture" +"{ENTER}" );
			
			//After this method Validate the image
			
			//After validating delete the Picture word from searvh properties using ErasePictureFromProperties()
			
		}
		
		/***********************************************************************************************************
		 * Function Name: ErasePictureFromProperties
		 * Function Details: To erase Picture from search properties
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 3/07/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void ErasePictureFromProperties()
		{
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");

		}
		
		/********************************************************************
		 * Function Name: VerifyDeviceExists
		 * Function Details: To verify item with label name exists in inventory grid
		 * Parameter/Arguments: sExists, sLabelName
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 8/7/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceExists(bool sExists, string sLabel)
		{
			sLabelName = sLabel;
			
			if(sExists)
			{
				if(repo.FormMe.txt_LabelName1Info.Exists())
				{
					Report.Log(ReportLevel.Success,"Device with label name " +sLabel+ " is displayed correctly");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Device with label name " +sLabel+ " not is displayed correctly");
				}
			}
			else
			{
				if(repo.FormMe.txt_LabelName1Info.Exists())
				{
					Report.Log(ReportLevel.Failure,"Device with label name " +sLabel+ " is getting displayed");
				}
				else
				{
					Report.Log(ReportLevel.Success,"Device with label name " +sLabel+ " is correctly not displayed");
				}
			}
		}
		
		/***********************************************************************************************************************************
		 * Function Name: VerifyProductCodeInSearchProperties
		 * Function Details: To verify SKU in search properties
		 * Parameter/Arguments:expected Label text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019 Alpesh Dhakad - 05/09/2019 - Updated xpath for cell_properties and txt_PropertiesTextValue
		 * Alpesh Dhakad - 10/10/2019 - Updated xpath for txt_SearchPropertiesCellTextValue1
		 ***********************************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyProductCodeInSearchProperties(string sProductLabel)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Product code" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Properties_backplane1.Click();
			
			// Retrieve value of label
			string actualProductLabel = repo.FormMe.txt_SearchPropertiesCellTextValue.TextValue;
			
			// Comparing actualLabel and sLabel values
			if(actualProductLabel.Equals(sProductLabel))
			{
				Report.Log(ReportLevel.Success,"Actual SKU value " +actualProductLabel+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Actual SKU Value is displayed as "+actualProductLabel+ " instead of "+ sProductLabel);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}

		
		/********************************************************************
		 * Function Name: VerifyProductInSearchProperties
		 * Function Details: To verify Product Name in search properties
		 * Parameter/Arguments:expected Label text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyProductInSearchProperties(string sProductName)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Product" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Product.Click();
			
			// Retrieve value of label
			string actualSKUValue = repo.FormMe.txt_Product.TextValue;
			
			// Comparing actualLabel and sLabel values
			if(actualSKUValue.Equals(sProductName))
			{
				Report.Log(ReportLevel.Success,"Actual SKU value " +actualSKUValue+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Actual SKU Value is displayed as "+actualSKUValue+ " instead of "+ sProductName);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/*************************************************************************************************************************************
		 * Function Name: VerifyRegionNameInSearchProperties
		 * Function Details: To verify Product Name in search properties
		 * Parameter/Arguments:expected Label text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2019  Alpesh Dhakad - 05/09/2019 - Updated xpath for cell_properties and txt_PropertiesTextValue
		 *************************************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyRegionNameInSearchProperties(string sRegionName)
		{
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Region Name" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Properties_backplane1.Click();
			
			// Retrieve value of label
			string actualRegionName = repo.FormMe.txt_SearchPropertiesCellTextValue.TextValue;
			
			// Comparing actualLabel and sLabel values
			if(actualRegionName.Equals(sRegionName))
			{
				Report.Log(ReportLevel.Success,"Actual Region Name " +actualRegionName+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Actual Region Name is displayed as "+actualRegionName+ " instead of "+ sRegionName);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/***********************************************************************************************************
		 * Function Name: editRegionName
		 * Function Details: To edit device label from properties section
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Poonam Kadam
		 * Last Update : 05/04/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void editRegionName(string sNewLabel)
		{
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search for the Label property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Region Name" +"{ENTER}" );
			
			
			// Click on label cell
			repo.FormMe.cell_Properties_backplane1.Click();
			
			//Modifying the label
			repo.FormMe.cell_Properties_backplane1.PressKeys("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			repo.FormMe.cell_Properties_backplane1.PressKeys(sNewLabel +"{ENTER}" );
			Report.Log(ReportLevel.Success,"Label is edited to " +sNewLabel);
			
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/***********************************************************************************************************
		 * Function Name: verifyFunctionality
		 * Function Details: To verify Functionality from properties
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 09/07/2019  10/10/2019 - Alpesh Dhakad - Added code to click on label cell
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyFunctionality(string sDescription)
		{
			if(repo.ProfileConsys1.tab_PointsInfo.Exists())
			{
				//Click on Points tab
				Common_Functions.clickOnPointsTab();
			}
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Functionality" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_Properties.Click();
			
			string actualDescription =	repo.FormMe.txt_PropertiesTextValue.TextValue;
			
			// Comparing DayMode and sDayMode values
			if(actualDescription.Equals(sDescription))
			{
				Report.Log(ReportLevel.Success,"Description " +sDescription+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Description is displayed as "+actualDescription+ " instead of "+ sDescription);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name: VerifyCustomDevicesInContextMenu
		 * Function Details: To delete devices from custom gallery
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta
		 * Last Update : 11/4/2019 Updated on 10/07/2019 by Purvi Bhasin
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyCustomDevicesInContextMenu(bool sExist, string sExpectedLabelName)
		{
			repo.ContextMenu.btn_CustomDevice_ContextMenu.Click();
			//Click Points tab
			Common_Functions.clickOnPointsTab();
			sLabelName = sExpectedLabelName;
			if(sExist)
			{

				if(repo.FormMe.txt_LabelName1Info.Exists())
				{
					Report.Log(ReportLevel.Success, "Custom devices are present in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Custom devices are not present in gallery");
				}
			}
			else
			{
				if(repo.FormMe.txt_LabelName1Info.Exists())
				{
					Report.Log(ReportLevel.Failure, "Custom devices are present in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Custom devices are not present in gallery");
				}
				
			}
		}

		/***********************************************************************************************************
		 * Function Name:
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner:
		 * Last Update :
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void testGallery(string sDeviceName)
		{
			ModelNumber=sDeviceName;
			
			repo.FormMe.btn_DevicesGalleryDropDown1.EnsureVisible();
			
			repo.FormMe.btn_DevicesGalleryDropDown1.Click();
			repo.ContextMenu.txt_SelectDevice.Click();
			Report.Log(ReportLevel.Success, "Device "+sDeviceName+" Added Successfully");
			
		}
		
		/********************************************************************
		 * Function Name: AddDevicesfromEthernetGallery
		 * Function Details: Add devices from Ethernet gallery
		 * Parameter/Arguments: devicename , device type and panel type
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void AddDevicesfromEthernetGallery(string sDeviceName,string sType, string PanelType)
		{
			//sMainProcessorGalleryIndex = SelectMainProcessorGalleryType(sType, PanelType);
			ModelNumber=sDeviceName;
			repo.FormMe.btn_AllGalleryDropdown.Click();
			repo.ContextMenu.txt_SelectDevice.Click();
			Report.Log(ReportLevel.Info, "Device "+sDeviceName+" added successfully");
		}
		
		/***********************************************************************************************************
		 * Function Name: editDeviceAddress
		 * Function Details: To edit device address from properties section
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 08/08/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void editDeviceAddress(string sDeviceAddress, string sNewAddress)
		{
			if(repo.ProfileConsys1.tab_PointsInfo.Exists())
			{
				//Click on Points tab
				Common_Functions.clickOnPointsTab();
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		
			
			// Search for the address property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys(sDeviceAddress +"{ENTER}" );
			
			if(repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceModeInfo.Exists())
			{
				// Click on Address property cell
				repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
				
				//Modifying the Address
				repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.PressKeys("{LControlKey down}{Akey}{Delete}{LControlKey up}");
				repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.PressKeys(sNewAddress +"{ENTER}" );
				Report.Log(ReportLevel.Success,"Address is editied to " +sNewAddress);
				
			}
			else
			{
				// Click on label cell
				repo.FormMe.cell_Properties.Click();
				
				//Modifying the label
				repo.FormMe.cell_Properties.PressKeys("{LControlKey down}{Akey}{Delete}{LControlKey up}");
				repo.FormMe.cell_Properties.PressKeys(sNewAddress +"{ENTER}" );
				Report.Log(ReportLevel.Success,"Label is edited to " +sNewAddress);
				
			}
			
			if(repo.ProfileConsys1.tab_PointsInfo.Exists())
			{
				//Click on Points tab
				Common_Functions.clickOnPointsTab();
			}
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/***********************************************************************************************************
		 * Function Name: verifyDevicePresentInShoppingList
		 * Function Details: To verify device is present in shopping list
		 * Parameter/Arguments: sExist, sDeviceName
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 08/08/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyDevicePresentInShoppingList(bool sExist, string sDeviceName )
		{
			string ActualDeviceName;
			int ActualShoppingListDeviceCount = repo.FormMe.ShoppingListContainer.Children.Count();
			Report.Log(ReportLevel.Info,"No of Rows in shopping list are " +ActualShoppingListDeviceCount);
			
			if(sExist)
			{
				for(int i=1;i<=ActualShoppingListDeviceCount;i++)
				{
					sRow = i.ToString();
					ActualDeviceName = repo.FormMe.ShoppingListDevices1.TextValue;
					Report.Log(ReportLevel.Info,"Device Name is displayed as " +ActualDeviceName);
					
					if(ActualDeviceName.Equals(sDeviceName))
					{
						Report.Log(ReportLevel.Success,"Device is successfully displayed in shopping list as " +sDeviceName);
					}
					else
					{
						Report.Log(ReportLevel.Failure,"Device is not displayed in shopping list as " +sDeviceName);
					}
				}
			}
			else
			{
				for(int i=1;i<=ActualShoppingListDeviceCount;i++)
				{
					sRow = i.ToString();
					ActualDeviceName = repo.FormMe.ShoppingListDevices1.TextValue;
					Report.Log(ReportLevel.Info,"Device Name is displayed as " +ActualDeviceName);
					
					if(ActualDeviceName.Equals(sDeviceName))
					{
						Report.Log(ReportLevel.Failure,"Device is displayed in shopping list as " +sDeviceName);
					}
					else
					{
						Report.Log(ReportLevel.Success,"Device is not displayed in shopping list as " +sDeviceName);
					}
				}
			}
			
			
			
		}
		
		/*********************************************************************************************************
		 * Function Name: VerifyPropertyInSearchPropertiesInSecondLine
		 * Function Details: To verify Product Name in search properties when product code is present
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 09/08/2019 Alpesh Dhakad - 08/11/2019 Updated Xpath for txt_PropertiesTextValue_2ndLine
		 *********************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyPropertyInSearchPropertiesInSecondLine(string sPropertyName,string sProductName)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Product" +"{ENTER}" );
			
			// Click on label cell
			repo.FormMe.cell_PropertiesTextValue_2ndLine.Click();
			
			// Retrieve value of label
			string actualSKUValue = repo.FormMe.txt_PropertiesTextValue_2ndLine.TextValue;
			
			// Comparing actualLabel and sLabel values
			if(actualSKUValue.Equals(sProductName))
			{
				Report.Log(ReportLevel.Success,"Actual SKU value " +actualSKUValue+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Actual SKU Value is displayed as "+actualSKUValue+ " instead of "+ sProductName);
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		
		/****************************************************************************************************************************
		 * Function Name: VerifyErrorMessageWhenAddingMaxDevicesInMultiplePointWizard
		 * Function Details: To add multiple devices using multiple point wizard till max limit
		 * Parameter/Arguments: Device name and its quantity
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 19/08/2019
		 ****************************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyErrorMessageWhenAddingMaxDevicesInMultiplePointWizard(string sDeviceName,int DeviceQty,int MaxLimit)
		{
			repo.FormMe.btn_MultiplePointWizard.Click();
			//repo.ProfileConsys1.btn_MultiplePointWizard_DoNotUse.Click();
			repo.AddDevices.txt_AllDevices.Click();
			
			repo.AddDevices.txt_SearchDevices.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+sDeviceName);
			ModelNumber = sDeviceName;
			repo.AddDevices.txt_ModelNumber1.Click();
//			repo.AddDevices.txt_ModelNumber.Click();
			repo.AddDevices.txt_Quantity.Click();
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+DeviceQty.ToString());
			
			if(DeviceQty > MaxLimit)
			{
				repo.AddDevices.btn_AddDevices.Click();
				
				if(repo.AddDevices.MultiplePointWizardWarningSign.Visible)
				{
					Report.Log(ReportLevel.Success,"Error Symbol appears as expected");
					repo.AddDevices.Cancel_Multiple_Point_Wizard_DialogWindow.Click();
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Error Symbol doesn't appear");
					repo.AddDevices.Cancel_Multiple_Point_Wizard_DialogWindow.Click();
				}
			}
			else
			{
				repo.AddDevices.btn_AddDevices.Click();
				Report.Log(ReportLevel.Success,+DeviceQty+" \""+sDeviceName+ "\" Device Added successfully");
			}
			
			Delay.Milliseconds(200);

		}
		
		/***********************************************************************************************************
		 * Function Name: verifyExcelCellValue
		 * Function Details: To verify shopping list values via clicking on the cell of the Excell
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 20/08/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyExcelCellValue(string RowIndex,string Address,string sExpectedText)
		{
			Delay.Milliseconds(200);
			sRowIndex = RowIndex;
			sColumn = Address;
			//sColumn is the actual address of the excel eg- H8,A1 etc.
			//repo.ShoppingListCompatibilityModeE.AddressBox_Excel.Click();
			//Keyboard.Press(sCellAddress+"{ENTER}");
			repo.ShoppingListCompatibilityModeE.cell_ExcelCellAddress.DoubleClick();
			string actualText = repo.ShoppingListCompatibilityModeE.cell_ExcelCellAddress.Text;
			Report.Log(ReportLevel.Info,"Actual text is displayed as "+actualText);
			if(actualText.Equals(sExpectedText))
			{
				Report.Log(ReportLevel.Success, "The value " +actualText+ " is displayed successfully");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"The value " +sExpectedText+ " is not displayed correctly instead " +actualText+  "is displayed " );
			}
		}
		
		/****************************************************************************************************
		 * Function Name: AddDevicesFromGalleryUsingIndex
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 22/08/2019
		 ****************************************************************************************************/
		[UserCodeMethod]
		public static void AddDevicesFromGalleryUsingIndex(string sDeviceName,string sType)
		{
			ModelNumber=sDeviceName;

			//sGalleryIndex = SelectGalleryType(sType);
			
			repo.FormMe.btn_AllGalleryDropdown.Click();
			repo.FormMe.btn_AllGalleryDropdown.EnsureVisible();
			//repo.FormMe.btn_DevicesGalleryDropDown1.Click();
			
			//repo.FormMe.btn_DevicesGalleryDropDown1.EnsureVisible();
			
			repo.ContextMenu.txt_SelectDevice.Click();
			
			
//			sGalleryIndex = SelectGalleryType(sType);
//			ModelNumber=sDeviceName;
//			repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
//			repo.ContextMenu.txt_SelectDevice.Click();
			Report.Log(ReportLevel.Success, "Device "+sDeviceName+" Added Successfully");
		}
		
		/**************************************************************************************************
		 * Function Name:ClickCheckboxInSearchProperties
		 * Function Details:
		 * Parameter/Arguments: boolean value
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 22/08/2019 Alpesh Dhakad - 22/06/2020 - Updated last line of script
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void ClickCheckboxInSearchProperties(string sCheckboxName)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys(sCheckboxName +"{ENTER}" );

			// Click on cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DayMatchesNight.Click();
			//repo.FormMe.Chkbox_In_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			
		}
		
		/********************************************************************
		 * Function Name:verifyCheckboxInSearchProperties
		 * Function Details:
		 * Parameter/Arguments: boolean value
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 22/08/2019
		 * Alpesh Dhakad - 14/05/2020 Updated xpath as per new build
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyCheckboxInSearchProperties(string sCheckboxName, bool ExpectedState)
		{
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys(sCheckboxName +"{ENTER}" );

			// Click on Isolator  cell
			
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DayMatchesNight.Click();
			repo.FormMe.cell_SearchPropertiesFirstRowDrpDwn.Click();

			//Click on row
			//repo.ProfileConsys1.PARTItemsPresenter.row_SearchProperties.Click();
			
			// To retrieve the attribute value as boolean by its ischecked properties and store in actual state
			//bool actualState =  repo.ProfileConsys1.chkbox_Isolator.GetAttributeValue<bool>("ischecked");
			
			bool actualState =  repo.FormMe.chkbox_Isolator.GetAttributeValue<bool>("ischecked");
			
			
			//As per actual state and expected state values
			if(actualState.Equals(ExpectedState))
			{
				Report.Log(ReportLevel.Success, "Device is displayed as expected ");
			}
			else
			{
				Report.Log(ReportLevel.Failure, "Device is not displayed as expected ");
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			
		}
		
		/* bool DefaultChecked,  //Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys(sCheckboxName +"{ENTER}" );

			// Click on cell
			repo.ProfileConsys1.PARTItemsPresenter.row_SearchProperties.Click();
			
			
			// To retrieve the attribute value as boolean by its ischecked properties and store in actual state
			bool actualState =   repo.ProfileConsys1.chkbox_Isolator.GetAttributeValue<bool>("ischecked");
			
			if(DefaultChecked)
			{
				if(actualState.Equals(ExpectedState))
				{
					Report.Log(ReportLevel.Success, "Checkbox is checked");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Checkbox is not checked");
				}
			}
			else
			{
				if(actualState.Equals(ExpectedState))
				{
					Report.Log(ReportLevel.Failure, "Checkbox is checked");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Checkbox is not checked");
				}
			}
			
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}*/
		
		/********************************************************************
		 * Function Name:VerifyCheckboxExists
		 * Function Details:
		 * Parameter/Arguments: boolean value
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 22/08/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyCheckboxExists(string sCheckboxName, bool isExists)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys(sCheckboxName +"{ENTER}" );
			
			if(isExists)
			{
				if(repo.FormMe.Chkbox_In_SearchPropertiesInfo.Exists())
				{
					Report.Log(ReportLevel.Success, "Checkbox is present");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Checkbox is absent");
				}
			}
			else
			{
				if(repo.FormMe.Chkbox_In_SearchPropertiesInfo.Exists())
				{
					Report.Log(ReportLevel.Failure, "Checkbox is present");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Checkbox is absent");
				}
			}

		}
		
		
		/********************************************************************
		 * Function Name:ChangeParameterInSearchProperties
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 23/08/2019
		 * Alpesh Dhakad - 14/05/2020  Updated xpath as per new implentation
		 ********************************************************************/
		[UserCodeMethod]
		public static void ChangeParameterInSearchProperties(string sProperty, string sParameterValue)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view day matches night related text;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys(sProperty +"{ENTER}" );
			
			// Click on Isolator  cell
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DayMatchesNight.Click();
			repo.FormMe.cell_Properties.Click();
			
			//Enter the required option
			Keyboard.Press(sParameterValue+"{Enter}");
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");

			
		}
		
		/********************************************************************
		 * Function Name:VerifyProgressBarColour
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 09/09/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyProgressBarColour(string Row, string ExpectedColour)
		{
			sRowIndex = Row;
			string ActualColour = getProgressBarColorForISUnits();
			Devices_Functions.VerifyPercentage(ExpectedColour, ActualColour);
			
		}
		
		/****************************************************************************************************************
		 * Function Name: AssignDeviceBaseIfBlank
		 * Function Details: assign a base to device if base is blank by default
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 10/09/2019 Alpesh Dhakad - 19/06/2020 Updated new base change implementation
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void AssignDeviceBaseIfBlank(string DeviceLabel, string sBaseofDevice, string sBasePropertyRowIndex)
		{
			//int iRowIndex;
			sBase = sBaseofDevice;
			sRowIndex = sBasePropertyRowIndex;
			sLabelName = DeviceLabel;
			//repo.ProfileConsys1.PanelInvetoryGrid.LabelofDevice.Click();
			//repo.ProfileConsys1.BaseofDeviceRow.MoveTo("760;19");
			//repo.ProfileConsys1.BaseofDeviceRow.Click("760;19");
			//int.TryParse(sRowIndex, out iRowIndex);
			//iRowIndex = iRowIndex-1;
			//sRowIndex = iRowIndex.ToString();
			//repo.ProfileConsys1.BaseofDeviceRow.MoveTo("760;19");
			//repo.ProfileConsys1.BaseofDeviceRow.Click("760;19");
			
			if(repo.FormMe.txt_LabelNameForOneRowInfo.Exists())
			{
				repo.FormMe.txt_LabelNameForOneRow.Click();
			}
			else
			{
			repo.FormMe.txt_LabelName1.Click();
			}
			
			repo.FormMe.BaseofDeviceRow.MoveTo("560;19");
				repo.FormMe.BaseofDeviceRow.Click("560;19");
			
			Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfOnly;
				
				repo.ContextMenu.btn_BaseSelection.Click();
				
				Ranorex.Plugin.WpfConfiguration.WpfApplicationTrees = Ranorex.Plugin.WpfTreeSelection.WpfImprovedOnly;
				
				Report.Log(ReportLevel.Info, "Base change was performed successfully.");
			
		}
		
		/****************************************************************************************************************
		 * Function Name: VerifyValueOfParameterInPhysicalLayoutOnReopen
		 * Function Details: Verify value of AC/DC/Battery/Alarm etc in Physical layout On Reopen
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 10/09/2019
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyValueOfParameterInPhysicalLayoutOnReopen(string Row, string expectedValue)
		{
			sRow=Row;
			Common_Functions.clickOnPhysicalLayoutTab();
			string ActualValue = repo.ProfileConsys1.PhysicalLayout_ParameterValue_reopen.TextValue;
			
			
			if(ActualValue.Equals(expectedValue))
			{
				Report.Log(ReportLevel.Success,"AC Units " + ActualValue + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"AC Units are not displayed correctly " + ", Expected AC Units:  " + expectedValue  + " Actual AC Units: "+ ActualValue);
			}
			Common_Functions.clickOnPointsTab();
		}
		
		/**************************************************************************************************************
		 * Function Name: VerifyValueOfParameterInPhysicalLayout
		 * Function Details: Verify value of AC/DC/Battery/Alarm etc in Physical layout
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 11/09/2019
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyValueOfParameterInPhysicalLayout(string Row, string expectedValue)
		{
			sRow=Row;
			Common_Functions.clickOnPhysicalLayoutTab();
			string ActualValue = repo.FormMe.txt_Parameter.TextValue;
			
			
			if(ActualValue.Equals(expectedValue))
			{
				Report.Log(ReportLevel.Success,"AC Units " + ActualValue + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"AC Units are not displayed correctly " + ", Expected AC Units:  " + expectedValue  + " Actual AC Units: "+ ActualValue);
			}
			Common_Functions.clickOnPointsTab();
		}
		
		/************************************************************************************************************
		 * Function Name: VerifyDeviceSensitivityListValues
		 * Function Details: To verify device sensitivity value
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 13/09/2019 - Not used as text value is not retrieved (properties) in dropdown
		 ************************************************************************************************************/
		// To verify device sensitivity value as per the argument
		[UserCodeMethod]
		public static void VerifyDeviceSensitivityListValues(string DeviceSensitivityList)
		{
			// Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}");
			
			// Click on Device Sensitivity cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceSensitivity.Click();
			
			VerifyPanelTypeNames(DeviceSensitivityList);
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			
		}
		
		
		
		/**************************************************************************************************************
		 * Function Name: DragAndDropDevicesInPhysicalLayout
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 11/09/2019
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void DragAndDropDevicesInPhysicalLayout(string SourceDeviceIndex, string DestinationDeviceIndex)
		{
			Common_Functions.clickOnPhysicalLayoutTab();
			Common_Functions.clickOnPointsTab();
			Common_Functions.clickOnPhysicalLayoutTab();
			sPhysicalLayoutDeviceIndex = SourceDeviceIndex;
			
			// Create a adapter and stored in source adapter element
			Adapter sourceElement = repo.FormMe.PhysicalLayout_DeviceAddress;
			
			sPhysicalLayoutDeviceIndex = DestinationDeviceIndex;
			
			// Create a adapter and stored in targer adapter element
			Adapter targetElement = repo.FormMe.PhysicalLayout_DeviceAddress;

			// Drag and drop IS device from Second EXI to First EXI
			Ranorex.AutomationHelpers.UserCodeCollections.DragNDropLibrary.DragAndDrop(sourceElement,targetElement);
		}
		
		/********************************************************************
		 * Function Name:AddMultipleDevicesInMultipoint
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Purvi Bhasin
		 * Last Update : 13/09/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void AddMultipleDevicesInMultipoint(string sFileName,string sSheetName)
		{
			
			Excel_Utilities.OpenExcelFile(sFileName,sSheetName);
			//Excel_Utilities.OpenSheet(sSheetName);
			int rows = Excel_Utilities.ExcelRange.Rows.Count;
			
			
			for(int i=2;i<=rows;i++)
			{
				string sDeviceName = ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				string DeviceQty = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				
				repo.AddDevices.txt_SearchDevices.Click();
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+sDeviceName);
				ModelNumber = sDeviceName;
				repo.AddDevices.txt_ModelNumber1.Click();
//			repo.AddDevices.txt_ModelNumber.Click();
				repo.AddDevices.txt_Quantity.Click();
				Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+DeviceQty.ToString());
				
			}
			
			repo.AddDevices.btn_AddDevices.Click();
		}
		
		/********************************************************************
		 * Function Name: VerifyDeviceVisibility
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :17/10/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceVisibility(string sDeviceName,bool IsVisible)
		{
			ModelNumber=sDeviceName;
			
			if(IsVisible)
			{
				if(repo.FormMe.btn_AllGalleryDropdownInfo.Exists())
				{
					Report.Log(ReportLevel.Success,"Device "+ sDeviceName +" exist in device gallery");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Device "+ sDeviceName +" doesn't in device gallery");
				}
			}
			else
			{
				if(repo.FormMe.btn_AllGalleryDropdownInfo.Exists())
				{
					Report.Log(ReportLevel.Failure,"Device "+ sDeviceName +" exist in device gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success,"Device "+ sDeviceName +" doesn't exist in device gallery");
				}
			}
		}

		/***************************************************************************************************************
		 * Function Name: verifyDIPSwitches
		 * Function Details: To verify DIP Switches from Search properties
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 18/10/2019
		 ***************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyDIPSwitches()
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Dip" +"{ENTER}" );
			
			if(repo.FormMe.txt_PropertiesDescriptionRowInfo.Exists())
			{
				Report.Log(ReportLevel.Failure,"DIP Switches  is displayed which is not expected");
			}
			else
			{
				Report.Log(ReportLevel.Success,"Description is not displayed which is as expected");
			}
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name:
		 * Function Details: To verify Verify Description Text Row in Search Properties
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 04/11/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyProductCodeTextRowInSearchProperties()
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Label properties
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Product code" +"{ENTER}" );
			
			// Click on
			repo.FormMe.txt_PropertiesTextRow.Click();
			
			if(repo.FormMe.txt_PropertiesTextRowInfo.Exists())
			{
				Report.Log(ReportLevel.Success,"ProductCode text row available");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"ProductCode text row is not available");
			}
			
			
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/*************************************************************************************************************************
		 * Function Name: verifyLoadingDetailsValue
		 * Function Details: To verify actual loading details value of searched detail unit
		 * Parameter/Arguments: expectedUnits and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 25/11/2019 
		 * Alpesh Dhakad - 28/12/2020 Updated as per object identification by adding new xpath by adding preceding method
		 **************************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyLoadingDetailsValue(string expectedUnits, string LoadingDetail)
		{
			//Common_Functions.clickOnPhysicalLayoutTab();
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_ActualLoadingDetailsValueInfo.Exists())
			{
			
			string LoadingUnits = repo.FormMe.txt_ActualLoadingDetailsValue.TextValue;
			
			if(LoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoadingUnits);
			}
			
			}
			else
			{
			string LoadingUnits = repo.FormMe.txt_ActualLoadingDetailsValuePreceding.TextValue;
			
			if(LoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoadingUnits);
			}
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
		}
		
		/*************************************************************************************************************************
		 * Function Name: verifyMaxLoadingDetailsValue
		 * Function Details: To verify max loading details value of searched detail unit
		 * Parameter/Arguments: expectedMaxUnits and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 25/11/2019
		 * Alpesh Dhakad - 28/12/2020 Updated as per object identification by adding new xpath by adding preceding method
		 *************************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyMaxLoadingDetailsValue(string expectedMaxUnits, string LoadingDetail)
		{
			//Common_Functions.clickOnPhysicalLayoutTab();
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_MaxLoadingDetailsValueInfo.Exists())
			{
			
			string MaxLoadingUnits = repo.FormMe.txt_MaxLoadingDetailsValue.TextValue;
			
			if(MaxLoadingUnits.Equals(expectedMaxUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedMaxUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedMaxUnits  + " Actual Units: "+ MaxLoadingUnits);
			}
			
			}
			else
			{
			string MaxLoadingUnits = repo.FormMe.txt_MaxLoadingDetailsValuePreceding.TextValue;
			
			if(MaxLoadingUnits.Equals(expectedMaxUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedMaxUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedMaxUnits  + " Actual Units: "+ MaxLoadingUnits);
			}
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			
			
		}
		
		/********************************************************************
		 * Function Name: getProgressBarColors
		 * Function Details: Method to verify progress bar color 
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 29/11/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static string getProgressBarColors(string LoadingDetail)
		{
			Common_Functions.clickOnPhysicalLayoutTab();
			sLoadingDetail = LoadingDetail;
			
			string actualColour;
			return actualColour = repo.FormMe.LoadingDetailsProgressbarColor.GetAttributeValue<string>("foreground");
			
		}
		
		
		/********************************************************************
		 * Function Name: verifyLoadingDetailColor
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 05/12/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyLoadingDetailColor(string LoadingDetail)
		{
			string expectedColor;
			sLoadingDetail = LoadingDetail;
			
			//Go to Physical layout
			Common_Functions.clickOnPhysicalLayoutTab();
			Delay.Duration(500, false);
			
			
			float ActualLoadingUnits = float.Parse(repo.FormMe.txt_ActualLoadingDetailsValue.TextValue);
			
			string actualColour = repo.FormMe.LoadingDetailsProgressbarColor.GetAttributeValue<string>("foreground");
			
			//Fetch max volt drop text value and storing it in string
			float MaxLoadingUnits = float.Parse(repo.FormMe.txt_MaxLoadingDetailsValue.TextValue);
			
			
			expectedColor = Devices_Functions.calculatePercentage(ActualLoadingUnits, MaxLoadingUnits);
			
			Devices_Functions.VerifyPercentage(expectedColor, actualColour);
		}
		
		/**************************************************************************************
		 * Function Name: verifyLoadingDetailsValueAfterReopen
		 * Function Details: To verify actual loading details value of searched detail unit
		 * Parameter/Arguments: expectedUnits and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 11/12/2019
		 * Alpesh Dhakad - 18/01/2021 Updated script as per new UI implementation
		 **************************************************************************************/
		[UserCodeMethod]
		public static void verifyLoadingDetailsValueAfterReopen(string expectedUnits, string LoadingDetail)
		{
			Common_Functions.clickOnPhysicalLayoutTab();
			sLoadingDetail = LoadingDetail;

			if(repo.FormMe.txt_ActualLoadingDetailsValueAfterReopenInfo.Exists())
			{
			
			string LoadingUnits = repo.FormMe.txt_ActualLoadingDetailsValueAfterReopen.TextValue;
			
			if(LoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoadingUnits);
			}
			
			}
			else
			{
			string LoadingUnits = repo.FormMe.txt_ActualLoadingDetailsValueAfterReopenPreceding.TextValue;
			
			if(LoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoadingUnits);
			}
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
		
		}
		
		/**************************************************************************************
		 * Function Name: verifyMaxLoadingDetailsValueAfterReopen
		 * Function Details: To verify max loading details value of searched detail unit
		 * Parameter/Arguments: expectedMaxUnits and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 11/12/2019
		 * Alpesh Dhakad - 18/01/2021 Updated script as per new UI implementation
		 **************************************************************************************/
		[UserCodeMethod]
		public static void verifyMaxLoadingDetailsValueAfterReopen(string expectedMaxUnits, string LoadingDetail)
		{
			Common_Functions.clickOnPhysicalLayoutTab();
		
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_MaxLoadingDetailsValueAfterReopenInfo.Exists())
			{
			
			string MaxLoadingUnits = repo.FormMe.txt_MaxLoadingDetailsValueAfterReopen.TextValue;
			
			if(MaxLoadingUnits.Equals(expectedMaxUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedMaxUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedMaxUnits  + " Actual Units: "+ MaxLoadingUnits);
			}
			
			}
			else
			{
			string MaxLoadingUnits = repo.FormMe.txt_MaxLoadingDetailsValueAfterReopenPreceding.TextValue;
			
			if(MaxLoadingUnits.Equals(expectedMaxUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedMaxUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedMaxUnits  + " Actual Units: "+ MaxLoadingUnits);
			}
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
		}
		
		/**************************************************************************************
		 * Function Name: EnableISDevices
		 * Function Details: 
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 27/12/2019
		 * Alpesh Dhakad - 14/05/2020 Updated as per new implementation
		 * Alpesh Dhakad - 04/02/2021 Updated script as per new Devexpress upgrade
		 **************************************************************************************/
		[UserCodeMethod]
		public static void EnableISDevices()
		{
			
			repo.FormMe.File.Click();
			
			repo.FormMe.Options.Click();
			
			repo.FormMe.chkBox_EnableISDevices.Click();
			
			repo.FormEnableISDevices.chkBox_EnableChkbox.Click();
			
			repo.FormEnableISDevices.btn_Ok_Warning.Click();
			
			//repo.FormMe.btn_back.Click();
			
			repo.FormMe.btn_Close.Click();
			
			repo.SaveConfirmationWindow.btn_Cancel.Click();
			
			Report.Log(ReportLevel.Info, "IS Devices Enabled successfully");
			
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelName
		 * Function Details: To select item from grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 10/02/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameOnReopen(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelName1Reopen.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		/**************************************************************************************************
		 * Function Name: VerifyDeviceModeAfterReopenProj
		 * Function Details:
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 13/02/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceModeAfterReopenProj(string sDeviceMode)
        {
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}" );
			
			// Click on Device Mode cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			// Get the text value of changed Device Mode field
			string DeviceMode = repo.FormMe.DeviceModeAfterReopen.TextValue;
			
			//Comparing expected and actual changed Device Mode value
			if(DeviceMode.Equals(sDeviceMode))
			{
				Report.Log(ReportLevel.Success,"Device mode " +DeviceMode+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device mode is not displayed correctly");
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }

		/**************************************************************************************************
		 * Function Name: VerifyDeviceSensitivityAfterReopen
		 * Function Details: 
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 13/02/2020
		 **************************************************************************************************/
		[UserCodeMethod]
        public static void VerifyDeviceSensitivityAfterReopenProj(string sDeviceSensitivity)
        {
			// Click on Points tab
			Common_Functions.clickOnPointsTab();
				
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Device text in Search Properties fields to view device related text
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Device" +"{ENTER}");
			
			// Click on Device Sensitivity cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceSensitivity.Click();
			
			// Get the text value of Device Sensitivity field
			string DeviceSensitivity = repo.FormMe.DeviceSensitivityAfterReopen.TextValue;
			
			//Comparing expected and actual Device Sensitivity value
			if(DeviceSensitivity.Equals(sDeviceSensitivity))
			{
				Report.Log(ReportLevel.Success,"Device Sensitivity " +DeviceSensitivity + " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device Sensitivity is not displayed correctly");
			}
			
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }

		/**************************************************************************************************
		 * Function Name: verifySKU
		 * Function Details: 
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 13/02/2020 Alpesh Dhakad - 20/05/2020 Updated script as per new xpaths
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void verifySKU(bool sSKU)
        {
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search SKU property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("SKU" +"{ENTER}" );
			
			// Click on SKU cell
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			repo.FormMe.cell_LabelNameProperties.Click();
			
			// Retrieve SKU Visibility
			//bool actualSKU = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.EnsureVisible();
			bool actualSKU = repo.FormMe.txt_LabelNameProperties.EnsureVisible();
			
			
			if(actualSKU.Equals(sSKU))
			{
				Report.Log(ReportLevel.Success,"SKU is displayed correctly");
			}
		else
			{
				Report.Log(ReportLevel.Failure,"SKU is displayed incorrectly");
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }
		
		/**************************************************************************************************
		 * Function Name: verifyZone
		 * Function Details: 
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 13/02/2020  Alpesh Dhakad - 20/05/2020 Updated script as per new xpaths
		 **************************************************************************************************/
		[UserCodeMethod]
		 public static void verifyZone(bool sZone)
        {
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Zone property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Zone" +"{ENTER}" );
			
			// Click on Zone cell
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			repo.FormMe.cell_LabelNameProperties.Click();
			
			// Retrieve Zone Visibility
			//bool actualZoneDescription = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.EnsureVisible();
			bool actualZoneDescription = repo.FormMe.txt_LabelNameProperties.EnsureVisible();
			
			
			if(actualZoneDescription.Equals(sZone))
			{
				Report.Log(ReportLevel.Success,"Zone is displayed correctly");
			}
		else
			{
				Report.Log(ReportLevel.Failure,"Zone is displayed incorrectly");
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }
		
		 /**************************************************************************************************
		 * Function Name: verifyLabelInPropertiesSection
		 * Function Details: 
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 13/02/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		  public static void verifyLabelInPropertiesSection(string sLabel)
        {
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Label" +"{ENTER}" );
			
			// Click on Alarm Load cell
			repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			
			// Retrieve value alarm load
			string actualLabelDescription = repo.ProfileConsys1.PARTItemsPresenter.txt_DayMatchesNight.TextValue;
			
			// Comparing DayMode and sDayMode values
			if(actualLabelDescription.Equals(sLabel))
			{
				Report.Log(ReportLevel.Success,"Label " +sLabel+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Label is displayed as "+actualLabelDescription+ " instead of "+ sLabel);
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }
	 
		 /********************************************************************
		 * Function Name: VerifyDeviceUsingLabelNameOnReopen
		 * Function Details: To verify item with label name
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 27/04/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceUsingLabelNameOnReopen(string sLabel)
		{
			sLabelName = sLabel;
			
			repo.FormMe.txt_LabelNameOnReopen.Click();
				
			if(repo.FormMe.txt_LabelNameOnReopenInfo.Exists())
			{
				Report.Log(ReportLevel.Success,"Device with label name " +sLabel+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Device with label name " +sLabel+ " not is displayed correctly");
			}
		}
		  
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameFromInventoryTab
		 * Function Details: To select item from inventory grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 29/04/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameFromInventoryTab(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelNameForInventory.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameFromInventoryTab
		 * Function Details: To select item from inventory grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 29/04/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameFromInventoryTabOnReopen(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelNameForInventoryOnReopen.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
			/********************************************************************
		 * Function Name: VerifyLabelInPanelAccessories
		 * Function Details: To verify label text  in Panel Accessories
		 * Parameter/Arguments:expected Label text
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 07/05/2020
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyLabelInPanelAccessoriesOnReopen(string sLabel)
		{
			repo.FormMe.PanelAccessoriesLabelOnReopen.Click();
			
			// Retrieve value of label
			string actualLabel = repo.FormMe.PanelAccessoriesLabelOnReopen.TextValue;
			
			// Comparing actualLabel and sLabel values
			if(actualLabel.Equals(sLabel))
			{
				Report.Log(ReportLevel.Success,"Label text " +actualLabel+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Label text is displayed as "+actualLabel+ " instead of "+ sLabel);
			}
		}
		
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameFromInventoryTab
		 * Function Details: To select item from inventory grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 29/04/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectFirstRowUsingLabelNameFromPanelAccessoriesTab(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.PanelAccessoriesLabel.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelName
		 * Function Details: To select item from grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : 21/2/2019 Alpesh Dhakad - 31/01/2020 Added xpath and updated below script
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameOnPLXLoop(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelNameOnPLXLoop.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		/********************************************************************
		 * Function Name: DeleteDeviceUsingLabelInInventoryTab
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh  Dhakad
		 * Last Update : 15/05/2020
		 ********************************************************************/
		[UserCodeMethod]
		public static void DeleteDeviceUsingLabelInInventoryTab(string LabelName)
		{
			sLabelName = LabelName;
			
			SelectRowUsingLabelNameFromInventoryTab(sLabelName);
			
			Common_Functions.clickOnDeleteButton();
				
			
			Report.Log(ReportLevel.Success, "Device "+sLabelName+" deleted successfully");
			
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameFromInventoryTab
		 * Function Details: To select item from inventory grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 16/05/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameForRBUS(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelNameForRBusRow.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameFromInventoryTab
		 * Function Details: To select item from inventory grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 16/05/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameForRBUSOneRow(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			
				repo.FormMe.txt_LabelNameForRBusOneRow.Click();
				
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameForPanelAccOneRow
		 * Function Details: To select item from panel accessories grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 19/05/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameForPanelAccOneRow(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			
				repo.FormMe.txt_LabelNameForPanelAccOneRow.Click();
				
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameForOneRow
		 * Function Details: To select item from grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad 
		 * Last Update : 
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameForOneRow(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelNameForOneRow.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
			
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameForRBUSOneRowOnReopen
		 * Function Details: To select item from RBUS using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 23/05/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameForRBUSOneRowOnReopen(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			
				repo.FormMe.txt_LabelNameForRBusOneRowOnReopen.Click();
				
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		
		/**************************************************************************************************
		 * Function Name: verifyZoneDescription
		 * Function Details: 
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 30/05/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		 public static void verifyZoneDescription(string sPropertyLabel, string sExpectedValue)
        {
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Zone property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Zone" +"{ENTER}" );
			
			// Click on Zone cell
			//repo.ProfileConsys1.PARTItemsPresenter.cell_DeviceMode.Click();
			repo.FormMe.cell_SearchPropertiesFirstRowDrpDwn.Click();
			
			// Retrieve Zone Visibility
			string actualZoneDescription = repo.FormMe.txt_LabelNameProperties.TextValue;
			
			
			if(actualZoneDescription.Equals(sExpectedValue))
			{
				Report.Log(ReportLevel.Success,"Property value of " +sPropertyLabel + " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Property value of " +sPropertyLabel+ " is not displayed correctly");
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }
		 
		 /********************************************************************
		 * Function Name: VerifyDeviceExistsForOneRow
		 * Function Details: To verify item with label name exists in Loop
		 * Parameter/Arguments: sExists, sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 30/05/2020
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDeviceExistsForOneRow(bool sExists, string sLabel)
		{
			sLabelName = sLabel;
			
			if(sExists)
			{
				if(repo.FormMe.txt_LabelNameForOneRowInfo.Exists())
				{
					Report.Log(ReportLevel.Success,"Device with label name " +sLabel+ " is displayed correctly");
				}
				else
				{
					Report.Log(ReportLevel.Failure,"Device with label name " +sLabel+ " not is displayed correctly");
				}
			}
			else
			{
				if(repo.FormMe.txt_LabelNameForOneRowInfo.Exists())
				{
					Report.Log(ReportLevel.Failure,"Device with label name " +sLabel+ " is getting displayed");
				}
				else
				{
					Report.Log(ReportLevel.Success,"Device with label name " +sLabel+ " is correctly not displayed");
				}
			}
		}
		
		/********************************************************************
		 * Function Name: SelectPointsGridRowOnReopen
		 * Function Details: To select points grid row
		 * Parameter/Arguments: sRowNumber
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 31/05/2020
		 ********************************************************************/
		// Change cable resistance method
		[UserCodeMethod]
		public static void SelectPointsGridRowOnReopen(string sRowNumber)
		{
			sRowIndex=sRowNumber;
			//Click on row from points grid
			repo.FormMe.PointsGridRowOnReopen.Click();
		}
		
		 /**************************************************************************************************
		 * Function Name: verifyLabelInPropertiesSection
		 * Function Details: 
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 31/05/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		  public static void verifyLabelInPropertiesSectionOnReopen(string sLabel)
        {
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Label" +"{ENTER}" );
			
			repo.FormMe.cell_LabelNameProperties.Click();
			
			// Retrieve value alarm load
			string actualLabelDescription = repo.FormMe.txt_LabelNameProperties.TextValue;
			
			// Comparing DayMode and sDayMode values
			if(actualLabelDescription.Equals(sLabel))
			{
				Report.Log(ReportLevel.Success,"Label " +sLabel+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Label is displayed as "+actualLabelDescription+ " instead of "+ sLabel);
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
        }
		
		/********************************************************************
		 * Function Name: VerifyAlarmLoadOnReopen
		 * Function Details: To verify alarm load of sounder
		 * Parameter/Arguments:expected alarm load
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :31/05/2020
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyAlarmLoadOnReopen(string sAlarmLoad)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Alarm Load" +"{ENTER}" );
			
			// Click on Alarm Load cell
			repo.FormMe.cell_LabelNameProperties.Click();
			
			// Retrieve value alarm load
			string actualAlarmLoad = repo.FormMe.txt_LabelNameProperties.TextValue;
			
			// Comparing DayMode and sDayMode values
			if(actualAlarmLoad.Equals(sAlarmLoad))
			{
				Report.Log(ReportLevel.Success,"Alarm Load " +sAlarmLoad+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Alarm Load is not displayed as "+actualAlarmLoad+ " instead of "+ sAlarmLoad);
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/********************************************************************
		 * Function Name: EditPoweredValue
		 * Function Details: To verify alarm load of sounder
		 * Parameter/Arguments:expected alarm load
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update :31/05/2020
		 ********************************************************************/
		[UserCodeMethod]
		public static void EditPoweredValue(string sPowered, string sPoweredValue)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Search Alarm Load property
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("Powered" +"{ENTER}" );
			
			//Click on cable length cell
			repo.FormMe.cell_LabelNameProperties.Click();
			//repo.FormMe.txt_InventoryProperty.Click();
			
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
			
			//Change the value of cable length
			repo.FormMe.txt_LabelNameProperties.PressKeys(sPoweredValue + "{ENTER}");
			
			Report.Log(ReportLevel.Info, "Powered from changed to  "+sPoweredValue+"  successfully");
			
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
		}
		
		/****************************************************************************************************************
		 * Function Name: VerifyCableLengthOnNode
		 * Function Details: To verify cable length
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 22/06/2020
		 ****************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyCableLengthOnNode(string sCableLength)
		{
			
			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Enter the Day Matches night text in Search Properties fields to view cable length;
			repo.ProfileConsys1.txt_SearchProperties.PressKeys("{LControlKey down}{Akey}{LControlKey up}Length" +"{ENTER}" );
			
			//Click on cable length cell
			repo.FormMe.cell_CableLength.Click();

			string actualCableLength = repo.FormMe.txt_CableLength.TextValue;
			//string actualCableLength = repo.ProfileConsys1.txt_CableLength.TextValue;
			
			
			// Comparing actual and expected value
			if(actualCableLength.Equals(sCableLength))
			{
				Report.Log(ReportLevel.Success,"Cable length value " +sCableLength+ " is displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Cable length value is displayed as "+actualCableLength+ " instead of "+ sCableLength);
			}

			// Click on SearchProperties text field
			repo.ProfileConsys1.txt_SearchProperties.Click();
			
			// Select the text in SearchProperties text field and delete it
			Keyboard.Press("{LControlKey down}{Akey}{Delete}{LControlKey up}");
			
			
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameForEXIDevice
		 * Function Details: To select item from grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad 
		 * Last Update : 24/06/2020
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameForEXIDevice(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelNameForEXI.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		/********************************************************************
		 * Function Name: SelectPointsGridRow
		 * Function Details: To select points grid row
		 * Parameter/Arguments: sRowNumber
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 27/06/2020
		 ********************************************************************/
		// Change cable resistance method
		[UserCodeMethod]
		public static void SelectPointsGridRowForEXIDEvice(string sRowNumber)
		{
			sRowIndex=sRowNumber;
			//Click on row from points grid
			repo.FormMe.PointsGridRowForEXI.Click();
		}
		
		/**************************************************************************************
		 * Function Name: verifyMaxLoopLoadingDetailsValue
		 * Function Details: To verify maximum loading details value of searched detail unit
		 * Parameter/Arguments: expectedUnits,column number and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 16/12/2020
		 * Alpesh Dhakad : 06/01/2021 and 12/01/2021 Updated as per new UI changes
		 **************************************************************************************/
		[UserCodeMethod]
		public static void verifyMaxLoopLoadingDetailsValue(string expectedUnits, string LoadingDetail, string ColumnNumber)
		{
			sColumn=ColumnNumber;
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_Loops_MaxLoadingDetailsValueInfo.Exists())
			{
			string MaxLoopLoadingUnits = repo.FormMe.txt_Loops_MaxLoadingDetailsValue.TextValue;
			
			string LoopLoadingUnits = MaxLoopLoadingUnits.Split('/')[1].Trim();
			
			if(LoopLoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Max Loop Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Max Loop Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoopLoadingUnits);
			}
			}
			else
			{
			string MaxLoopLoadingUnits = repo.FormMe.txt_Loops_MaxLoadingDetailsValuePreceding.TextValue;
			
			string LoopLoadingUnits = MaxLoopLoadingUnits.Split('/')[1].Trim();
			
			if(LoopLoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Max Loop Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Max Loop Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoopLoadingUnits);
			}
		}	
	
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
		}

		/**************************************************************************************
		 * Function Name: verifyLoopLoadingDetailsValue
		 * Function Details: To verify actual loading details value of searched detail unit
		 * Parameter/Arguments: expectedUnits,column number and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 16/12/2020
		 * Alpesh Dhakad : 06/01/2021  and 12/01/2021 Updated as per new UI changes
		 **************************************************************************************/
		[UserCodeMethod]
		public static void verifyLoopLoadingDetailsValue(string expectedUnits, string LoadingDetail,string ColumnNumber)
		{
			sColumn=ColumnNumber;
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_Loops_ActualLoadingDetailsValueInfo.Exists())
			{
			string ActualLoopLoadingUnits = repo.FormMe.txt_Loops_ActualLoadingDetailsValue.TextValue;
			
			string LoopLoadingUnits = ActualLoopLoadingUnits.Split('/')[0].Trim();
			
			
			if(LoopLoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Loop Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loop Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoopLoadingUnits);
			}
			
			}
			else
			{
			string ActualLoopLoadingUnits = repo.FormMe.txt_Loops_ActualLoadingDetailsValuePreceding.TextValue;
			
			string LoopLoadingUnits = ActualLoopLoadingUnits.Split('/')[0].Trim();
			
			
			if(LoopLoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Loop Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loop Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoopLoadingUnits);
			}
			
			}
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
		}

		/***************************************************************************************
		 * Function Name: verifyLoopLoadingDetailColor
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/12/2020
		 * Alpesh Dhakad : 06/01/2021 and 21/01/2021 Updated as per new UI changes
		 ***************************************************************************************/
		[UserCodeMethod]
		public static void verifyLoopLoadingDetailColor(string LoadingDetail,string ColumnNumber)
		{
			string expectedColor;
			sColumn=ColumnNumber;
			sLoadingDetail = LoadingDetail;
			
			//Go to Physical layout
			Common_Functions.clickOnPhysicalLayoutTab();
			Delay.Duration(500, false);
			
			Common_Functions.clickOnPanelCalculationsTab();
			
			//float ActualLoadingUnits = float.Parse(repo.FormMe.txt_Loops_ActualLoadingDetailsValue.TextValue);
			
			if(repo.FormMe.txt_Loops_ActualLoadingDetailsValueInfo.Exists())
			{
	
			string ActualLoopLoadingUnits = repo.FormMe.txt_Loops_ActualLoadingDetailsValue.TextValue;
			
			float LoopLoadingUnits = float.Parse(ActualLoopLoadingUnits.Split('/')[0].Trim());
			
			
			string actualColour = repo.FormMe.LoopLoadingDetailsProgressbarColor.GetAttributeValue<string>("foreground");
			
			//Fetch max volt drop text value and storing it in string
			//float MaxLoadingUnits = float.Parse(repo.FormMe.txt_Loops_MaxLoadingDetailsValue.TextValue);
			
			string MaxLoopLoadingUnits = repo.FormMe.txt_Loops_MaxLoadingDetailsValue.TextValue;
			
			float MaximumLoopLoadingUnits = float.Parse(MaxLoopLoadingUnits.Split('/')[1].Trim());
			
			expectedColor = Devices_Functions.calculatePercentage(LoopLoadingUnits, MaximumLoopLoadingUnits);
			
			Devices_Functions.VerifyPercentage(expectedColor, actualColour);
			}
			else
			{
			string ActualLoopLoadingUnits = repo.FormMe.txt_Loops_ActualLoadingDetailsValuePreceding.TextValue;
			
			float LoopLoadingUnits = float.Parse(ActualLoopLoadingUnits.Split('/')[0].Trim());
			
			
			string actualColour = repo.FormMe.LoopLoadingDetailsProgressbarColorPreceding.GetAttributeValue<string>("foreground");
			
			//Fetch max volt drop text value and storing it in string
			//float MaxLoadingUnits = float.Parse(repo.FormMe.txt_Loops_MaxLoadingDetailsValue.TextValue);
			
			string MaxLoopLoadingUnits = repo.FormMe.txt_Loops_MaxLoadingDetailsValuePreceding.TextValue;
			
			float MaximumLoopLoadingUnits = float.Parse(MaxLoopLoadingUnits.Split('/')[1].Trim());
			
			expectedColor = Devices_Functions.calculatePercentage(LoopLoadingUnits, MaximumLoopLoadingUnits);
			
			Devices_Functions.VerifyPercentage(expectedColor, actualColour);
			}
			
			
		}
		
		
		/********************************************************************
		 * Function Name: SelectInventoryGridFirstRow
		 * Function Details: To select inventory grid row
		 * Parameter/Arguments: sRowNumber, sSkuNumber
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 15/01/2021
		 ********************************************************************/
		// Change cable resistance method
		[UserCodeMethod]
		public static void SelectInventoryGridFirstRow(string sRowNumber)
		{
			sRow=sRowNumber;
			
			repo.FormMe.InventoryGridFirstRow.Click();
			Report.Log(ReportLevel.Success, "Inventory grid row selected");
		}
		
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameForOneRowFC
		 * Function Details: To select item from grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad 
		 * Last Update : 18/01/2021
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameForOneRowFC(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelNameForOneRowFC.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		/*****************************************************************************************************************************************
		 * Function Name: ChangeCableCapacitanceForEXI
		 * Function Details: To change cable capacitance
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 11/02/2021
		 *****************************************************************************************************************************************/
		// Change cable capacitance method
		[UserCodeMethod]
		public static void ChangeCableCapacitanceForEXI(int fchangeCableCapacitance, string sLabelName)
		{
			//Click on Points tab
			Common_Functions.clickOnPointsTab();
			
			
			// Click on Loop A node
			Common_Functions.ClickOnNavigationTreeItem("Built-in Loop-A");
			
			SelectRowUsingLabelNameForEXIDevice(sLabelName);
			
			//Click on cable capacitance cell
			repo.ProfileConsys1.cell_CableCapacitance.Click();
			
			//Change the value of cable length
			Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}"+fchangeCableCapacitance + "{Enter}");
			
			// Click on Panel node
			Common_Functions.ClickOnNavigationTreeExpander("Node");
			
			Delay.Duration(1000, false);
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingModelNameFromInventoryTab
		 * Function Details: To select item from inventory grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 12/02/2021
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingModelNameFromInventoryTab(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_ModelNameForInventory.Click();
				
			Report.Log(ReportLevel.Success, "Device with model name name " + sLabel+" selected");
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingLabelNameForAPM
		 * Function Details: To select item from grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad 
		 * Last Update : 18/02/2021
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingLabelNameForAPM(string sLabel)
		{
			sLabelName = sLabel;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_LabelNameForAPM.Click();
				
			Report.Log(ReportLevel.Success, "Device with Label name " + sLabel+" selected");
		}
		
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingSKUFromInventoryTab
		 * Function Details: To select item from inventory grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 19/05/2021
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingSKUFromInventoryTab(string sSKUNumber)
		{
			sLabelName = sSKUNumber;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_SKUForInventory.Click();
				
			Report.Log(ReportLevel.Success, "Device with SKU number " + sSKUNumber+" selected");
		}
		
		/**************************************************************************************************
		 * Function Name: SelectRowUsingSKUFromInventoryTab
		 * Function Details: To select item from inventory grid using label
		 * Parameter/Arguments: sLabelName
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 19/05/2021
		 **************************************************************************************************/
		[UserCodeMethod]
		public static void SelectRowUsingConnectionFromInventoryTab(string sConnectionName)
		{
			sLabelName = sConnectionName;
			//repo.FormMe.LabelName_txt.Click();
			//repo.ProfileConsys1.PanelInvetoryGrid.txt_Label1.Click();
			repo.FormMe.txt_SKUForInventory.Click();
				
			Report.Log(ReportLevel.Success, "Device with Connection name " + sConnectionName+" selected");
		}
		
		
		
		
		 /***********************************************************************************************************
		 * Function Name: verifyInventoryLabelNameExist
		 * Function Details: 
		 * Parameter/Arguments: 
		 * Output:
		 * Function Owner: Alpesh Dhakad 
		 * Last Update : 24/05/2021
		 ************************************************************************************************************/
        [UserCodeMethod]
        public static void verifyInventoryLabelNameExist(bool Visibility, string LabelName )
        {
        	sLabelName=LabelName;   
        	
        	if(Visibility)
			{
				if(repo.FormMe.txt_LabelNameForInventoryInfo.Exists())
				{
					Report.Log(ReportLevel.Success, "Device "+LabelName+"  exists");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Device "+LabelName+"  not exists");
				}
			}
			else
			{ 
				if(repo.FormMe.txt_LabelNameForInventoryInfo.Exists())
				{
					Report.Log(ReportLevel.Failure, "Device "+LabelName+"   exists");  
				}
				else
				{
					 Report.Log(ReportLevel.Success, "Device "+LabelName+"  not exists");  
				}
					     
					    
			}  
	
				
			}
        
        /*************************************************************************************************************************
		 * Function Name: verifyActualLoadingDetailsValue
		 * Function Details: To verify actual loading details value of searched detail unit
		 * Parameter/Arguments: expectedUnits and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 24/05/2021
		 **************************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyActualLoadingDetailsValue(string expectedUnits, string LoadingDetail)
		{
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_ActualLoadingDetailsValueInfo.Exists())
			{
			
			string LoadingUnits = repo.FormMe.txt_ActualLoadingDetailsValue.TextValue;
			
			if(LoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoadingUnits);
			}
			
			}
			else
			{
			string LoadingUnits = repo.FormMe.txt_ActualLoadingDetailsValuePreceding.TextValue;
			
			if(LoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoadingUnits);
			}
			}
			
			
		}
		
		/*************************************************************************************************************************
		 * Function Name: verifyMaximumLoadingDetailsValue
		 * Function Details: To verify max loading details value of searched detail unit
		 * Parameter/Arguments: expectedMaxUnits and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 25/05/2021
		 *************************************************************************************************************************/
		[UserCodeMethod]
		public static void verifyMaximumLoadingDetailsValue(string expectedMaxUnits, string LoadingDetail)
		{
			//Common_Functions.clickOnPhysicalLayoutTab();
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_MaxLoadingDetailsValueInfo.Exists())
			{
			
			string MaxLoadingUnits = repo.FormMe.txt_MaxLoadingDetailsValue.TextValue;
			
			if(MaxLoadingUnits.Equals(expectedMaxUnits))
			{
				Report.Log(ReportLevel.Success,"Maximum Loading Unit " + LoadingDetail + " value  "+ expectedMaxUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Maximum Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedMaxUnits  + " Actual Units: "+ MaxLoadingUnits);
			}
			
			}
			else
			{
			string MaxLoadingUnits = repo.FormMe.txt_MaxLoadingDetailsValuePreceding.TextValue;
			
			if(MaxLoadingUnits.Equals(expectedMaxUnits))
			{
				Report.Log(ReportLevel.Success,"Maximum Loading Unit " + LoadingDetail + " value  "+ expectedMaxUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Maximum Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedMaxUnits  + " Actual Units: "+ MaxLoadingUnits);
			}
			}
			
			
		}
		
		
        /**************************************************************************************
		 * Function Name: verifyMaximumLoopLoadingDetailsValue
		 * Function Details: To verify maximum loading details value of searched detail unit
		 * Parameter/Arguments: expectedUnits,column number and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 25/05/2021
		 **************************************************************************************/
		[UserCodeMethod]
		public static void verifyMaximumLoopLoadingDetailsValue(string expectedUnits, string LoadingDetail, string ColumnNumber)
		{
			sColumn=ColumnNumber;
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_Loops_MaxLoadingDetailsValueInfo.Exists())
			{
			string MaxLoopLoadingUnits = repo.FormMe.txt_Loops_MaxLoadingDetailsValue.TextValue;
			
			string LoopLoadingUnits = MaxLoopLoadingUnits.Split('/')[1].Trim();
			
			if(LoopLoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Maximum Loop Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Maximum Loop Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoopLoadingUnits);
			}
			}
			else
			{
			string MaxLoopLoadingUnits = repo.FormMe.txt_Loops_MaxLoadingDetailsValuePreceding.TextValue;
			
			string LoopLoadingUnits = MaxLoopLoadingUnits.Split('/')[1].Trim();
			
			if(LoopLoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Maximum Loop Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Maximum Loop Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoopLoadingUnits);
			}
		}	
	
		}

		/**************************************************************************************
		 * Function Name: verifyActualLoopLoadingDetailsValue
		 * Function Details: To verify actual loading details value of searched detail unit
		 * Parameter/Arguments: expectedUnits,column number and loading detail name
		 * Output:
		 * Function Owner: Alpesh Dhakad
		 * Last Update : 25/05/2021
		 **************************************************************************************/
		[UserCodeMethod]
		public static void verifyActualLoopLoadingDetailsValue(string expectedUnits, string LoadingDetail,string ColumnNumber)
		{
			sColumn=ColumnNumber;
			sLoadingDetail = LoadingDetail;
			
			if(repo.FormMe.txt_Loops_ActualLoadingDetailsValueInfo.Exists())
			{
			string ActualLoopLoadingUnits = repo.FormMe.txt_Loops_ActualLoadingDetailsValue.TextValue;
			
			string LoopLoadingUnits = ActualLoopLoadingUnits.Split('/')[0].Trim();
			
			
			if(LoopLoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Actual Loop Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Actual Loop Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoopLoadingUnits);
			}
			
			}
			else
			{
			string ActualLoopLoadingUnits = repo.FormMe.txt_Loops_ActualLoadingDetailsValuePreceding.TextValue;
			
			string LoopLoadingUnits = ActualLoopLoadingUnits.Split('/')[0].Trim();
			
			
			if(LoopLoadingUnits.Equals(expectedUnits))
			{
				Report.Log(ReportLevel.Success,"Actual Loop Loading Unit " + LoadingDetail + " value  "+ expectedUnits + " displayed correctly");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Actual Loop Loading Units " + LoadingDetail + " value are not displayed correctly " + ", Expected Units:  " + expectedUnits  + " Actual Units: "+ LoopLoadingUnits);
			}
			
			}
			
		}

	}
}



