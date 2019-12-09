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
    ///The Adverse2_Driver_License_Information recording.
    /// </summary>
    [TestModule("92c013e3-8270-4233-a9d1-9e90d208b1dc", ModuleType.Recording, 1)]
    public partial class Adverse2_Driver_License_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse2_Driver_License_Information instance = new Adverse2_Driver_License_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse2_Driver_License_Information()
        {
            AD2_LI_LicenseNumber = "";
            AD2_LI_DriversLicenseState = "";
            AD2_LI_SSN = "";
            AD2_LI_DOB = "";
            AD2_LI_RevocationDate = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse2_Driver_License_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _AD2_LI_LicenseNumber;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_LicenseNumber.
        /// </summary>
        [TestVariable("e53f5d32-4da7-43ec-bd0b-98cd7120e38c")]
        public string AD2_LI_LicenseNumber
        {
            get { return _AD2_LI_LicenseNumber; }
            set { _AD2_LI_LicenseNumber = value; }
        }

        string _AD2_LI_DriversLicenseState;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_DriversLicenseState.
        /// </summary>
        [TestVariable("d525eaee-4521-4880-83e9-437f3d3681c0")]
        public string AD2_LI_DriversLicenseState
        {
            get { return _AD2_LI_DriversLicenseState; }
            set { _AD2_LI_DriversLicenseState = value; }
        }

        string _AD2_LI_SSN;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_SSN.
        /// </summary>
        [TestVariable("6aeac42d-6312-40c3-a1d0-e1ea6cde3c02")]
        public string AD2_LI_SSN
        {
            get { return _AD2_LI_SSN; }
            set { _AD2_LI_SSN = value; }
        }

        string _AD2_LI_DOB;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_DOB.
        /// </summary>
        [TestVariable("428a4802-9246-45af-b9f3-0cf2f744018c")]
        public string AD2_LI_DOB
        {
            get { return _AD2_LI_DOB; }
            set { _AD2_LI_DOB = value; }
        }

        string _AD2_LI_RevocationDate;

        /// <summary>
        /// Gets or sets the value of variable AD2_LI_RevocationDate.
        /// </summary>
        [TestVariable("be3c9145-a70f-49ae-94e9-dd857de496e2")]
        public string AD2_LI_RevocationDate
        {
            get { return _AD2_LI_RevocationDate; }
            set { _AD2_LI_RevocationDate = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.AD2_LI_LicenseNumber'", repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD2_LI_LicenseNumber' with focus on 'ApplicationUnderTest.AD2_LI_LicenseNumber'.", repo.ApplicationUnderTest.AD2_LI_LicenseNumberInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AD2_LI_LicenseNumber.PressKeys(AD2_LI_LicenseNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD2_LI_DriversLicenseState' on item 'ApplicationUnderTest.AD2_LI_DriversLicenseState'.", repo.ApplicationUnderTest.AD2_LI_DriversLicenseStateInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AD2_LI_DriversLicenseState.Element.SetAttributeValue("TagValue", AD2_LI_DriversLicenseState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD2_LI_SSN' with focus on 'ApplicationUnderTest.AD2_LI_SSN'.", repo.ApplicationUnderTest.AD2_LI_SSNInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AD2_LI_SSN.PressKeys(AD2_LI_SSN);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD2_LI_DOB' with focus on 'ApplicationUnderTest.AD2_LI_DOB'.", repo.ApplicationUnderTest.AD2_LI_DOBInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AD2_LI_DOB.PressKeys(AD2_LI_DOB);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(7));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD2_LI_RevocationDate' with focus on 'ApplicationUnderTest.AD2_LI_RevocationDate'.", repo.ApplicationUnderTest.AD2_LI_RevocationDateInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.AD2_LI_RevocationDate.PressKeys(AD2_LI_RevocationDate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(10));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(11));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
