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
    ///The Adverse1_Vehicle_Details recording.
    /// </summary>
    [TestModule("14f92eb6-f7ec-438a-b22f-749b8ce6bc55", ModuleType.Recording, 1)]
    public partial class Adverse1_Vehicle_Details : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse1_Vehicle_Details instance = new Adverse1_Vehicle_Details();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse1_Vehicle_Details()
        {
            Adverse1_LicensePlate = "";
            Adverse1_LicensePlateState = "";
            AD1_Vin_Year = "";
            AD1_VIN_Make = "";
            AD1_VIN_Model = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse1_Vehicle_Details Instance
        {
            get { return instance; }
        }

#region Variables

        string _Adverse1_LicensePlate;

        /// <summary>
        /// Gets or sets the value of variable Adverse1_LicensePlate.
        /// </summary>
        [TestVariable("111e0f4e-1292-414d-9a47-aa6759ce5804")]
        public string Adverse1_LicensePlate
        {
            get { return _Adverse1_LicensePlate; }
            set { _Adverse1_LicensePlate = value; }
        }

        string _Adverse1_LicensePlateState;

        /// <summary>
        /// Gets or sets the value of variable Adverse1_LicensePlateState.
        /// </summary>
        [TestVariable("662bfc75-0be2-49cd-b1cf-47ff3014cbb1")]
        public string Adverse1_LicensePlateState
        {
            get { return _Adverse1_LicensePlateState; }
            set { _Adverse1_LicensePlateState = value; }
        }

        string _AD1_Vin_Year;

        /// <summary>
        /// Gets or sets the value of variable AD1_Vin_Year.
        /// </summary>
        [TestVariable("d9c8867b-2c08-4a8c-9479-7e8a7e2fef71")]
        public string AD1_Vin_Year
        {
            get { return _AD1_Vin_Year; }
            set { _AD1_Vin_Year = value; }
        }

        string _AD1_VIN_Make;

        /// <summary>
        /// Gets or sets the value of variable AD1_VIN_Make.
        /// </summary>
        [TestVariable("5145ec0f-d4ae-4d2e-8a4c-6e5be7ede1b6")]
        public string AD1_VIN_Make
        {
            get { return _AD1_VIN_Make; }
            set { _AD1_VIN_Make = value; }
        }

        string _AD1_VIN_Model;

        /// <summary>
        /// Gets or sets the value of variable AD1_VIN_Model.
        /// </summary>
        [TestVariable("b6250338-792c-4e39-9cac-25af97d77efa")]
        public string AD1_VIN_Model
        {
            get { return _AD1_VIN_Model; }
            set { _AD1_VIN_Model = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.Adverse1_Vin_yes'", repo.ApplicationUnderTest.Adverse1_Vin_yesInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.Adverse1_Vin_yesInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Adverse1_LicensePlate' with focus on 'ApplicationUnderTest.Adverse1_LicensePlate'.", repo.ApplicationUnderTest.Adverse1_LicensePlateInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Adverse1_LicensePlate.PressKeys(Adverse1_LicensePlate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$Adverse1_LicensePlateState' on item 'ApplicationUnderTest.Adverse1_LicensePlateState'.", repo.ApplicationUnderTest.Adverse1_LicensePlateStateInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Adverse1_LicensePlateState.Element.SetAttributeValue("TagValue", Adverse1_LicensePlateState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AD1_V1_Enter_Manually' at Center.", repo.ApplicationUnderTest.AD1_V1_Enter_ManuallyInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AD1_V1_Enter_Manually.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD1_Vin_Year' on item 'ApplicationUnderTest.AD1_Vin_Year'.", repo.ApplicationUnderTest.AD1_Vin_YearInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AD1_Vin_Year.Element.SetAttributeValue("TagValue", AD1_Vin_Year);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AD1_VIN_Make' at Center.", repo.ApplicationUnderTest.AD1_VIN_MakeInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.AD1_VIN_Make.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AD1_VIN_Make' with focus on 'ApplicationUnderTest.AD1_VIN_Make'.", repo.ApplicationUnderTest.AD1_VIN_MakeInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.AD1_VIN_Make.PressKeys(AD1_VIN_Make);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(10));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(11));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.AD1_VIN_Make_Toyota' at Center.", repo.ApplicationUnderTest.AD1_VIN_Make_ToyotaInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AD1_VIN_Make_Toyota.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(13));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AD1_VIN_Model' on item 'ApplicationUnderTest.AD1_VIN_Model'.", repo.ApplicationUnderTest.AD1_VIN_ModelInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.AD1_VIN_Model.Element.SetAttributeValue("TagValue", AD1_VIN_Model);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(15));
            Delay.Duration(10000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.AD1_VIN_Make_Toyota'", repo.ApplicationUnderTest.AD1_VIN_Make_ToyotaInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.ApplicationUnderTest.AD1_VIN_Make_ToyotaInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
