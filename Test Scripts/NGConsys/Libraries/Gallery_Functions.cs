﻿/*
 * Created by Ranorex
 * User: jbhosash
 * Date: 5/21/2018
 * Time: 4:40 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestProject.Libraries
{
	/// <summary>
	/// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
	/// </summary>
	[UserCodeCollection]
	public class Gallery_Functions
	{
		
		//Create instance of repository to access repository items
		static NGConsysRepository repo = NGConsysRepository.Instance;
		static string ModelNumber
		{
			
			get { return repo.ModelNumber; }
			set { repo.ModelNumber = value; }
		}
		
		static string sItem
		{
			get { return repo.sItem; }
			set { repo.sItem = value; }
		}
		
		static string sEnabled
		{
			get { return repo.sEnabled; }
			set { repo.sEnabled = value; }
		}
		
		static string sGalleryIndex
		{
			get { return repo.sGalleryIndex; }
			set { repo.sGalleryIndex=value;}
		}
		
		static string listItem
		{
			get { return repo.listItem; }
			set { repo.listItem = value; }
		}
		static string sGalleryName
		{
			get { return repo.sGalleryName; }
			set { repo.sGalleryName = value; }
		}
		
		static string sDeviceIndex
		{
			get { return repo.sDeviceIndex; }
			set { repo.sDeviceIndex = value; }
		}
		
		static string sDeviceName
		{
			get { return repo.sDeviceName; }
			set { repo.sDeviceName = value; }
		}
		
		/// <summary>
		/// This is function used to select any item from units gallery
		/// iNumberOfItems: Number of items to add
		/// sItemName: Name of the gallery item e.g PLX800, MX2 Repeater etc
		/// sType: Gallery type e.g Loops, Repeaters etc
		/// </summary>
		/// 
		
		
		/********************************************************************
		 * Function Name: SelectItemFromUnitsGallery
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void SelectItemFromUnitsGallery(int iNumberOfItems, string sItemName, string sType)
		{
			
			for(int i=1;i<=iNumberOfItems;i++)
			{
				
				sItem=sItemName;
				
				switch (sType)
				{
					case "Repeaters":
						sGalleryIndex="3";
						break;
					case "Loops":
						sGalleryIndex="4";
						break;
					case "Slot Cards":
						sGalleryIndex="5";
						break;
					case "Miscellaneous":
						sGalleryIndex="6";
						break;
						
					default:
						Console.WriteLine("Please specify correct gallery name");
						break;
				}
				repo.ProfileConsys1.txt_listItem.Click();
				
			}
			
		}
		/// <summary>
		/// This is function is to expand Units gallery.
		/// sGalleryName:Name of the gallery e.g Loops,Repeaters etc
		/// </summary>
		/// 
		
		/********************************************************************
		 * Function Name: ExpandUnitsGallery
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void ExpandUnitsGallery(string sGalleryName)
		{
			SelectUnitsGalleryType(sGalleryName);
			repo.ProfileConsys1.UnitsGalleryDropDown.Click();
		}
		
		/// <summary>
		/// This is function is get the index of Gallery
		/// sType:Name of the gallery e.g Loops,Repeaters etc
		/// </summary>
		/// 
		
		/********************************************************************
		 * Function Name: SelectUnitsGalleryType
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void SelectUnitsGalleryType(string sType)
		{
			
			switch (sType)
			{
				case "Repeaters":
					sGalleryIndex="3";
					break;
				case "Loops":
					sGalleryIndex="4";
					break;
				case "Slot Cards":
					sGalleryIndex="5";
					break;
				case "Miscellaneous":
					sGalleryIndex="6";
					break;
					
				default:
					Console.WriteLine("Please specify correct gallery name");
					break;
			}
			
		}
		
		/// <summary>
		/// This is function used to verify enabled items in units gallery
		/// iNumberOfItems=Number of items to verify
		/// sItemNames: Item names comma seperated
		/// sType:Name of the gallery e.g Loops,Repeaters etc
		/// </summary>
		/// 
		
		/********************************************************************
		 * Function Name: VerifyEnabledItemFromUnitsGallery
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyEnabledItemFromUnitsGallery(int iNumberOfItems, string sItemNames, string sType)
		{
			
			for(int i=0;i<iNumberOfItems;i++)
			{
				string [] arrItemNames= sItemNames.Split(',');
				sItem=arrItemNames[i];
				SelectUnitsGalleryType(sType);
				if (repo.ProfileConsys1.txt_listItem.Enabled)
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + sItem+ " Enabled in gallery");
				}
				else
					Report.Log(ReportLevel.Failure, "Gallery Item: " + sItem+ " Disabled in gallery");
				
			}
			
		}
		
		/// <summary>
		/// This is function used to verify disabled items in units gallery
		/// iNumberOfItems=Number of items to verify
		/// sItemNames: Item names comma seperated
		/// sType:Name of the gallery e.g Loops,Repeaters etc
		/// </summary>
		/// 
		
		
		/********************************************************************
		 * Function Name: VerifyDisabledItemFromUnitsGallery
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDisabledItemFromUnitsGallery(int iNumberOfItems, string sItemNames, string sType)
		{
			
			for(int i=0;i<iNumberOfItems;i++)
			{
				string [] arrItemNames= sItemNames.Split(',');
				sItem=arrItemNames[i];
				SelectUnitsGalleryType(sType);
				if (repo.ProfileConsys1.txt_listItem.Enabled)
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + sItem+ " Enabled in gallery");
				}
				else
					Report.Log(ReportLevel.Success, "Gallery Item: " + sItem+ " Disabled in gallery");
				
			}
			
		}
		
		/********************************************************************
		 * Function Name: verifyGalleryExist
		 * Function Details:It will verify whether given gallery exist in ribbon
		 * Parameter/Arguments:GalleryName
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :11/3/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyGalleryExist(string sGalleryName, bool Visibility)
		{
			if(Visibility)
			{
				if(repo.ProfileConsys1.GalleryInfo.Exists())
				{
					Report.Log(ReportLevel.Success, "Gallery: " + sGalleryName+ " displayed in ribbon");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Gallery: " + sGalleryName+ " not displayed in ribbon");
				}
			}
			
			else
			{
				if(repo.ProfileConsys1.GalleryInfo.Exists())
				{
					Report.Log(ReportLevel.Failure, "Gallery: " + sGalleryName+ " displayed in ribbon");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Gallery: " + sGalleryName+ " not displayed in ribbon");
				}
				
			}
		}

		
		/********************************************************************
		 * Function Name: GetDevicesofNonDroppedGallery
		 * Function Details: It will verify favourite items list displayed in non dropped gallery
		 * Parameter/Arguments:GalleryType, Device1,Device2
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * created on :11/3/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void verifyNonDroppedGallery(string GalleryType,string Device1,string Device2)
		{
			listItem="0";
			string firstGalleryItemText,secondGalleryItemText;
			sGalleryIndex = Devices_Functions.SelectGalleryType(GalleryType);
			//string firstGalleryItemText = repo.FormMe.GalleryList.Text;
			Devices_Functions.AddDevicesfromGallery(Device1,GalleryType);
			firstGalleryItemText = repo.FormMe.txt_NonDroppedGalleryItemText.TextValue;
			if(firstGalleryItemText.Equals(Device1))
			{
				Report.Log(ReportLevel.Success, "Gallery: " + Device1+ " displayed as favourite device");
			}
			
			else
			{
				Report.Log(ReportLevel.Failure, "Gallery: " + Device1+ " not displayed as favourite device");
			}
			
			Devices_Functions.AddDevicesfromGallery(Device2,GalleryType);
			firstGalleryItemText = repo.FormMe.txt_NonDroppedGalleryItemText.TextValue;
			if(firstGalleryItemText.Equals(Device2))
			{
				Report.Log(ReportLevel.Success, "Gallery: " + Device2+ " displayed as favourite device");
			}
			
			else
			{
				Report.Log(ReportLevel.Failure, "Gallery: " + Device2+ " not displayed as favourite device");
			}
			
			listItem="1";
			secondGalleryItemText = repo.FormMe.txt_NonDroppedGalleryItemText.TextValue;
			if(secondGalleryItemText.Equals(Device1))
			{
				Report.Log(ReportLevel.Success, "Gallery: " + Device1+ " remains as 2nd favourite device");
			}
			
			else
			{
				Report.Log(ReportLevel.Failure, "Gallery: " + Device1+ " not remains as 2nd favourite device");
			}
		}
		
		/********************************************************************
		 * Function Name: verifyDroppedGalleryForFavoutitesDevices
		 * Function Details: It will verify devices list displayed in dropped gallery
		 * Parameter/Arguments:GalleryType, Device1(1st device of alphabetical sorted order),Device2(any device in alphabetical
		 * sorted order
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * created on :11/3/2019
		 ******************************************DroppedGalleryList**************************/
		[UserCodeMethod]
		
		public static void verifyDroppedGalleryForFavoutitesDevices(string GalleryType,string Device1,string Device2)
		{
			listItem="0";
			string firstGalleryItemText;
			//get gallery index
			sGalleryIndex = Devices_Functions.SelectGalleryType(GalleryType);
			
			//Expand gallery
			repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
			
			//Get first list item displayed in gallery
			firstGalleryItemText=repo.ContextMenu.txt_GalleryListItem.TextValue;
			//firstGalleryItemText = repo.ContextMenu.DroppedGalleryList.GetAttributeValue<string>("Text");
			
			repo.ProfileConsys1.tab_Points.Click();
			
			Devices_Functions.AddDevicesfromGalleryNotHavingImages(Device1, GalleryType);
			
			//Expand gallery again and verify text of 1st device
			repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
			
			firstGalleryItemText = repo.ContextMenu.txt_GalleryListItem.TextValue;
			if(firstGalleryItemText.Equals(Device1))
			{
				Report.Log(ReportLevel.Failure, "Devices in dropped gallery are not dispayed in alphabetically sorted order");
			}
			
			else
			{
				Report.Log(ReportLevel.Success, "Devices in dropped gallery are dispayed in alphabetically sorted order evenif device is added in favourites");
			}
			
			repo.ProfileConsys1.tab_Points.Click();
			Devices_Functions.AddDevicesfromGalleryNotHavingImages(Device2,GalleryType);
			repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
			firstGalleryItemText = repo.ContextMenu.txt_GalleryListItem.TextValue;
			if(firstGalleryItemText.Equals(Device2))
			{
				Report.Log(ReportLevel.Failure, "Devices in dropped gallery are not dispayed in alphabetically sorted order");
			}
			
			else
			{
				Report.Log(ReportLevel.Success, "Devices in dropped gallery are dispayed in alphabetically sorted order evenif device is added in favourites");
			}
			
			
		}
		
		/********************************************************************
		 * Function Name: verifyDroppedGalleryForDisabledDevices
		 * Function Details: It will verify devices list displayed in dropped gallery for disabled devices
		 * Parameter/Arguments:GalleryType, DisabledDeviceName,
		 * sorted order
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * created on :11/3/2019
		 ********************************************************************/
		
		[UserCodeMethod]
		public static void verifyDroppedGalleryforConventionalSounderWithDisabledDevices(string GalleryType,string indexOfDeviceToBeDisabled,string DisabledDeviceName)
		{
			listItem=indexOfDeviceToBeDisabled;
			string GalleryItemText;
			//get gallery index
			sGalleryIndex = Devices_Functions.SelectGalleryType(GalleryType);
			
			//Expand gallery
			repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
			
			//Get text of list item displayed in gallery
			GalleryItemText = repo.ContextMenu.txt_GalleryListItem.TextValue;;
			
			//Expand gallery again and verify text of 1st device
			repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
			
			if(GalleryItemText.Equals(DisabledDeviceName))
			{
				Report.Log(ReportLevel.Success, "Devices in dropped gallery are dispayed in alphabetically sorted order irrespective of enabled or disabled state");
			}
			
			else
			{
				Report.Log(ReportLevel.Success, "Devices in dropped gallery are not dispayed in alphabetically sorted order irrespective of enabled or disabled state");
			}
			
		}
		

		/********************************************************************
		 * Function Name: clickOnGalleryDropDown
		 * Function Details: This function is used to select next element present in gallery using drop down
		 * Parameter/Arguments:GalleryType
		 * sorted order
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * created on :11/3/2019
		 ********************************************************************/
		
		[UserCodeMethod]
		public static void clickOnGalleryDropDown(string GalleryType)
		{
			//get gallery index
			sGalleryIndex = Devices_Functions.SelectGalleryType(GalleryType);
			
			//click to see next gallery item
			repo.FormMe.btnGalleryDropDown.Click();
		}
		
		/********************************************************************
		 * Function Name: GetTextofSpecifiedGalleryIndexItem
		 * Function Details: It will verify favourite items list displayed in non dropped gallery
		 * Parameter/Arguments:GalleryType, Device1,Device2
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * created on :11/3/2019
		 ********************************************************************/
		[UserCodeMethod]
		public static void GetandVerifyTextofSpecifiedGalleryIndexItem(string GalleryType,string index,string expectedText)
		{
			listItem=index;
			string GalleryItemText;
			sGalleryIndex = Devices_Functions.SelectGalleryType(GalleryType);
			GalleryItemText = repo.FormMe.txt_NonDroppedGalleryItemText.TextValue;
			
			if(GalleryItemText.Equals(expectedText))
			{
				Report.Log(ReportLevel.Success, "Specified device exist at correct index in gallery");
			}
			
			else
			{
				Report.Log(ReportLevel.Failure, "Specified device not exist at correct index in gallery");
			}
			
		}
		
		/***********************************************************************************************************
		 * Function Name: VerifyCopyButton
		 * Function Details: VerifyCopyButton state
		 * Parameter/Arguments: isEnabled
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update : 12/03/2019
		 ************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyCopyButton(bool isEnabled)
		{
			if(isEnabled)
			{
				sEnabled="True";
			}
			else
			{
				sEnabled="False";
			}
			if(repo.FormMe.CopyInfo.Exists())
			{
				Report.Log(ReportLevel.Success,"Copy button state is as expected");
			}
			else
			{
				Report.Log(ReportLevel.Failure,"Copy button state is  not " + isEnabled);
			}
			
		}
		
		
		/********************************************************************
		 * Function Name: VerifyDisabledItemFromUnitsGallery
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner: Shweta Bhosale
		 * Last Update :
		 ********************************************************************/
		[UserCodeMethod]
		public static void VerifyDisabledItemFromDevicesGallery(int iNumberOfItems, string sItemNames, string sType)
		{
			
			for(int i=0;i<iNumberOfItems;i++)
			{
				string [] arrItemNames= sItemNames.Split(',');
				ModelNumber=arrItemNames[i];
				sGalleryIndex = Devices_Functions.SelectGalleryType(sType);
				repo.ProfileConsys1.btn_DevicesGalleryDropDown.Click();
				if (repo.ContextMenu.txt_galleryItem.Enabled)
				{
					Report.Log(ReportLevel.Failure, "Gallery Item: " + ModelNumber+ " Enabled in gallery");
				}
				else
				{
					Report.Log(ReportLevel.Success, "Gallery Item: " + ModelNumber+ " Disabled in gallery");
				}
				
				repo.ProfileConsys1.tab_Points.Click();
				
			}
			
			
			
		}
		
		/*****************************************************************************************************************
		 * Function Name:VerifyGalleryItems
		 * Function Details:
		 * Parameter/Arguments:
		 * Output:
		 * Function Owner:Purvi Bhasin
		 * Last Update :30/4/2019
		 *****************************************************************************************************************/
		[UserCodeMethod]
		public static void VerifyGalleryItems(string sFileName,string sAddPanelSheet, string sAddDeviceSheet)
		{
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddPanelSheet);
			
			// Count number of rows in excel and store it in rows variable
			int rows= Excel_Utilities.ExcelRange.Rows.Count;

			// Declared string type
			string PanelName, PanelNode,CPUType,PanelType,sType,sEnabledDevices,ModelName,GalleryName,DeviceType,sNoOfDevicesAdded,sDownClicked;
			int EnabledDevices,NoOfDevicesAdded,DownClicked;
			
			// For loop to iterate on data present in excel
			for(int i=8; i<=rows; i++)
			{
				PanelName =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
				PanelNode = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
				PanelType = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
				CPUType = ((Range)Excel_Utilities.ExcelRange.Cells[i,4]).Value.ToString();
				sEnabledDevices = ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
				ModelName = ((Range)Excel_Utilities.ExcelRange.Cells[i,6]).Value.ToString();
				DeviceType = ((Range)Excel_Utilities.ExcelRange.Cells[i,7]).Value.ToString();
				sNoOfDevicesAdded = ((Range)Excel_Utilities.ExcelRange.Cells[i,8]).Value.ToString();
				sDownClicked = ((Range)Excel_Utilities.ExcelRange.Cells[i,9]).Value.ToString();
				
				int.TryParse(sEnabledDevices, out EnabledDevices);
				int.TryParse(sNoOfDevicesAdded, out NoOfDevicesAdded);
				int.TryParse(sDownClicked, out DownClicked);
				
				// Add panels using test data in excel sheet
				Panel_Functions.AddPanels(1,PanelName,CPUType);
				Report.Log(ReportLevel.Info, "Panel "+PanelName+" added successfully");
				
				
				// Click on Expander node
				repo.ProfileConsys1.NavigationTree.Expander.Click();
				
				//Close excel sheet and read it values,
				Excel_Utilities.CloseExcel();
				
				//Open excel sheet and read it values,
				Excel_Utilities.OpenExcelFile(sFileName,sAddDeviceSheet);
				
				// Count number of rows in excel and store it in rows variable
				int Drows= Excel_Utilities.ExcelRange.Rows.Count;
				
				for(int t=2; t<=Drows; t++)
				{
					GalleryName = ((Range)Excel_Utilities.ExcelRange.Cells[t,2]).Value.ToString();
					sType = ((Range)Excel_Utilities.ExcelRange.Cells[t,3]).Value.ToString();
		
					ExpandUnitsGallery(sType);
					
					int DeviceIndex = t-2;
					sDeviceIndex = DeviceIndex.ToString();
					sDeviceName = GalleryName;
					
					string ExpectedGalleryName = repo.ContextMenu.Device_Name.TextValue;
					
					//Click on panel node
					repo.ProfileConsys1.NavigationTree.Expander.Click();
					
					if(GalleryName.Equals(ExpectedGalleryName))
					{
						Report.Log(ReportLevel.Success, "Repeater : " + GalleryName+ " is present");
					}
					else
					{
						Report.Log(ReportLevel.Failure, "Repeater : " + GalleryName+ " is absent");
					}
					
					for(int n=1; n<=DownClicked; n++)
					{
						//No of items in the container
						int NoOfItems = repo.FormMe.GalleryContainer.Children.Count;
						Report.Log(ReportLevel.Info,"NoOfItems: " +NoOfItems);
						for(int j=0; j<=NoOfItems; j++)
						{
							sDeviceIndex = j.ToString();
							
							if(repo.FormMe.Repeaters_Without_Expanding.Enabled)
							{
								Report.Log(ReportLevel.Success, "Repeater is enabled");
							}
							else
							{
								Report.Log(ReportLevel.Failure, "Repeater is disabled");
							}
							
						}
						
						if(repo.FormMe.Gallery_PARTDown.Enabled)
						{
							repo.FormMe.Gallery_PARTDown.Click();
						}
						
						NoOfItems = repo.FormMe.GalleryContainerInfo.Children.Count;
					}
					
				}
				
				for(int k=1;k<=NoOfDevicesAdded;k++)
						{
							//Add Loop cards
							Devices_Functions.AddDevicesfromPanelNodeGallery(ModelName,DeviceType,PanelType);
						}
				
				for(int j=2; j<=Drows; j++)
				{
					GalleryName = ((Range)Excel_Utilities.ExcelRange.Cells[j,2]).Value.ToString();
					sType = ((Range)Excel_Utilities.ExcelRange.Cells[j,3]).Value.ToString();
					
					string Status = ((Range)Excel_Utilities.ExcelRange.Cells[j,4]).Value.ToString();
					
					ExpandUnitsGallery(sType);
					
					int DeviceIndex = j-2;
					sDeviceIndex = DeviceIndex.ToString();
					sDeviceName = GalleryName;
					
					string ExpectedGalleryName = repo.ContextMenu.Device_Name.TextValue;
					
					//Click on panel node
					repo.ProfileConsys1.NavigationTree.Expander.Click();
					
					if(Status.Equals("Enabled"))
					{
						if(repo.ContextMenu.Device_Name.Enabled)
						{
							Report.Log(ReportLevel.Success, "Repeater : " + GalleryName+ " is Enabled");
						}
						else
						{
							Report.Log(ReportLevel.Failure, "Repeater : " + GalleryName+ " is disabled");
						}
						
					}
					else
					{
						if(repo.ContextMenu.Device_Name.Enabled)
						{
							Report.Log(ReportLevel.Failure, "Repeater : " + GalleryName+ " is Enabled");
						}
						else
						{
							Report.Log(ReportLevel.Success, "Repeater : " + GalleryName+ " is disabled");
						}
						
					}
				
			}
			
			
			Excel_Utilities.CloseExcel();
			//Delete Panel
			Panel_Functions.DeletePanel(1,PanelNode,1);
			Excel_Utilities.OpenExcelFile(sFileName,sAddPanelSheet);
			
		}
		Excel_Utilities.CloseExcel();
	}
	
	
	/*****************************************************************************************************************
	 * Function Name:VerifyGalleryItemsWithoutAddingAnyOtherEntity
	 * Function Details:
	 * Parameter/Arguments:
	 * Output:
	 * Function Owner:Purvi Bhasin
	 * Last Update :30/4/2019
	 *****************************************************************************************************************/
	[UserCodeMethod]
	public static void VerifyGalleryItemsWithoutAddingAnyOtherEntity(string sFileName,string sAddPanelSheet, string sAddDeviceSheet)
	{
		//Open excel sheet and read it values,
		Excel_Utilities.OpenExcelFile(sFileName,sAddPanelSheet);
		
		// Count number of rows in excel and store it in rows variable
		int rows= Excel_Utilities.ExcelRange.Rows.Count;

		// Declared string type
		string PanelName,PanelNode,CPUType,PanelType,sType,sEnabledDevices,GalleryName,sNoOfItems,sDownClicked,ExpectedGalleryName;
		int EnabledDevices,DownClicked,NoOfItems;
		string Present = "No";
		string ImagePresence = string.Empty;
		// For loop to iterate on data present in excel
		for(int i=8; i<=rows; i++)
		{
			PanelName =  ((Range)Excel_Utilities.ExcelRange.Cells[i,1]).Value.ToString();
			PanelNode = ((Range)Excel_Utilities.ExcelRange.Cells[i,2]).Value.ToString();
			PanelType = ((Range)Excel_Utilities.ExcelRange.Cells[i,3]).Value.ToString();
			CPUType = ((Range)Excel_Utilities.ExcelRange.Cells[i,4]).Value.ToString();
			sEnabledDevices = ((Range)Excel_Utilities.ExcelRange.Cells[i,5]).Value.ToString();
			sDownClicked = ((Range)Excel_Utilities.ExcelRange.Cells[i,6]).Value.ToString();
			sNoOfItems = ((Range)Excel_Utilities.ExcelRange.Cells[i,7]).Value.ToString();
			
			int.TryParse(sEnabledDevices, out EnabledDevices);
			int.TryParse(sDownClicked, out DownClicked);
			int.TryParse(sNoOfItems, out NoOfItems);
			
			// Add panels using test data in excel sheet
			Panel_Functions.AddPanels(1,PanelName,CPUType);
			Report.Log(ReportLevel.Info, "Panel "+PanelName+" added successfully");
			
			
			// Click on Expander node
			repo.ProfileConsys1.NavigationTree.Expander.Click();
			
			//Close excel sheet and read it values,
			Excel_Utilities.CloseExcel();
			
			//Open excel sheet and read it values,
			Excel_Utilities.OpenExcelFile(sFileName,sAddDeviceSheet);
			
			// Count number of rows in excel and store it in rows variable
			int Drows= Excel_Utilities.ExcelRange.Rows.Count;
			
			for(int j=2; j<=Drows; j++)
			{
				GalleryName = ((Range)Excel_Utilities.ExcelRange.Cells[j,2]).Value.ToString();
				sType = ((Range)Excel_Utilities.ExcelRange.Cells[j,3]).Value.ToString();
				ImagePresence = ((Range)Excel_Utilities.ExcelRange.Cells[j,4]).Value.ToString();
				
				
				ExpandUnitsGallery(sType);
				
				int DeviceIndex = j-2;
				sDeviceIndex = DeviceIndex.ToString();
				sDeviceName = GalleryName;
				
				if(ImagePresence.Equals(Present))
				{
					ExpectedGalleryName = repo.ContextMenu.Txt_DeviceWithoutImage_Expanded.TextValue;
				}
				else
				{
					ExpectedGalleryName = repo.ContextMenu.Device_Name.TextValue;
				}
				
				
				//Click on panel node
				repo.ProfileConsys1.NavigationTree.Expander.Click();
				
				if(GalleryName.Equals(ExpectedGalleryName))
				{
					Report.Log(ReportLevel.Success, "Entity : " + GalleryName+ " is present");
				}
				else
				{
					Report.Log(ReportLevel.Failure, "Entity  : " + GalleryName+ " is absent");
				}
				
			}
			
			
			for(int n=0; n<=DownClicked; n++)
			{
				for(int j=1; j<=NoOfItems; j++)
				{
					sDeviceIndex = j.ToString();
					if(ImagePresence.Equals(Present))
					{
						if(repo.FormMe.txt_DevicesWithoutImage.Enabled)
						{
							Report.Log(ReportLevel.Success, "Entity:" +sDeviceIndex+ "is enabled");
						}
						else
						{
							Report.Log(ReportLevel.Failure, "Entity:" +sDeviceIndex+ "is disabled");
						}
						
					}
					
					else
					{
						if(repo.FormMe.Repeaters_Without_Expanding.Enabled)
						{
							Report.Log(ReportLevel.Success, "Entity:" +sDeviceIndex+ "is enabled");
						}
						else
						{
							Report.Log(ReportLevel.Failure, "Entity:" +sDeviceIndex+ "is disabled");
						}
					}
					
					repo.FormMe.Gallery_PARTDown.Click();
				}
				NoOfItems = EnabledDevices - NoOfItems;
			}
			
		}
		
		Excel_Utilities.CloseExcel();
		//Delete Panel
		//Panel_Functions.DeletePanel(1,PanelNode,1);
		Excel_Utilities.OpenExcelFile(sFileName,sAddPanelSheet);
		
	}

	
}
}

