﻿///////////////////////////////////////////////////////////////////////////////
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

namespace SubmissionCase_E2E
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Adverse_Other_Insurance_Info_Save recording.
    /// </summary>
    [TestModule("e605261e-a3e1-4319-83e2-0b07110f6cc9", ModuleType.Recording, 1)]
    public partial class Adverse_Other_Insurance_Info_Save : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse_Other_Insurance_Info_Save instance = new Adverse_Other_Insurance_Info_Save();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse_Other_Insurance_Info_Save()
        {
            OAT_IL_CompName = "";
            OAT_IL_PolicyNumber = "";
            OAT_IL_ClaimNumber = "";
            OAT_IL_ContactName = "";
            OAT_IL_State = "";
            OAT_IL_Address1 = "";
            OAT_IL_Address2 = "";
            OAT_IL_City = "";
            OAT_IL_Zip = "";
            OAT_IL_UseType = "";
            OAT_IL_PhoneType = "";
            OAT_IL_Source = "";
            OAT_IL_PhoneNumber = "";
            OAT_IL_ExtNo = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse_Other_Insurance_Info_Save Instance
        {
            get { return instance; }
        }

#region Variables

        string _OAT_IL_CompName;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_CompName.
        /// </summary>
        [TestVariable("bd635287-a387-4af5-bbce-772b73273b3e")]
        public string OAT_IL_CompName
        {
            get { return _OAT_IL_CompName; }
            set { _OAT_IL_CompName = value; }
        }

        string _OAT_IL_PolicyNumber;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_PolicyNumber.
        /// </summary>
        [TestVariable("ffafc40c-989e-4b78-9b4b-75bcfd1e1da5")]
        public string OAT_IL_PolicyNumber
        {
            get { return _OAT_IL_PolicyNumber; }
            set { _OAT_IL_PolicyNumber = value; }
        }

        string _OAT_IL_ClaimNumber;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_ClaimNumber.
        /// </summary>
        [TestVariable("679f4602-fe83-471e-ae02-3fe5c413dc66")]
        public string OAT_IL_ClaimNumber
        {
            get { return _OAT_IL_ClaimNumber; }
            set { _OAT_IL_ClaimNumber = value; }
        }

        string _OAT_IL_ContactName;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_ContactName.
        /// </summary>
        [TestVariable("2181e446-7c29-4422-89e4-4b22dfb068d8")]
        public string OAT_IL_ContactName
        {
            get { return _OAT_IL_ContactName; }
            set { _OAT_IL_ContactName = value; }
        }

        string _OAT_IL_State;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_State.
        /// </summary>
        [TestVariable("5b59e121-cd0d-4470-8006-7446b45c6197")]
        public string OAT_IL_State
        {
            get { return _OAT_IL_State; }
            set { _OAT_IL_State = value; }
        }

        string _OAT_IL_Address1;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_Address1.
        /// </summary>
        [TestVariable("80b30eb2-244b-4683-a37e-8c5dd8fd86c4")]
        public string OAT_IL_Address1
        {
            get { return _OAT_IL_Address1; }
            set { _OAT_IL_Address1 = value; }
        }

        string _OAT_IL_Address2;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_Address2.
        /// </summary>
        [TestVariable("c5ea36a1-6e49-425e-b897-4cda87d8b806")]
        public string OAT_IL_Address2
        {
            get { return _OAT_IL_Address2; }
            set { _OAT_IL_Address2 = value; }
        }

        string _OAT_IL_City;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_City.
        /// </summary>
        [TestVariable("c005462b-97de-4141-bc98-756787a1a16d")]
        public string OAT_IL_City
        {
            get { return _OAT_IL_City; }
            set { _OAT_IL_City = value; }
        }

        string _OAT_IL_Zip;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_Zip.
        /// </summary>
        [TestVariable("30968ccd-c8a0-4ce3-91e7-b24c8cee0bef")]
        public string OAT_IL_Zip
        {
            get { return _OAT_IL_Zip; }
            set { _OAT_IL_Zip = value; }
        }

        string _OAT_IL_UseType;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_UseType.
        /// </summary>
        [TestVariable("a305e199-90cd-4e4a-87c3-70b74225828b")]
        public string OAT_IL_UseType
        {
            get { return _OAT_IL_UseType; }
            set { _OAT_IL_UseType = value; }
        }

        string _OAT_IL_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_PhoneType.
        /// </summary>
        [TestVariable("960a47e9-aae2-42f3-ae61-e2398ee45835")]
        public string OAT_IL_PhoneType
        {
            get { return _OAT_IL_PhoneType; }
            set { _OAT_IL_PhoneType = value; }
        }

        string _OAT_IL_Source;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_Source.
        /// </summary>
        [TestVariable("1eb2d724-6c8c-4b93-868b-4c5091dc0c86")]
        public string OAT_IL_Source
        {
            get { return _OAT_IL_Source; }
            set { _OAT_IL_Source = value; }
        }

        string _OAT_IL_PhoneNumber;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_PhoneNumber.
        /// </summary>
        [TestVariable("801baae3-bc87-4f32-b954-93529ec45fdc")]
        public string OAT_IL_PhoneNumber
        {
            get { return _OAT_IL_PhoneNumber; }
            set { _OAT_IL_PhoneNumber = value; }
        }

        string _OAT_IL_ExtNo;

        /// <summary>
        /// Gets or sets the value of variable OAT_IL_ExtNo.
        /// </summary>
        [TestVariable("03daf803-9783-453a-87df-58d1d3509a5b")]
        public string OAT_IL_ExtNo
        {
            get { return _OAT_IL_ExtNo; }
            set { _OAT_IL_ExtNo = value; }
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InsuranceInformation1' at 98;26.", repo.ApplicationUnderTest.InsuranceInformation1Info, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.InsuranceInformation1.Click("98;26");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_CompName) on item 'ApplicationUnderTest.OAT_IL_CompName'.", repo.ApplicationUnderTest.OAT_IL_CompNameInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_CompNameInfo, "TagValue", OAT_IL_CompName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_CompName, new RecordItemIndex(2));
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'ApplicationUnderTest.OAT_IL_RentalCompany'.", repo.ApplicationUnderTest.OAT_IL_RentalCompanyInfo, new RecordItemIndex(3));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_RentalCompanyInfo, "Checked", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='true') on item 'ApplicationUnderTest.OAT_IL_RentalCompany'.", repo.ApplicationUnderTest.OAT_IL_RentalCompanyInfo, new RecordItemIndex(4));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_RentalCompanyInfo, "Value", "true");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_PolicyNumber) on item 'ApplicationUnderTest.OAT_IL_PolicyNumber'.", repo.ApplicationUnderTest.OAT_IL_PolicyNumberInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_PolicyNumberInfo, "TagValue", OAT_IL_PolicyNumber);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_PolicyNumber, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_ClaimNumber) on item 'ApplicationUnderTest.OAT_IL_ClaimNumber'.", repo.ApplicationUnderTest.OAT_IL_ClaimNumberInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_ClaimNumberInfo, "TagValue", OAT_IL_ClaimNumber);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_ClaimNumber, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_ContactName) on item 'ApplicationUnderTest.OAT_IL_ContactName'.", repo.ApplicationUnderTest.OAT_IL_ContactNameInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_ContactNameInfo, "TagValue", OAT_IL_ContactName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_ContactName, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_State) on item 'ApplicationUnderTest.OAT_IL_State'.", repo.ApplicationUnderTest.OAT_IL_StateInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_StateInfo, "TagValue", OAT_IL_State);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_State, new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_Address1) on item 'ApplicationUnderTest.OAT_IL_Address1'.", repo.ApplicationUnderTest.OAT_IL_Address1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_Address1Info, "TagValue", OAT_IL_Address1);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_Address1, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_Address2) on item 'ApplicationUnderTest.OAT_IL_Address2'.", repo.ApplicationUnderTest.OAT_IL_Address2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_Address2Info, "TagValue", OAT_IL_Address2);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_Address2, new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_City) on item 'ApplicationUnderTest.OAT_IL_City'.", repo.ApplicationUnderTest.OAT_IL_CityInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_CityInfo, "TagValue", OAT_IL_City);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_City, new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_Zip) on item 'ApplicationUnderTest.OAT_IL_Zip'.", repo.ApplicationUnderTest.OAT_IL_ZipInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_ZipInfo, "TagValue", OAT_IL_Zip);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_Zip, new RecordItemIndex(20));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(21));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_UseType) on item 'ApplicationUnderTest.OAT_IL_UseType'.", repo.ApplicationUnderTest.OAT_IL_UseTypeInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_UseTypeInfo, "TagValue", OAT_IL_UseType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_UseType, new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_PhoneType) on item 'ApplicationUnderTest.OAT_IL_PhoneType'.", repo.ApplicationUnderTest.OAT_IL_PhoneTypeInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_PhoneTypeInfo, "TagValue", OAT_IL_PhoneType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_PhoneType, new RecordItemIndex(25));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_Source) on item 'ApplicationUnderTest.OAT_IL_Source'.", repo.ApplicationUnderTest.OAT_IL_SourceInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_SourceInfo, "TagValue", OAT_IL_Source);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_Source, new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.OAT_IL_PhoneNumber' and assigning its value to variable 'OAT_IL_PhoneNumber'.", repo.ApplicationUnderTest.OAT_IL_PhoneNumberInfo, new RecordItemIndex(28));
            OAT_IL_PhoneNumber = repo.ApplicationUnderTest.OAT_IL_PhoneNumber.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_PhoneNumber) on item 'ApplicationUnderTest.OAT_IL_PhoneNumber'.", repo.ApplicationUnderTest.OAT_IL_PhoneNumberInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_PhoneNumberInfo, "TagValue", OAT_IL_PhoneNumber);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_PhoneNumber, new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.OAT_IL_ExtNo' and assigning its value to variable 'OAT_IL_ExtNo'.", repo.ApplicationUnderTest.OAT_IL_ExtNoInfo, new RecordItemIndex(31));
            OAT_IL_ExtNo = repo.ApplicationUnderTest.OAT_IL_ExtNo.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$OAT_IL_ExtNo) on item 'ApplicationUnderTest.OAT_IL_ExtNo'.", repo.ApplicationUnderTest.OAT_IL_ExtNoInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_ExtNoInfo, "TagValue", OAT_IL_ExtNo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", OAT_IL_ExtNo, new RecordItemIndex(33));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit_5' at 53;18.", repo.ApplicationUnderTest.Submit_5Info, new RecordItemIndex(35));
            repo.ApplicationUnderTest.Submit_5.Click("53;18");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
