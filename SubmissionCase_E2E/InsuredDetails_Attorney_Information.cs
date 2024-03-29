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
    ///The InsuredDetails_Attorney_Information recording.
    /// </summary>
    [TestModule("5bc21814-3a7d-477f-b47a-b188fd606eec", ModuleType.Recording, 1)]
    public partial class InsuredDetails_Attorney_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static InsuredDetails_Attorney_Information instance = new InsuredDetails_Attorney_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsuredDetails_Attorney_Information()
        {
            ID_AI_FirmName = "";
            ID_AI_FirstName = "";
            ID_AI_LastName = "";
            ID_AI_Address1 = "";
            ID_AI_Address2 = "";
            ID_AI_City = "";
            ID_AI_State = "";
            ID_AI_Zipcode = "";
            ID_AI_Email = "";
            ID_AI_RepresentationDate = "";
            ID_AI_UseType = "";
            ID_AI_PhoneType = "";
            ID_AI_Source = "Caller ID";
            ID_AI_Phone = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsuredDetails_Attorney_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _ID_AI_FirmName;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_FirmName.
        /// </summary>
        [TestVariable("f128a2f0-92cb-4583-9e6d-f2782837b4e5")]
        public string ID_AI_FirmName
        {
            get { return _ID_AI_FirmName; }
            set { _ID_AI_FirmName = value; }
        }

        string _ID_AI_FirstName;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_FirstName.
        /// </summary>
        [TestVariable("aa4ebf4a-1578-4d1a-ac01-6774e78c3fb5")]
        public string ID_AI_FirstName
        {
            get { return _ID_AI_FirstName; }
            set { _ID_AI_FirstName = value; }
        }

        string _ID_AI_LastName;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_LastName.
        /// </summary>
        [TestVariable("d84b2186-3112-4178-be66-79fac5d4a6d2")]
        public string ID_AI_LastName
        {
            get { return _ID_AI_LastName; }
            set { _ID_AI_LastName = value; }
        }

        string _ID_AI_Address1;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_Address1.
        /// </summary>
        [TestVariable("d0751463-29f0-4748-b0aa-cb120125a6f9")]
        public string ID_AI_Address1
        {
            get { return _ID_AI_Address1; }
            set { _ID_AI_Address1 = value; }
        }

        string _ID_AI_Address2;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_Address2.
        /// </summary>
        [TestVariable("905fa78d-b258-4dec-b717-5f77fc1fe916")]
        public string ID_AI_Address2
        {
            get { return _ID_AI_Address2; }
            set { _ID_AI_Address2 = value; }
        }

        string _ID_AI_City;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_City.
        /// </summary>
        [TestVariable("5091b707-5072-40d0-b06a-6e71fb84c25c")]
        public string ID_AI_City
        {
            get { return _ID_AI_City; }
            set { _ID_AI_City = value; }
        }

        string _ID_AI_State;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_State.
        /// </summary>
        [TestVariable("6bd25fda-cb3e-48fb-886e-eed9d2d5bdbe")]
        public string ID_AI_State
        {
            get { return _ID_AI_State; }
            set { _ID_AI_State = value; }
        }

        string _ID_AI_Zipcode;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_Zipcode.
        /// </summary>
        [TestVariable("f74703cc-092c-4655-828e-5ca22314ebd0")]
        public string ID_AI_Zipcode
        {
            get { return _ID_AI_Zipcode; }
            set { _ID_AI_Zipcode = value; }
        }

        string _ID_AI_Email;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_Email.
        /// </summary>
        [TestVariable("5b866caf-54a7-4f5d-a218-8a5fbefc4b94")]
        public string ID_AI_Email
        {
            get { return _ID_AI_Email; }
            set { _ID_AI_Email = value; }
        }

        string _ID_AI_RepresentationDate;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_RepresentationDate.
        /// </summary>
        [TestVariable("80f73ee4-4215-48c0-9dde-58c17973a735")]
        public string ID_AI_RepresentationDate
        {
            get { return _ID_AI_RepresentationDate; }
            set { _ID_AI_RepresentationDate = value; }
        }

        string _ID_AI_UseType;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_UseType.
        /// </summary>
        [TestVariable("959a2665-b8fe-4c99-8199-198f8544ccb6")]
        public string ID_AI_UseType
        {
            get { return _ID_AI_UseType; }
            set { _ID_AI_UseType = value; }
        }

        string _ID_AI_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_PhoneType.
        /// </summary>
        [TestVariable("752ef18d-a520-42d6-9937-0bd2617b6adf")]
        public string ID_AI_PhoneType
        {
            get { return _ID_AI_PhoneType; }
            set { _ID_AI_PhoneType = value; }
        }

        string _ID_AI_Source;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_Source.
        /// </summary>
        [TestVariable("003ffaf4-e08b-4633-b2e3-43cd7d858826")]
        public string ID_AI_Source
        {
            get { return _ID_AI_Source; }
            set { _ID_AI_Source = value; }
        }

        string _ID_AI_Phone;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_Phone.
        /// </summary>
        [TestVariable("f0fbbee8-fac1-4fa6-9959-7d3ff483ddcd")]
        public string ID_AI_Phone
        {
            get { return _ID_AI_Phone; }
            set { _ID_AI_Phone = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_FirmName' with focus on 'ApplicationUnderTest.ID_AI_FirmName'.", repo.ApplicationUnderTest.ID_AI_FirmNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ID_AI_FirmName.PressKeys(ID_AI_FirmName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_FirstName' with focus on 'ApplicationUnderTest.ID_AI_FirstName'.", repo.ApplicationUnderTest.ID_AI_FirstNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ID_AI_FirstName.PressKeys(ID_AI_FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_LastName' with focus on 'ApplicationUnderTest.ID_AI_LastName'.", repo.ApplicationUnderTest.ID_AI_LastNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ID_AI_LastName.PressKeys(ID_AI_LastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_Address1' with focus on 'ApplicationUnderTest.ID_AI_Address1'.", repo.ApplicationUnderTest.ID_AI_Address1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ID_AI_Address1.PressKeys(ID_AI_Address1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_Address2' with focus on 'ApplicationUnderTest.ID_AI_Address2'.", repo.ApplicationUnderTest.ID_AI_Address2Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ID_AI_Address2.PressKeys(ID_AI_Address2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_City' with focus on 'ApplicationUnderTest.ID_AI_City'.", repo.ApplicationUnderTest.ID_AI_CityInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ID_AI_City.PressKeys(ID_AI_City);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_State' on item 'ApplicationUnderTest.ID_AI_State'.", repo.ApplicationUnderTest.ID_AI_StateInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.ID_AI_State.Element.SetAttributeValue("TagValue", ID_AI_State);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(7));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_Zipcode' with focus on 'ApplicationUnderTest.ID_AI_Zipcode'.", repo.ApplicationUnderTest.ID_AI_ZipcodeInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.ID_AI_Zipcode.PressKeys(ID_AI_Zipcode);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_Email' with focus on 'ApplicationUnderTest.ID_AI_Email'.", repo.ApplicationUnderTest.ID_AI_EmailInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.ID_AI_Email.PressKeys(ID_AI_Email);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_RepresentationDate' on item 'ApplicationUnderTest.ID_AI_RepresentationDate'.", repo.ApplicationUnderTest.ID_AI_RepresentationDateInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.ID_AI_RepresentationDate.Element.SetAttributeValue("TagValue", ID_AI_RepresentationDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(12));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(13));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(14));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_UseType' on item 'ApplicationUnderTest.ID_AI_UseType'.", repo.ApplicationUnderTest.ID_AI_UseTypeInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.ID_AI_UseType.Element.SetAttributeValue("TagValue", ID_AI_UseType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_PhoneType' on item 'ApplicationUnderTest.ID_AI_PhoneType'.", repo.ApplicationUnderTest.ID_AI_PhoneTypeInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.ID_AI_PhoneType.Element.SetAttributeValue("TagValue", ID_AI_PhoneType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_Source' on item 'ApplicationUnderTest.ID_AI_Source'.", repo.ApplicationUnderTest.ID_AI_SourceInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.ID_AI_Source.Element.SetAttributeValue("TagValue", ID_AI_Source);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_Phone' with focus on 'ApplicationUnderTest.ID_AI_Phone'.", repo.ApplicationUnderTest.ID_AI_PhoneInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.ID_AI_Phone.PressKeys(ID_AI_Phone);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(19));
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence '{Tab}'.", new RecordItemIndex(20));
                Keyboard.Press("{Tab}");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(20)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
