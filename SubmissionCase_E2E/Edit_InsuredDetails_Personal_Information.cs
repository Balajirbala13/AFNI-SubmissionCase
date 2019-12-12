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
    ///The Edit_InsuredDetails_Personal_Information recording.
    /// </summary>
    [TestModule("a36a3f91-0a7d-488e-8cd0-37c92561a9c4", ModuleType.Recording, 1)]
    public partial class Edit_InsuredDetails_Personal_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Edit_InsuredDetails_Personal_Information instance = new Edit_InsuredDetails_Personal_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Edit_InsuredDetails_Personal_Information()
        {
            ID_PI_FirstName = "";
            ID_PI_LastName = "";
            ID_PI_Address1 = "";
            ID_PI_Address2 = "";
            ID_PI_City = "";
            ID_PI_State = "";
            ID_PI_Zip = "";
            ID_PI_DOB = "";
            ID_PI_UseType = "";
            ID_PI_PhoneType = "";
            ID_PI_Source = "";
            ID_PI_PhoneNumber = "";
            ID_PI_EmailUseType = "";
            ID_PI_EmailSource = "";
            ID_PI_EmailID = "";
            Edit_ID_PI_FirstName = "Edit_ID_PI_FirstName";
            Edit_ID_PI_LastName = "Edit_ID_PI_LastName";
            Edit_ID_PI_Address1 = "Edit_ID_PI_Address1";
            Edit_ID_PI_Address2 = "Edit_ID_PI_Address2";
            Edit_ID_PI_City = "Edit_ID_PI_City";
            Edit_ID_PI_State = "ND";
            Edit_ID_PI_Zip = "300006002";
            Edit_ID_PI_DOB = "10/11/1994";
            Edit_ID_PI_UseType = "Personal";
            Edit_ID_PI_PhoneType = "Fax";
            Edit_ID_PI_Source = "Direct";
            Edit_ID_PI_PhoneNumber = "9600095011";
            Edit_ID_PI_EmailUseType = "Business";
            Edit_IID_PI_EmailSource = "Direct";
            Edit_IID_PI_EmailID = "EditID_PI@Email.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Edit_InsuredDetails_Personal_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _ID_PI_FirstName;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_FirstName.
        /// </summary>
        [TestVariable("9d72a271-5b4e-40da-9553-c4d2d007fe5c")]
        public string ID_PI_FirstName
        {
            get { return _ID_PI_FirstName; }
            set { _ID_PI_FirstName = value; }
        }

        string _ID_PI_LastName;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_LastName.
        /// </summary>
        [TestVariable("6bdc83dd-9a9c-498a-9b93-7b81451575e7")]
        public string ID_PI_LastName
        {
            get { return _ID_PI_LastName; }
            set { _ID_PI_LastName = value; }
        }

        string _ID_PI_Address1;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_Address1.
        /// </summary>
        [TestVariable("2b80918a-c38d-4428-9307-75712b59f24d")]
        public string ID_PI_Address1
        {
            get { return _ID_PI_Address1; }
            set { _ID_PI_Address1 = value; }
        }

        string _ID_PI_Address2;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_Address2.
        /// </summary>
        [TestVariable("389eaf37-a6d8-4959-94df-bcd5ebe8c294")]
        public string ID_PI_Address2
        {
            get { return _ID_PI_Address2; }
            set { _ID_PI_Address2 = value; }
        }

        string _ID_PI_City;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_City.
        /// </summary>
        [TestVariable("49678ddf-9227-42e1-a6d8-f4f3087163e1")]
        public string ID_PI_City
        {
            get { return _ID_PI_City; }
            set { _ID_PI_City = value; }
        }

        string _ID_PI_State;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_State.
        /// </summary>
        [TestVariable("fcdb38ed-49e8-43af-9a3a-41d02981d950")]
        public string ID_PI_State
        {
            get { return _ID_PI_State; }
            set { _ID_PI_State = value; }
        }

        string _ID_PI_Zip;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_Zip.
        /// </summary>
        [TestVariable("a7a84642-dff7-4ac0-913a-98fae68ea412")]
        public string ID_PI_Zip
        {
            get { return _ID_PI_Zip; }
            set { _ID_PI_Zip = value; }
        }

        string _ID_PI_DOB;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_DOB.
        /// </summary>
        [TestVariable("ce3385be-d5be-46a8-9e4a-c7abdf19f7ec")]
        public string ID_PI_DOB
        {
            get { return _ID_PI_DOB; }
            set { _ID_PI_DOB = value; }
        }

        string _ID_PI_UseType;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_UseType.
        /// </summary>
        [TestVariable("b3d40b50-348b-4213-80d4-1cb5de2a1f50")]
        public string ID_PI_UseType
        {
            get { return _ID_PI_UseType; }
            set { _ID_PI_UseType = value; }
        }

        string _ID_PI_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_PhoneType.
        /// </summary>
        [TestVariable("320f8c69-7915-467c-a508-3a48f656b3ec")]
        public string ID_PI_PhoneType
        {
            get { return _ID_PI_PhoneType; }
            set { _ID_PI_PhoneType = value; }
        }

        string _ID_PI_Source;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_Source.
        /// </summary>
        [TestVariable("b7a0a677-5858-41c8-b056-bc3d0daf387e")]
        public string ID_PI_Source
        {
            get { return _ID_PI_Source; }
            set { _ID_PI_Source = value; }
        }

        string _ID_PI_PhoneNumber;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_PhoneNumber.
        /// </summary>
        [TestVariable("f61a4ad9-a10c-4457-b163-d839bbc887b1")]
        public string ID_PI_PhoneNumber
        {
            get { return _ID_PI_PhoneNumber; }
            set { _ID_PI_PhoneNumber = value; }
        }

        string _ID_PI_EmailUseType;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_EmailUseType.
        /// </summary>
        [TestVariable("74289681-9176-43bb-8169-62bfd6d85ef5")]
        public string ID_PI_EmailUseType
        {
            get { return _ID_PI_EmailUseType; }
            set { _ID_PI_EmailUseType = value; }
        }

        string _ID_PI_EmailSource;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_EmailSource.
        /// </summary>
        [TestVariable("d8e393a4-3be4-4a81-a857-5cf6d9520a7c")]
        public string ID_PI_EmailSource
        {
            get { return _ID_PI_EmailSource; }
            set { _ID_PI_EmailSource = value; }
        }

        string _ID_PI_EmailID;

        /// <summary>
        /// Gets or sets the value of variable ID_PI_EmailID.
        /// </summary>
        [TestVariable("b7ead875-1b9a-4763-a511-052fbb3cea20")]
        public string ID_PI_EmailID
        {
            get { return _ID_PI_EmailID; }
            set { _ID_PI_EmailID = value; }
        }

        string _Edit_ID_PI_FirstName;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_FirstName.
        /// </summary>
        [TestVariable("c408c220-462b-4ec6-8730-72e5383f29c0")]
        public string Edit_ID_PI_FirstName
        {
            get { return _Edit_ID_PI_FirstName; }
            set { _Edit_ID_PI_FirstName = value; }
        }

        string _Edit_ID_PI_LastName;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_LastName.
        /// </summary>
        [TestVariable("9daa47a8-dc38-47a9-a474-f41d302ed0ce")]
        public string Edit_ID_PI_LastName
        {
            get { return _Edit_ID_PI_LastName; }
            set { _Edit_ID_PI_LastName = value; }
        }

        string _Edit_ID_PI_Address1;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_Address1.
        /// </summary>
        [TestVariable("4b47034b-e402-404b-94ad-2d23170f3007")]
        public string Edit_ID_PI_Address1
        {
            get { return _Edit_ID_PI_Address1; }
            set { _Edit_ID_PI_Address1 = value; }
        }

        string _Edit_ID_PI_Address2;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_Address2.
        /// </summary>
        [TestVariable("7990adca-d37b-4540-ad6a-ba05bf52ae31")]
        public string Edit_ID_PI_Address2
        {
            get { return _Edit_ID_PI_Address2; }
            set { _Edit_ID_PI_Address2 = value; }
        }

        string _Edit_ID_PI_City;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_City.
        /// </summary>
        [TestVariable("5f5452b9-b25b-43a5-9ebb-85654c426cb7")]
        public string Edit_ID_PI_City
        {
            get { return _Edit_ID_PI_City; }
            set { _Edit_ID_PI_City = value; }
        }

        string _Edit_ID_PI_State;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_State.
        /// </summary>
        [TestVariable("1e66f291-d01b-4b4c-9117-f4d9e1d8f8e4")]
        public string Edit_ID_PI_State
        {
            get { return _Edit_ID_PI_State; }
            set { _Edit_ID_PI_State = value; }
        }

        string _Edit_ID_PI_Zip;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_Zip.
        /// </summary>
        [TestVariable("bc572397-e6b7-4d93-9eff-f44fb4705508")]
        public string Edit_ID_PI_Zip
        {
            get { return _Edit_ID_PI_Zip; }
            set { _Edit_ID_PI_Zip = value; }
        }

        string _Edit_ID_PI_DOB;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_DOB.
        /// </summary>
        [TestVariable("24bc5963-1996-42d2-b5b6-b63c09091e0d")]
        public string Edit_ID_PI_DOB
        {
            get { return _Edit_ID_PI_DOB; }
            set { _Edit_ID_PI_DOB = value; }
        }

        string _Edit_ID_PI_UseType;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_UseType.
        /// </summary>
        [TestVariable("82e6a0d3-37f5-44c6-a97a-920c68acf6bd")]
        public string Edit_ID_PI_UseType
        {
            get { return _Edit_ID_PI_UseType; }
            set { _Edit_ID_PI_UseType = value; }
        }

        string _Edit_ID_PI_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_PhoneType.
        /// </summary>
        [TestVariable("bb7db869-63db-4884-9dd1-f0d2b6fd2dc7")]
        public string Edit_ID_PI_PhoneType
        {
            get { return _Edit_ID_PI_PhoneType; }
            set { _Edit_ID_PI_PhoneType = value; }
        }

        string _Edit_ID_PI_Source;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_Source.
        /// </summary>
        [TestVariable("953cb3b1-d07a-4aea-a1c3-e23b9c7c4055")]
        public string Edit_ID_PI_Source
        {
            get { return _Edit_ID_PI_Source; }
            set { _Edit_ID_PI_Source = value; }
        }

        string _Edit_ID_PI_PhoneNumber;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_PhoneNumber.
        /// </summary>
        [TestVariable("3a3ab1e5-a476-4ffd-83dc-5bd1911c07dd")]
        public string Edit_ID_PI_PhoneNumber
        {
            get { return _Edit_ID_PI_PhoneNumber; }
            set { _Edit_ID_PI_PhoneNumber = value; }
        }

        string _Edit_ID_PI_EmailUseType;

        /// <summary>
        /// Gets or sets the value of variable Edit_ID_PI_EmailUseType.
        /// </summary>
        [TestVariable("f8a5702a-05dd-48f4-9049-a79353bebacf")]
        public string Edit_ID_PI_EmailUseType
        {
            get { return _Edit_ID_PI_EmailUseType; }
            set { _Edit_ID_PI_EmailUseType = value; }
        }

        string _Edit_IID_PI_EmailSource;

        /// <summary>
        /// Gets or sets the value of variable Edit_IID_PI_EmailSource.
        /// </summary>
        [TestVariable("f0a8b34e-55f2-4c1a-bb00-ebd887d008ed")]
        public string Edit_IID_PI_EmailSource
        {
            get { return _Edit_IID_PI_EmailSource; }
            set { _Edit_IID_PI_EmailSource = value; }
        }

        string _Edit_IID_PI_EmailID;

        /// <summary>
        /// Gets or sets the value of variable Edit_IID_PI_EmailID.
        /// </summary>
        [TestVariable("adbe3b0a-6f65-49b8-aa05-cc7c10555704")]
        public string Edit_IID_PI_EmailID
        {
            get { return _Edit_IID_PI_EmailID; }
            set { _Edit_IID_PI_EmailID = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Save_Button' at 6;8.", repo.ApplicationUnderTest.Save_ButtonInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Save_Button.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.AgentDetails_Header'", repo.ApplicationUnderTest.AgentDetails_HeaderInfo, new ActionTimeout(10000), new RecordItemIndex(2));
            //repo.ApplicationUnderTest.AgentDetails_HeaderInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_FirstName) on item 'ApplicationUnderTest.ID_PI_FirstName'.", repo.ApplicationUnderTest.ID_PI_FirstNameInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_FirstNameInfo, "TagValue", ID_PI_FirstName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_FirstName, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_LastName) on item 'ApplicationUnderTest.ID_PI_LastName'.", repo.ApplicationUnderTest.ID_PI_LastNameInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_LastNameInfo, "TagValue", ID_PI_LastName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_LastName, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_Address1) on item 'ApplicationUnderTest.ID_PI_Address1'.", repo.ApplicationUnderTest.ID_PI_Address1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_Address1Info, "TagValue", ID_PI_Address1);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_Address1, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_Address2) on item 'ApplicationUnderTest.ID_PI_Address2'.", repo.ApplicationUnderTest.ID_PI_Address2Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_Address2Info, "TagValue", ID_PI_Address2);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_Address2, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_City) on item 'ApplicationUnderTest.ID_PI_City'.", repo.ApplicationUnderTest.ID_PI_CityInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_CityInfo, "TagValue", ID_PI_City);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_City, new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_State) on item 'ApplicationUnderTest.ID_PI_State'.", repo.ApplicationUnderTest.ID_PI_StateInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_StateInfo, "TagValue", ID_PI_State);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_State, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.ID_PI_Zip' and assigning its value to variable 'ID_PI_Zip'.", repo.ApplicationUnderTest.ID_PI_ZipInfo, new RecordItemIndex(15));
            ID_PI_Zip = repo.ApplicationUnderTest.ID_PI_Zip.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_Zip) on item 'ApplicationUnderTest.ID_PI_Zip'.", repo.ApplicationUnderTest.ID_PI_ZipInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_ZipInfo, "TagValue", ID_PI_Zip);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_Zip, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_DOB) on item 'ApplicationUnderTest.ID_PI_DOB'.", repo.ApplicationUnderTest.ID_PI_DOBInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_DOBInfo, "TagValue", ID_PI_DOB);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", ID_PI_DOB, repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.ID_PI_UseType' and assigning its value to variable 'ID_PI_UseType'.", repo.ApplicationUnderTest.ID_PI_UseTypeInfo, new RecordItemIndex(20));
            ID_PI_UseType = repo.ApplicationUnderTest.ID_PI_UseType.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_UseType) on item 'ApplicationUnderTest.ID_PI_UseType'.", repo.ApplicationUnderTest.ID_PI_UseTypeInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_UseTypeInfo, "TagValue", ID_PI_UseType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_UseType, new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.ID_PI_PhoneType' and assigning its value to variable 'ID_PI_PhoneType'.", repo.ApplicationUnderTest.ID_PI_PhoneTypeInfo, new RecordItemIndex(23));
            ID_PI_PhoneType = repo.ApplicationUnderTest.ID_PI_PhoneType.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_PhoneType) on item 'ApplicationUnderTest.ID_PI_PhoneType'.", repo.ApplicationUnderTest.ID_PI_PhoneTypeInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_PhoneTypeInfo, "TagValue", ID_PI_PhoneType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_PhoneType, new RecordItemIndex(25));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.ID_PI_Source' and assigning its value to variable 'ID_PI_Source'.", repo.ApplicationUnderTest.ID_PI_SourceInfo, new RecordItemIndex(26));
            ID_PI_Source = repo.ApplicationUnderTest.ID_PI_Source.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_Source) on item 'ApplicationUnderTest.ID_PI_Source'.", repo.ApplicationUnderTest.ID_PI_SourceInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_SourceInfo, "TagValue", ID_PI_Source);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_Source, new RecordItemIndex(28));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.ID_PI_PhoneNumber' and assigning its value to variable 'ID_PI_PhoneNumber'.", repo.ApplicationUnderTest.ID_PI_PhoneNumberInfo, new RecordItemIndex(29));
            ID_PI_PhoneNumber = repo.ApplicationUnderTest.ID_PI_PhoneNumber.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_PhoneNumber) on item 'ApplicationUnderTest.ID_PI_PhoneNumber'.", repo.ApplicationUnderTest.ID_PI_PhoneNumberInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_PhoneNumberInfo, "TagValue", ID_PI_PhoneNumber);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_PhoneNumber, new RecordItemIndex(31));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_EmailUseType) on item 'ApplicationUnderTest.ID_PI_EmailUseType'.", repo.ApplicationUnderTest.ID_PI_EmailUseTypeInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_EmailUseTypeInfo, "TagValue", ID_PI_EmailUseType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_EmailUseType, new RecordItemIndex(33));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_EmailSource) on item 'ApplicationUnderTest.ID_PI_EmailSource'.", repo.ApplicationUnderTest.ID_PI_EmailSourceInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_EmailSourceInfo, "TagValue", ID_PI_EmailSource);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_EmailSource, new RecordItemIndex(35));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ID_PI_EmailID) on item 'ApplicationUnderTest.ID_PI_EmailID'.", repo.ApplicationUnderTest.ID_PI_EmailIDInfo, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ID_PI_EmailIDInfo, "TagValue", ID_PI_EmailID);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", ID_PI_EmailID, new RecordItemIndex(37));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(38));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit_5' at 47;10.", repo.ApplicationUnderTest.Submit_5Info, new RecordItemIndex(39));
            repo.ApplicationUnderTest.Submit_5.Click("47;10");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}