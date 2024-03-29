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
    ///The Edit_Adverse2_Driver_License_Information recording.
    /// </summary>
    [TestModule("1077a5ab-358b-445d-b341-c067bba05569", ModuleType.Recording, 1)]
    public partial class Edit_Adverse2_Driver_License_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Edit_Adverse2_Driver_License_Information instance = new Edit_Adverse2_Driver_License_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Edit_Adverse2_Driver_License_Information()
        {
            Edit_AD2_LI_DOB = "3/2/1993";
            Edit_AD2_LI_SSN = "400011SSNE";
            Edit_AD2_LI_DriversLicenseState = "LA";
            Edit_AD2_LI_LicenseNumber = "LICNO50001E";
            AD2_LI_LicenseNumber = "";
            AD2_LI_DriversLicenseState = "";
            AD2_LI_SSN = "";
            AD2_LI_DOB = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Edit_Adverse2_Driver_License_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _Edit_AD2_LI_DOB;

        /// <summary>
        /// Gets or sets the value of variable Edit_AD2_LI_DOB.
        /// </summary>
        [TestVariable("00ddfbcf-edd9-4467-9b80-d3b115e0ea30")]
        public string Edit_AD2_LI_DOB
        {
            get { return _Edit_AD2_LI_DOB; }
            set { _Edit_AD2_LI_DOB = value; }
        }

        string _Edit_AD2_LI_SSN;

        /// <summary>
        /// Gets or sets the value of variable Edit_AD2_LI_SSN.
        /// </summary>
        [TestVariable("5fde5c97-87e3-4891-9dbf-7f73f02c45c3")]
        public string Edit_AD2_LI_SSN
        {
            get { return _Edit_AD2_LI_SSN; }
            set { _Edit_AD2_LI_SSN = value; }
        }

        string _Edit_AD2_LI_DriversLicenseState;

        /// <summary>
        /// Gets or sets the value of variable Edit_AD2_LI_DriversLicenseState.
        /// </summary>
        [TestVariable("b9d1f5f7-bf57-4b63-a0d8-2dafc2debf99")]
        public string Edit_AD2_LI_DriversLicenseState
        {
            get { return _Edit_AD2_LI_DriversLicenseState; }
            set { _Edit_AD2_LI_DriversLicenseState = value; }
        }

        string _Edit_AD2_LI_LicenseNumber;

        /// <summary>
        /// Gets or sets the value of variable Edit_AD2_LI_LicenseNumber.
        /// </summary>
        [TestVariable("ef5bbca9-dce1-452f-a025-40f03e68ee85")]
        public string Edit_AD2_LI_LicenseNumber
        {
            get { return _Edit_AD2_LI_LicenseNumber; }
            set { _Edit_AD2_LI_LicenseNumber = value; }
        }

        string _AD2_LI_LicenseNumber;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_LicenseNumber.
        /// </summary>
        [TestVariable("322a0542-1f60-4ebe-87e4-61f57157db57")]
        public string AD2_LI_LicenseNumber
        {
            get { return _AD2_LI_LicenseNumber; }
            set { _AD2_LI_LicenseNumber = value; }
        }

        string _AD2_LI_DriversLicenseState;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_DriversLicenseState.
        /// </summary>
        [TestVariable("be3a9dc0-5e2b-4fbd-b2ae-a74da9366937")]
        public string AD2_LI_DriversLicenseState
        {
            get { return _AD2_LI_DriversLicenseState; }
            set { _AD2_LI_DriversLicenseState = value; }
        }

        string _AD2_LI_SSN;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_SSN.
        /// </summary>
        [TestVariable("837da2b2-045f-4237-9f35-6d9ddf88f951")]
        public string AD2_LI_SSN
        {
            get { return _AD2_LI_SSN; }
            set { _AD2_LI_SSN = value; }
        }

        string _AD2_LI_DOB;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_DOB.
        /// </summary>
        [TestVariable("f2be3082-a038-4422-b2d4-0f04d178c1d2")]
        public string AD2_LI_DOB
        {
            get { return _AD2_LI_DOB; }
            set { _AD2_LI_DOB = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AD2_LI_LicenseNumber' and assigning its value to variable 'AD2_LI_LicenseNumber'.", repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo, new RecordItemIndex(1));
            //AD2_LI_LicenseNumber = repo.ApplicationUnderTest.AD2_LI_LicenseNumber.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD2_LI_LicenseNumber) on item 'ApplicationUnderTest.AD2_LI_LicenseNumber'.", repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo, "TagValue", AD2_LI_LicenseNumber);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AD2_LI_LicenseNumber, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AD2_LI_LicenseNumber' with focus on 'ApplicationUnderTest.AD2_LI_LicenseNumber'.", repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AD2_LI_LicenseNumber.PressKeys(Edit_AD2_LI_LicenseNumber);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AD2_LI_DriversLicenseState' and assigning its value to variable 'AD2_LI_DriversLicenseState'.", repo.ApplicationUnderTest.AD2_LI_DriversLicenseStateInfo, new RecordItemIndex(7));
            //AD2_LI_DriversLicenseState = repo.ApplicationUnderTest.AD2_LI_DriversLicenseState.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD2_LI_DriversLicenseState) on item 'ApplicationUnderTest.AD2_LI_DriversLicenseState'.", repo.ApplicationUnderTest.AD2_LI_DriversLicenseStateInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD2_LI_DriversLicenseStateInfo, "TagValue", AD2_LI_DriversLicenseState);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AD2_LI_DriversLicenseState, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AD2_LI_DriversLicenseState' with focus on 'ApplicationUnderTest.AD2_LI_DriversLicenseState'.", repo.ApplicationUnderTest.AD2_LI_DriversLicenseStateInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AD2_LI_DriversLicenseState.PressKeys(Edit_AD2_LI_DriversLicenseState);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AD2_LI_SSN' and assigning its value to variable 'AD2_LI_SSN'.", repo.ApplicationUnderTest.AD2_LI_SSNInfo, new RecordItemIndex(13));
            AD2_LI_SSN = repo.ApplicationUnderTest.AD2_LI_SSN.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AD2_LI_SSN, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD2_LI_SSN) on item 'ApplicationUnderTest.AD2_LI_SSN'.", repo.ApplicationUnderTest.AD2_LI_SSNInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD2_LI_SSNInfo, "TagValue", AD2_LI_SSN);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(16));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AD2_LI_SSN' with focus on 'ApplicationUnderTest.AD2_LI_SSN'.", repo.ApplicationUnderTest.AD2_LI_SSNInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.AD2_LI_SSN.PressKeys(Edit_AD2_LI_SSN);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AD2_LI_DOB' and assigning its value to variable 'AD2_LI_DOB'.", repo.ApplicationUnderTest.AD2_LI_DOBInfo, new RecordItemIndex(19));
            AD2_LI_DOB = repo.ApplicationUnderTest.AD2_LI_DOB.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AD2_LI_DOB, new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AD2_LI_DOB) on item 'ApplicationUnderTest.AD2_LI_DOB'.", repo.ApplicationUnderTest.AD2_LI_DOBInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD2_LI_DOBInfo, "TagValue", AD2_LI_DOB);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(22));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(23));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edit_AD2_LI_DOB' with focus on 'ApplicationUnderTest.AD2_LI_DOB'.", repo.ApplicationUnderTest.AD2_LI_DOBInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.AD2_LI_DOB.PressKeys(Edit_AD2_LI_DOB);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(25));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Save_Button' at 6;8.", repo.ApplicationUnderTest.Save_ButtonInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.Save_Button.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Edit_AD2_LI_LicenseNumber) on item 'ApplicationUnderTest.AD2_LI_LicenseNumber'.", repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo, "TagValue", Edit_AD2_LI_LicenseNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AD2_LI_LicenseNumber, new RecordItemIndex(28));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Edit_AD2_LI_DriversLicenseState) on item 'ApplicationUnderTest.AD2_LI_DriversLicenseState'.", repo.ApplicationUnderTest.AD2_LI_DriversLicenseStateInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD2_LI_DriversLicenseStateInfo, "TagValue", Edit_AD2_LI_DriversLicenseState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AD2_LI_DriversLicenseState, new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Edit_AD2_LI_SSN) on item 'ApplicationUnderTest.AD2_LI_SSN'.", repo.ApplicationUnderTest.AD2_LI_SSNInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD2_LI_SSNInfo, "TagValue", Edit_AD2_LI_SSN);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AD2_LI_SSN, new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$Edit_AD2_LI_DOB) on item 'ApplicationUnderTest.AD2_LI_DOB'.", repo.ApplicationUnderTest.AD2_LI_DOBInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AD2_LI_DOBInfo, "TagValue", Edit_AD2_LI_DOB);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Edit_AD2_LI_DOB, new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubmitButton1' at 46;15.", repo.ApplicationUnderTest.SubmitButton1Info, new RecordItemIndex(35));
            repo.ApplicationUnderTest.SubmitButton1.Click("46;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
