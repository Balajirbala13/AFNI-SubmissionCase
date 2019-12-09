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
    ///The Adverse1_Owner_Attorney_Details recording.
    /// </summary>
    [TestModule("31fa9098-09cf-43b3-9f03-6452948e6c34", ModuleType.Recording, 1)]
    public partial class Adverse1_Owner_Attorney_Details : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse1_Owner_Attorney_Details instance = new Adverse1_Owner_Attorney_Details();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse1_Owner_Attorney_Details()
        {
            O1_Attorney_FirmName = "";
            O1_Attorney_FirstName = "";
            O1_Attorney_LastName = "";
            O1_Attorney_Address1 = "";
            O1_Attorney_Address2 = "";
            O1_Attorney_City = "";
            AO1_Attorney_State = "";
            AO1_Attorney_Zip = "";
            AO1_Attorney_Email = "";
            AO1_Attorney_RepDate = "";
            AO_AD_UseType = "";
            AO_AD_PhoneType = "";
            AO_AD_Source = "";
            AO_AD_PhoneNumber = "";
            AO_AD_EmailUseType = "";
            AO_AD_EmailSource = "";
            AO_AD_EmailId = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse1_Owner_Attorney_Details Instance
        {
            get { return instance; }
        }

#region Variables

        string _O1_Attorney_FirmName;

        /// <summary>
        /// Gets or sets the value of variable O1_Attorney_FirmName.
        /// </summary>
        [TestVariable("d8b52db5-964c-4265-9f40-e3fcf37de97c")]
        public string O1_Attorney_FirmName
        {
            get { return _O1_Attorney_FirmName; }
            set { _O1_Attorney_FirmName = value; }
        }

        string _O1_Attorney_FirstName;

        /// <summary>
        /// Gets or sets the value of variable O1_Attorney_FirstName.
        /// </summary>
        [TestVariable("2180a79c-18ee-4953-857d-8148a18fa4c3")]
        public string O1_Attorney_FirstName
        {
            get { return _O1_Attorney_FirstName; }
            set { _O1_Attorney_FirstName = value; }
        }

        string _O1_Attorney_LastName;

        /// <summary>
        /// Gets or sets the value of variable O1_Attorney_LastName.
        /// </summary>
        [TestVariable("bb6561cb-89ea-453d-9c40-ff0464df3ff9")]
        public string O1_Attorney_LastName
        {
            get { return _O1_Attorney_LastName; }
            set { _O1_Attorney_LastName = value; }
        }

        string _O1_Attorney_Address1;

        /// <summary>
        /// Gets or sets the value of variable O1_Attorney_Address1.
        /// </summary>
        [TestVariable("df2304f9-7605-4c66-8ebf-4be2f840f0eb")]
        public string O1_Attorney_Address1
        {
            get { return _O1_Attorney_Address1; }
            set { _O1_Attorney_Address1 = value; }
        }

        string _O1_Attorney_Address2;

        /// <summary>
        /// Gets or sets the value of variable O1_Attorney_Address2.
        /// </summary>
        [TestVariable("87a24aaa-aed5-4345-ae9a-95f060a1ae1e")]
        public string O1_Attorney_Address2
        {
            get { return _O1_Attorney_Address2; }
            set { _O1_Attorney_Address2 = value; }
        }

        string _O1_Attorney_City;

        /// <summary>
        /// Gets or sets the value of variable O1_Attorney_City.
        /// </summary>
        [TestVariable("dcc2a85b-b593-41aa-90b8-0c9d9d4b7208")]
        public string O1_Attorney_City
        {
            get { return _O1_Attorney_City; }
            set { _O1_Attorney_City = value; }
        }

        string _AO1_Attorney_State;

        /// <summary>
        /// Gets or sets the value of variable AO1_Attorney_State.
        /// </summary>
        [TestVariable("41f38d35-a548-4958-be6a-a3c07c534a3f")]
        public string AO1_Attorney_State
        {
            get { return _AO1_Attorney_State; }
            set { _AO1_Attorney_State = value; }
        }

        string _AO1_Attorney_Zip;

        /// <summary>
        /// Gets or sets the value of variable AO1_Attorney_Zip.
        /// </summary>
        [TestVariable("b677fb0b-c0e9-417f-b3ec-109fe71003b0")]
        public string AO1_Attorney_Zip
        {
            get { return _AO1_Attorney_Zip; }
            set { _AO1_Attorney_Zip = value; }
        }

        string _AO1_Attorney_Email;

        /// <summary>
        /// Gets or sets the value of variable AO1_Attorney_Email.
        /// </summary>
        [TestVariable("f67eaef0-575f-4fad-9923-66d6d3471d85")]
        public string AO1_Attorney_Email
        {
            get { return _AO1_Attorney_Email; }
            set { _AO1_Attorney_Email = value; }
        }

        string _AO1_Attorney_RepDate;

        /// <summary>
        /// Gets or sets the value of variable AO1_Attorney_RepDate.
        /// </summary>
        [TestVariable("37dcfca7-14ec-4a74-b05d-7e27beec4090")]
        public string AO1_Attorney_RepDate
        {
            get { return _AO1_Attorney_RepDate; }
            set { _AO1_Attorney_RepDate = value; }
        }

        string _AO_AD_UseType;

        /// <summary>
        /// Gets or sets the value of variable AO_AD_UseType.
        /// </summary>
        [TestVariable("85642d29-359f-406d-9053-37b497a0e302")]
        public string AO_AD_UseType
        {
            get { return _AO_AD_UseType; }
            set { _AO_AD_UseType = value; }
        }

        string _AO_AD_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable AO_AD_PhoneType.
        /// </summary>
        [TestVariable("f4cc53f5-9bd0-410a-a532-22a410779287")]
        public string AO_AD_PhoneType
        {
            get { return _AO_AD_PhoneType; }
            set { _AO_AD_PhoneType = value; }
        }

        string _AO_AD_Source;

        /// <summary>
        /// Gets or sets the value of variable AO_AD_Source.
        /// </summary>
        [TestVariable("e30504d0-a33d-4329-ba70-82af61ee69fb")]
        public string AO_AD_Source
        {
            get { return _AO_AD_Source; }
            set { _AO_AD_Source = value; }
        }

        string _AO_AD_PhoneNumber;

        /// <summary>
        /// Gets or sets the value of variable AO_AD_PhoneNumber.
        /// </summary>
        [TestVariable("c0b68938-4efc-40e3-bb5a-220d3c30d428")]
        public string AO_AD_PhoneNumber
        {
            get { return _AO_AD_PhoneNumber; }
            set { _AO_AD_PhoneNumber = value; }
        }

        string _AO_AD_EmailUseType;

        /// <summary>
        /// Gets or sets the value of variable AO_AD_EmailUseType.
        /// </summary>
        [TestVariable("ca3b68b7-190e-4ea4-b0c8-404a0caa2fdd")]
        public string AO_AD_EmailUseType
        {
            get { return _AO_AD_EmailUseType; }
            set { _AO_AD_EmailUseType = value; }
        }

        string _AO_AD_EmailSource;

        /// <summary>
        /// Gets or sets the value of variable AO_AD_EmailSource.
        /// </summary>
        [TestVariable("82599c0b-8451-421d-9213-4240f8d8af42")]
        public string AO_AD_EmailSource
        {
            get { return _AO_AD_EmailSource; }
            set { _AO_AD_EmailSource = value; }
        }

        string _AO_AD_EmailId;

        /// <summary>
        /// Gets or sets the value of variable AO_AD_EmailId.
        /// </summary>
        [TestVariable("c27fc595-e12d-405e-8df8-2fff4b181767")]
        public string AO_AD_EmailId
        {
            get { return _AO_AD_EmailId; }
            set { _AO_AD_EmailId = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AttorneyInformation' at 67;26.", repo.ApplicationUnderTest.AttorneyInformationInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.AttorneyInformation.Click("67;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$O1_Attorney_FirmName' with focus on 'ApplicationUnderTest.AO1_Attorney_FirmName'.", repo.ApplicationUnderTest.AO1_Attorney_FirmNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AO1_Attorney_FirmName.PressKeys(O1_Attorney_FirmName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$O1_Attorney_FirstName' with focus on 'ApplicationUnderTest.AO1_Attorney_FirstName'.", repo.ApplicationUnderTest.AO1_Attorney_FirstNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AO1_Attorney_FirstName.PressKeys(O1_Attorney_FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$O1_Attorney_LastName' with focus on 'ApplicationUnderTest.AO1_Attorney_LastName'.", repo.ApplicationUnderTest.AO1_Attorney_LastNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AO1_Attorney_LastName.PressKeys(O1_Attorney_LastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$O1_Attorney_Address1' with focus on 'ApplicationUnderTest.AO1_Attorney_Address1'.", repo.ApplicationUnderTest.AO1_Attorney_Address1Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.AO1_Attorney_Address1.PressKeys(O1_Attorney_Address1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$O1_Attorney_Address2' with focus on 'ApplicationUnderTest.AO1_Attorney_Address2'.", repo.ApplicationUnderTest.AO1_Attorney_Address2Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.AO1_Attorney_Address2.PressKeys(O1_Attorney_Address2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$O1_Attorney_City' with focus on 'ApplicationUnderTest.AO1_Attorney_City'.", repo.ApplicationUnderTest.AO1_Attorney_CityInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AO1_Attorney_City.PressKeys(O1_Attorney_City);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AO1_Attorney_State' on item 'ApplicationUnderTest.AO1_Attorney_State'.", repo.ApplicationUnderTest.AO1_Attorney_StateInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AO1_Attorney_State.Element.SetAttributeValue("TagValue", AO1_Attorney_State);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(8));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AO1_Attorney_Zip' with focus on 'ApplicationUnderTest.AO1_Attorney_Zip'.", repo.ApplicationUnderTest.AO1_Attorney_ZipInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.AO1_Attorney_Zip.PressKeys(AO1_Attorney_Zip);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AO1_Attorney_Email' with focus on 'ApplicationUnderTest.AO1_Attorney_Email'.", repo.ApplicationUnderTest.AO1_Attorney_EmailInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AO1_Attorney_Email.PressKeys(AO1_Attorney_Email);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AO1_Attorney_RepDate' on item 'ApplicationUnderTest.AO1_Attorney_RepDate'.", repo.ApplicationUnderTest.AO1_Attorney_RepDateInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AO1_Attorney_RepDate.Element.SetAttributeValue("TagValue", AO1_Attorney_RepDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(13));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(14));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(15));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AO_AD_UseType' on item 'ApplicationUnderTest.AO_AD_UseType'.", repo.ApplicationUnderTest.AO_AD_UseTypeInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.AO_AD_UseType.Element.SetAttributeValue("TagValue", AO_AD_UseType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AO_AD_PhoneType' on item 'ApplicationUnderTest.AO_AD_PhoneType'.", repo.ApplicationUnderTest.AO_AD_PhoneTypeInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.AO_AD_PhoneType.Element.SetAttributeValue("TagValue", AO_AD_PhoneType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AO_AD_Source' on item 'ApplicationUnderTest.AO_AD_Source'.", repo.ApplicationUnderTest.AO_AD_SourceInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.AO_AD_Source.Element.SetAttributeValue("TagValue", AO_AD_Source);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AO_AD_PhoneNumber' with focus on 'ApplicationUnderTest.AO_AD_PhoneNumber'.", repo.ApplicationUnderTest.AO_AD_PhoneNumberInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.AO_AD_PhoneNumber.PressKeys(AO_AD_PhoneNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(20));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(21));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(22));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AO_AD_EmailUseType' on item 'ApplicationUnderTest.AO_AD_EmailUseType'.", repo.ApplicationUnderTest.AO_AD_EmailUseTypeInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.AO_AD_EmailUseType.Element.SetAttributeValue("TagValue", AO_AD_EmailUseType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AO_AD_EmailSource' on item 'ApplicationUnderTest.AO_AD_EmailSource'.", repo.ApplicationUnderTest.AO_AD_EmailSourceInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.AO_AD_EmailSource.Element.SetAttributeValue("TagValue", AO_AD_EmailSource);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AO_AD_EmailId' on item 'ApplicationUnderTest.AO_AD_EmailId'.", repo.ApplicationUnderTest.AO_AD_EmailIdInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.AO_AD_EmailId.Element.SetAttributeValue("TagValue", AO_AD_EmailId);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(26));
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence '{Tab}'.", new RecordItemIndex(27));
                Keyboard.Press("{Tab}");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}