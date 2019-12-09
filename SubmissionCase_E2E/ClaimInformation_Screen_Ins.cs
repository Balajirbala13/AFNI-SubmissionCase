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
    ///The ClaimInformation_Screen_Ins recording.
    /// </summary>
    [TestModule("92873fce-0e4f-4aec-a140-627c7454e415", ModuleType.Recording, 1)]
    public partial class ClaimInformation_Screen_Ins : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static ClaimInformation_Screen_Ins instance = new ClaimInformation_Screen_Ins();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClaimInformation_Screen_Ins()
        {
            ClaimInformation_AccoutType = "";
            ClaimInformation_ProjectName = "";
            ClaimInformation_ClaimType = "";
            ClaimInformation_Product = "";
            ClaimInformation_DateOfLoss = "";
            ClaimInformation_AmountofLoss = "";
            ClaimInformation_DeductibleAmount = "";
            ClaimInformation_StateOfLoss = "";
            ClaimInformation_City = "";
            ClaimInformation_AFNI_Liability = "";
            ClaimInformation_AccidentType = "";
            ClaimInformation_IncidentFacts = "";
            ClaimInformation_Police_Report_No = "";
            ClaimInformation_Client_Liability = "";
            ClaimInformation_Street = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClaimInformation_Screen_Ins Instance
        {
            get { return instance; }
        }

#region Variables

        string _ClaimInformation_AccoutType;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AccoutType.
        /// </summary>
        [TestVariable("33e35823-71f6-4031-b011-07bc239ec898")]
        public string ClaimInformation_AccoutType
        {
            get { return _ClaimInformation_AccoutType; }
            set { _ClaimInformation_AccoutType = value; }
        }

        string _ClaimInformation_ProjectName;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ProjectName.
        /// </summary>
        [TestVariable("465cf818-f4b3-43c6-8b32-9f1bc127d0ee")]
        public string ClaimInformation_ProjectName
        {
            get { return _ClaimInformation_ProjectName; }
            set { _ClaimInformation_ProjectName = value; }
        }

        string _ClaimInformation_ClaimType;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClaimType.
        /// </summary>
        [TestVariable("c80b9344-5886-45dd-949b-7fc359f27686")]
        public string ClaimInformation_ClaimType
        {
            get { return _ClaimInformation_ClaimType; }
            set { _ClaimInformation_ClaimType = value; }
        }

        string _ClaimInformation_Product;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Product.
        /// </summary>
        [TestVariable("5fca39d1-7846-4b11-9816-6b2bb9816a06")]
        public string ClaimInformation_Product
        {
            get { return _ClaimInformation_Product; }
            set { _ClaimInformation_Product = value; }
        }

        string _ClaimInformation_DateOfLoss;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_DateOfLoss.
        /// </summary>
        [TestVariable("4329b527-288b-4e39-8294-3227ba5738de")]
        public string ClaimInformation_DateOfLoss
        {
            get { return _ClaimInformation_DateOfLoss; }
            set { _ClaimInformation_DateOfLoss = value; }
        }

        string _ClaimInformation_AmountofLoss;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AmountofLoss.
        /// </summary>
        [TestVariable("b0e9005a-aaed-403a-874c-5e5346617dda")]
        public string ClaimInformation_AmountofLoss
        {
            get { return _ClaimInformation_AmountofLoss; }
            set { _ClaimInformation_AmountofLoss = value; }
        }

        string _ClaimInformation_DeductibleAmount;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_DeductibleAmount.
        /// </summary>
        [TestVariable("1e57cc00-4bab-40f6-8316-0c8f75584be4")]
        public string ClaimInformation_DeductibleAmount
        {
            get { return _ClaimInformation_DeductibleAmount; }
            set { _ClaimInformation_DeductibleAmount = value; }
        }

        string _ClaimInformation_StateOfLoss;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_StateOfLoss.
        /// </summary>
        [TestVariable("304ac84b-dab1-465a-8dd6-cae9c5a9e745")]
        public string ClaimInformation_StateOfLoss
        {
            get { return _ClaimInformation_StateOfLoss; }
            set { _ClaimInformation_StateOfLoss = value; }
        }

        string _ClaimInformation_City;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_City.
        /// </summary>
        [TestVariable("806276f2-f137-446f-a92d-4fc8ff6f0619")]
        public string ClaimInformation_City
        {
            get { return _ClaimInformation_City; }
            set { _ClaimInformation_City = value; }
        }

        string _ClaimInformation_AFNI_Liability;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AFNI_Liability.
        /// </summary>
        [TestVariable("9bbad484-0b17-453c-8c21-9b86719e1e68")]
        public string ClaimInformation_AFNI_Liability
        {
            get { return _ClaimInformation_AFNI_Liability; }
            set { _ClaimInformation_AFNI_Liability = value; }
        }

        string _ClaimInformation_AccidentType;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AccidentType.
        /// </summary>
        [TestVariable("03096d79-e3d4-477c-874b-22cd81104f73")]
        public string ClaimInformation_AccidentType
        {
            get { return _ClaimInformation_AccidentType; }
            set { _ClaimInformation_AccidentType = value; }
        }

        string _ClaimInformation_IncidentFacts;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_IncidentFacts.
        /// </summary>
        [TestVariable("05f1ba91-d54f-49b2-9704-9eca994c0a36")]
        public string ClaimInformation_IncidentFacts
        {
            get { return _ClaimInformation_IncidentFacts; }
            set { _ClaimInformation_IncidentFacts = value; }
        }

        string _ClaimInformation_Police_Report_No;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Police_Report_No.
        /// </summary>
        [TestVariable("d8bdd158-3d06-44c7-bb6f-b6880da65ffc")]
        public string ClaimInformation_Police_Report_No
        {
            get { return _ClaimInformation_Police_Report_No; }
            set { _ClaimInformation_Police_Report_No = value; }
        }

        string _ClaimInformation_Client_Liability;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Client_Liability.
        /// </summary>
        [TestVariable("4fa9c59f-64bf-4039-9cfd-0677e96840ca")]
        public string ClaimInformation_Client_Liability
        {
            get { return _ClaimInformation_Client_Liability; }
            set { _ClaimInformation_Client_Liability = value; }
        }

        string _ClaimInformation_Street;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Street.
        /// </summary>
        [TestVariable("e6f1e876-fa23-434d-ad5a-e880077c755d")]
        public string ClaimInformation_Street
        {
            get { return _ClaimInformation_Street; }
            set { _ClaimInformation_Street = value; }
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

            // Claim Information screen
            Report.Log(ReportLevel.Info, "Section", "Claim Information screen", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'ApplicationUnderTest.ClaimInformation_AccountType'", repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo, new ActionTimeout(45000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo.WaitForExists(45000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pending-ClaimInformation') on item 'ApplicationUnderTest.Pending_ClaimInformation'.", repo.ApplicationUnderTest.Pending_ClaimInformationInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Pending_ClaimInformationInfo, "InnerText", "Pending-ClaimInformation");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_AccoutType' on item 'ApplicationUnderTest.ClaimInformation_AccountType'.", repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ClaimInformation_AccountType.Element.SetAttributeValue("TagValue", ClaimInformation_AccoutType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_ProjectName' on item 'ApplicationUnderTest.ClaimInformation_ProjectName'.", repo.ApplicationUnderTest.ClaimInformation_ProjectNameInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ClaimInformation_ProjectName.Element.SetAttributeValue("TagValue", ClaimInformation_ProjectName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_ClaimType' on item 'ApplicationUnderTest.ClaimInformation_ClaimType'.", repo.ApplicationUnderTest.ClaimInformation_ClaimTypeInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ClaimInformation_ClaimType.Element.SetAttributeValue("TagValue", ClaimInformation_ClaimType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.ClaimInformation_Product'", repo.ApplicationUnderTest.ClaimInformation_ProductInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.ApplicationUnderTest.ClaimInformation_ProductInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_Product' on item 'ApplicationUnderTest.ClaimInformation_Product'.", repo.ApplicationUnderTest.ClaimInformation_ProductInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.ClaimInformation_Product.Element.SetAttributeValue("TagValue", ClaimInformation_Product);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_DateOfLoss' on item 'ApplicationUnderTest.ClaimInformation_DateOfLoss'.", repo.ApplicationUnderTest.ClaimInformation_DateOfLossInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.ClaimInformation_DateOfLoss.Element.SetAttributeValue("TagValue", ClaimInformation_DateOfLoss);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClaimInformation_AmountofLoss' with focus on 'ApplicationUnderTest.ClaimInformation_AmountofLoss'.", repo.ApplicationUnderTest.ClaimInformation_AmountofLossInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.ClaimInformation_AmountofLoss.PressKeys(ClaimInformation_AmountofLoss);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_AmountofLoss' on item 'ApplicationUnderTest.ClaimInformation_AmountofLoss'.", repo.ApplicationUnderTest.ClaimInformation_AmountofLossInfo, new RecordItemIndex(12));
            //repo.ApplicationUnderTest.ClaimInformation_AmountofLoss.Element.SetAttributeValue("TagValue", ClaimInformation_AmountofLoss);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(13));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClaimInformation_DeductibleAmount' with focus on 'ApplicationUnderTest.ClaimInformation_DeductibleAmount'.", repo.ApplicationUnderTest.ClaimInformation_DeductibleAmountInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.ClaimInformation_DeductibleAmount.PressKeys(ClaimInformation_DeductibleAmount);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_DeductibleAmount' on item 'ApplicationUnderTest.ClaimInformation_DeductibleAmount'.", repo.ApplicationUnderTest.ClaimInformation_DeductibleAmountInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.ClaimInformation_DeductibleAmount.Element.SetAttributeValue("TagValue", ClaimInformation_DeductibleAmount);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(16));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_Street' on item 'ApplicationUnderTest.ClaimInformation_Street'.", repo.ApplicationUnderTest.ClaimInformation_StreetInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.ClaimInformation_Street.Element.SetAttributeValue("TagValue", ClaimInformation_Street);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(19));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_City' on item 'ApplicationUnderTest.ClaimInformation_City'.", repo.ApplicationUnderTest.ClaimInformation_CityInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.ClaimInformation_City.Element.SetAttributeValue("TagValue", ClaimInformation_City);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(21));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_StateOfLoss' on item 'ApplicationUnderTest.ClaimInformation_StateOfLoss'.", repo.ApplicationUnderTest.ClaimInformation_StateOfLossInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.ClaimInformation_StateOfLoss.Element.SetAttributeValue("TagValue", ClaimInformation_StateOfLoss);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(23));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClaimInformation_Police_Report_No' with focus on 'ApplicationUnderTest.ClaimInformation_PoliceReportNo'.", repo.ApplicationUnderTest.ClaimInformation_PoliceReportNoInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.ClaimInformation_PoliceReportNo.PressKeys(ClaimInformation_Police_Report_No);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(25));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClaimInformation_AFNI_Liability' with focus on 'ApplicationUnderTest.ClaimInformation_AFNI_Liability'.", repo.ApplicationUnderTest.ClaimInformation_AFNI_LiabilityInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.ClaimInformation_AFNI_Liability.PressKeys(ClaimInformation_AFNI_Liability);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(27));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClaimInformation_Client_Liability' with focus on 'ApplicationUnderTest.ClaimInformation_Client_Liability'.", repo.ApplicationUnderTest.ClaimInformation_Client_LiabilityInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.ClaimInformation_Client_Liability.PressKeys(ClaimInformation_Client_Liability);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(29));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimInformation_AccidentType' on item 'ApplicationUnderTest.ClaimInformation_Accident_Type'.", repo.ApplicationUnderTest.ClaimInformation_Accident_TypeInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.ClaimInformation_Accident_Type.Element.SetAttributeValue("TagValue", ClaimInformation_AccidentType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(32));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ClaimInformation_TotalLoss' at 6;8.", repo.ApplicationUnderTest.ClaimInformation_TotalLossInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.ClaimInformation_TotalLoss.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.ClaimInformation_TotalLoss_True'", repo.ApplicationUnderTest.ClaimInformation_TotalLoss_TrueInfo, new ActionTimeout(30000), new RecordItemIndex(34));
            repo.ApplicationUnderTest.ClaimInformation_TotalLoss_TrueInfo.WaitForExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ApplicationUnderTest.ClaimInformation_TotalLoss, false, new RecordItemIndex(35));
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test' with focus on 'ApplicationUnderTest.ClaimInformation_IncidentFacts'.", repo.ApplicationUnderTest.ClaimInformation_IncidentFactsInfo, new RecordItemIndex(36));
            //repo.ApplicationUnderTest.ClaimInformation_IncidentFacts.PressKeys("Test");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClaimInformation_IncidentFacts' with focus on 'ApplicationUnderTest.ClaimInformation_IncidentFacts'.", repo.ApplicationUnderTest.ClaimInformation_IncidentFactsInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.ClaimInformation_IncidentFacts.PressKeys(ClaimInformation_IncidentFacts);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(38));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubmitButton1' at 41;11.", repo.ApplicationUnderTest.SubmitButton1Info, new RecordItemIndex(39));
            //repo.ApplicationUnderTest.SubmitButton1.Click("41;11");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}