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
    ///The Adverse1_Driver_Personal_Information recording.
    /// </summary>
    [TestModule("0b05bf14-ad88-44f9-88f4-b2da4d0dd516", ModuleType.Recording, 1)]
    public partial class Adverse1_Driver_Personal_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse1_Driver_Personal_Information instance = new Adverse1_Driver_Personal_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse1_Driver_Personal_Information()
        {
            AD1_PI_FirstName = "";
            AD1_PI_LastName = "";
            AD1_PI_POE = "";
            AD1_PI_Address1 = "";
            AD1_PI_Address2 = "";
            AD1_PI_City = "";
            AD1_PI_BankruptcyCounty = "";
            AD1_PI_BankruptcyDistrict = "";
            AD1_PI_BankruptcyChapter = "";
            AD1_PI_BankruptcyCaseNo = "";
            AD1_PI_PhoneUseType = "";
            AD1_PI_PhoneType = "";
            AD1_PI_PhoneSource = "";
            AD1_PI_PhoneNumber = "";
            AD1_PI_EmailUseType = "";
            AD1_PI_EmailSource = "";
            AD1_PI_Email = "";
            AD1_PI_State = "";
            AD1_PI_Zip = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse1_Driver_Personal_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _AD1_PI_FirstName;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_FirstName.
        /// </summary>
        [TestVariable("c924a9de-7051-49c6-a9fe-0ab060e03eb3")]
        public string AD1_PI_FirstName
        {
            get { return _AD1_PI_FirstName; }
            set { _AD1_PI_FirstName = value; }
        }

        string _AD1_PI_LastName;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_LastName.
        /// </summary>
        [TestVariable("fd68c91f-d66e-4758-9c36-40e027d7223d")]
        public string AD1_PI_LastName
        {
            get { return _AD1_PI_LastName; }
            set { _AD1_PI_LastName = value; }
        }

        string _AD1_PI_POE;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_POE.
        /// </summary>
        [TestVariable("a15f6cb0-ff4a-4627-8817-a40a0167054c")]
        public string AD1_PI_POE
        {
            get { return _AD1_PI_POE; }
            set { _AD1_PI_POE = value; }
        }

        string _AD1_PI_Address1;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_Address1.
        /// </summary>
        [TestVariable("aace1cee-1ef1-49c2-86bc-715436ac756f")]
        public string AD1_PI_Address1
        {
            get { return _AD1_PI_Address1; }
            set { _AD1_PI_Address1 = value; }
        }

        string _AD1_PI_Address2;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_Address2.
        /// </summary>
        [TestVariable("fd7ba836-dab2-4dd8-9dee-c005c71b3d3b")]
        public string AD1_PI_Address2
        {
            get { return _AD1_PI_Address2; }
            set { _AD1_PI_Address2 = value; }
        }

        string _AD1_PI_City;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_City.
        /// </summary>
        [TestVariable("84edf392-95ea-4820-965f-f063f0574a60")]
        public string AD1_PI_City
        {
            get { return _AD1_PI_City; }
            set { _AD1_PI_City = value; }
        }

        string _AD1_PI_BankruptcyCounty;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_BankruptcyCounty.
        /// </summary>
        [TestVariable("83260dc1-12ed-4add-9f68-abd690ddd63a")]
        public string AD1_PI_BankruptcyCounty
        {
            get { return _AD1_PI_BankruptcyCounty; }
            set { _AD1_PI_BankruptcyCounty = value; }
        }

        string _AD1_PI_BankruptcyDistrict;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_BankruptcyDistrict.
        /// </summary>
        [TestVariable("1da780d0-d3bf-4386-bafe-bb835af769af")]
        public string AD1_PI_BankruptcyDistrict
        {
            get { return _AD1_PI_BankruptcyDistrict; }
            set { _AD1_PI_BankruptcyDistrict = value; }
        }

        string _AD1_PI_BankruptcyChapter;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_BankruptcyChapter.
        /// </summary>
        [TestVariable("e3097fba-1273-4e25-9e12-e7dd7f7c827e")]
        public string AD1_PI_BankruptcyChapter
        {
            get { return _AD1_PI_BankruptcyChapter; }
            set { _AD1_PI_BankruptcyChapter = value; }
        }

        string _AD1_PI_BankruptcyCaseNo;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_BankruptcyCaseNo.
        /// </summary>
        [TestVariable("635958f9-7f97-4446-b057-0c1eb7a8ec3f")]
        public string AD1_PI_BankruptcyCaseNo
        {
            get { return _AD1_PI_BankruptcyCaseNo; }
            set { _AD1_PI_BankruptcyCaseNo = value; }
        }

        string _AD1_PI_PhoneUseType;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_PhoneUseType.
        /// </summary>
        [TestVariable("a893e1b4-d757-4ab2-8dba-5d001598a926")]
        public string AD1_PI_PhoneUseType
        {
            get { return _AD1_PI_PhoneUseType; }
            set { _AD1_PI_PhoneUseType = value; }
        }

        string _AD1_PI_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_PhoneType.
        /// </summary>
        [TestVariable("3facf415-269f-48b3-a622-87f952840642")]
        public string AD1_PI_PhoneType
        {
            get { return _AD1_PI_PhoneType; }
            set { _AD1_PI_PhoneType = value; }
        }

        string _AD1_PI_PhoneSource;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_PhoneSource.
        /// </summary>
        [TestVariable("fc0b38d8-9f0e-4d6f-9d08-8452184ba220")]
        public string AD1_PI_PhoneSource
        {
            get { return _AD1_PI_PhoneSource; }
            set { _AD1_PI_PhoneSource = value; }
        }

        string _AD1_PI_PhoneNumber;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_PhoneNumber.
        /// </summary>
        [TestVariable("0e1bb417-ab77-4cdf-964c-071e7c234b58")]
        public string AD1_PI_PhoneNumber
        {
            get { return _AD1_PI_PhoneNumber; }
            set { _AD1_PI_PhoneNumber = value; }
        }

        string _AD1_PI_EmailUseType;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_EmailUseType.
        /// </summary>
        [TestVariable("d3c0f89d-2471-4fb9-8ee5-ebbe3ae69b5f")]
        public string AD1_PI_EmailUseType
        {
            get { return _AD1_PI_EmailUseType; }
            set { _AD1_PI_EmailUseType = value; }
        }

        string _AD1_PI_EmailSource;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_EmailSource.
        /// </summary>
        [TestVariable("90b27ec6-c449-48eb-b43f-d8c3900134ed")]
        public string AD1_PI_EmailSource
        {
            get { return _AD1_PI_EmailSource; }
            set { _AD1_PI_EmailSource = value; }
        }

        string _AD1_PI_Email;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_Email.
        /// </summary>
        [TestVariable("8c01815b-a3b7-4edc-88d3-a66d00ef3de8")]
        public string AD1_PI_Email
        {
            get { return _AD1_PI_Email; }
            set { _AD1_PI_Email = value; }
        }

        string _AD1_PI_State;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_State.
        /// </summary>
        [TestVariable("f874f187-1a1e-48f1-9996-8750bdc4ca17")]
        public string AD1_PI_State
        {
            get { return _AD1_PI_State; }
            set { _AD1_PI_State = value; }
        }

        string _AD1_PI_Zip;

        /// <summary>
        /// Gets or sets the value of variable AD1_PI_Zip.
        /// </summary>
        [TestVariable("6218d7b1-3611-4082-9173-a7bb0ec82795")]
        public string AD1_PI_Zip
        {
            get { return _AD1_PI_Zip; }
            set { _AD1_PI_Zip = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.Driver_Owner_Different'", repo.ApplicationUnderTest.Driver_Owner_DifferentInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.Driver_Owner_DifferentInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Driver_Owner_Different' at Center.", repo.ApplicationUnderTest.Driver_Owner_DifferentInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Driver_Owner_Different.Click();
            Delay.Milliseconds(200);
            
            // Validation Start
            Report.Log(ReportLevel.Info, "Section", "Validation Start", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pending-ClaimInformation') on item 'ApplicationUnderTest.Pending_ClaimInformation'.", repo.ApplicationUnderTest.Pending_ClaimInformationInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Pending_ClaimInformationInfo, "InnerText", "Pending-ClaimInformation");
            Delay.Milliseconds(100);
            
            // Validation End
            Report.Log(ReportLevel.Info, "Section", "Validation End", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_FirstName' with focus on 'ApplicationUnderTest.AD1_PI_FirstName'.", repo.ApplicationUnderTest.AD1_PI_FirstNameInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AD1_PI_FirstName.PressKeys(AD1_PI_FirstName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_LastName' with focus on 'ApplicationUnderTest.AD1_PI_LastName'.", repo.ApplicationUnderTest.AD1_PI_LastNameInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AD1_PI_LastName.PressKeys(AD1_PI_LastName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_POE' with focus on 'ApplicationUnderTest.AD1_PI_POE'.", repo.ApplicationUnderTest.AD1_PI_POEInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.AD1_PI_POE.PressKeys(AD1_PI_POE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_Address1' with focus on 'ApplicationUnderTest.AD1_PI_Address1'.", repo.ApplicationUnderTest.AD1_PI_Address1Info, new RecordItemIndex(9));
            repo.ApplicationUnderTest.AD1_PI_Address1.PressKeys(AD1_PI_Address1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_Address2' with focus on 'ApplicationUnderTest.AD1_PI_Address2'.", repo.ApplicationUnderTest.AD1_PI_Address2Info, new RecordItemIndex(10));
            repo.ApplicationUnderTest.AD1_PI_Address2.PressKeys(AD1_PI_Address2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_City' with focus on 'ApplicationUnderTest.AD1_PI_City'.", repo.ApplicationUnderTest.AD1_PI_CityInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AD1_PI_City.PressKeys(AD1_PI_City);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD1_PI_State' on item 'ApplicationUnderTest.AD1_PI_State'.", repo.ApplicationUnderTest.AD1_PI_StateInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AD1_PI_State.Element.SetAttributeValue("TagValue", AD1_PI_State);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(14));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_Zip' with focus on 'ApplicationUnderTest.AD1_PI_Zip'.", repo.ApplicationUnderTest.AD1_PI_ZipInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.AD1_PI_Zip.PressKeys(AD1_PI_Zip);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -360 units.", new RecordItemIndex(16));
            //Mouse.ScrollWheel(-360);
            //Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(17));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ' ' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press(" ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(19));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_BankruptcyCounty' with focus on 'ApplicationUnderTest.AD1_PI_BankruptcyCounty'.", repo.ApplicationUnderTest.AD1_PI_BankruptcyCountyInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.AD1_PI_BankruptcyCounty.PressKeys(AD1_PI_BankruptcyCounty);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_BankruptcyDistrict' with focus on 'ApplicationUnderTest.AD1_PI_BankruptcyDistrict'.", repo.ApplicationUnderTest.AD1_PI_BankruptcyDistrictInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.AD1_PI_BankruptcyDistrict.PressKeys(AD1_PI_BankruptcyDistrict);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_BankruptcyChapter' with focus on 'ApplicationUnderTest.AD1_PI_BankruptcyChapter'.", repo.ApplicationUnderTest.AD1_PI_BankruptcyChapterInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.AD1_PI_BankruptcyChapter.PressKeys(AD1_PI_BankruptcyChapter);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_BankruptcyCaseNo' with focus on 'ApplicationUnderTest.AD1_PI_BankruptcyCaseNo'.", repo.ApplicationUnderTest.AD1_PI_BankruptcyCaseNoInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.AD1_PI_BankruptcyCaseNo.PressKeys(AD1_PI_BankruptcyCaseNo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(24));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(25));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD1_PI_PhoneUseType' on item 'ApplicationUnderTest.AD1_PI_PhoneUseType'.", repo.ApplicationUnderTest.AD1_PI_PhoneUseTypeInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.AD1_PI_PhoneUseType.Element.SetAttributeValue("TagValue", AD1_PI_PhoneUseType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD1_PI_PhoneType' on item 'ApplicationUnderTest.AD1_PI_PhoneType'.", repo.ApplicationUnderTest.AD1_PI_PhoneTypeInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.AD1_PI_PhoneType.Element.SetAttributeValue("TagValue", AD1_PI_PhoneType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD1_PI_PhoneSource' on item 'ApplicationUnderTest.AD1_PI_PhoneSource'.", repo.ApplicationUnderTest.AD1_PI_PhoneSourceInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.AD1_PI_PhoneSource.Element.SetAttributeValue("TagValue", AD1_PI_PhoneSource);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_PhoneNumber' with focus on 'ApplicationUnderTest.AD1_PI_PhoneNumber'.", repo.ApplicationUnderTest.AD1_PI_PhoneNumberInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.AD1_PI_PhoneNumber.PressKeys(AD1_PI_PhoneNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(30));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(31));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD1_PI_EmailUseType' on item 'ApplicationUnderTest.AD1_PI_EmailUseType'.", repo.ApplicationUnderTest.AD1_PI_EmailUseTypeInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.AD1_PI_EmailUseType.Element.SetAttributeValue("TagValue", AD1_PI_EmailUseType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD1_PI_EmailSource' on item 'ApplicationUnderTest.AD1_PI_EmailSource'.", repo.ApplicationUnderTest.AD1_PI_EmailSourceInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.AD1_PI_EmailSource.Element.SetAttributeValue("TagValue", AD1_PI_EmailSource);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_PI_Email' with focus on 'ApplicationUnderTest.AD1_PI_Email'.", repo.ApplicationUnderTest.AD1_PI_EmailInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.AD1_PI_Email.PressKeys(AD1_PI_Email);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(35));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
