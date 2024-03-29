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
    ///The Edit_Insured_Company_Information_FooterMapping recording.
    /// </summary>
    [TestModule("3a133659-1a63-4bb6-b7eb-6d2f941df886", ModuleType.Recording, 1)]
    public partial class Edit_Insured_Company_Information_FooterMapping : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Edit_Insured_Company_Information_FooterMapping instance = new Edit_Insured_Company_Information_FooterMapping();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Edit_Insured_Company_Information_FooterMapping()
        {
            ID_CI_ClaimNumber = "";
            ID_CI_PolicyNumber = "";
            ID_CI_ContactNumber = "";
            ID_CI_Address1 = "";
            ID_CI_Address2 = "";
            ID_CI_City = "";
            ID_CI_State = "";
            ID_CI_Zip = "";
            ID_CI_UseType = "";
            ID_CI_PhoneType = "";
            ID_CI_Source = "";
            ID_CI_PhoneNumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Edit_Insured_Company_Information_FooterMapping Instance
        {
            get { return instance; }
        }

#region Variables

        string _ID_CI_ClaimNumber;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_ClaimNumber.
        /// </summary>
        [TestVariable("bdf028ed-83d1-4f50-beb6-dba3cd0026a2")]
        public string ID_CI_ClaimNumber
        {
            get { return _ID_CI_ClaimNumber; }
            set { _ID_CI_ClaimNumber = value; }
        }

        string _ID_CI_PolicyNumber;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_PolicyNumber.
        /// </summary>
        [TestVariable("151d815c-a531-4b64-afd2-e9ad8a2f6365")]
        public string ID_CI_PolicyNumber
        {
            get { return _ID_CI_PolicyNumber; }
            set { _ID_CI_PolicyNumber = value; }
        }

        string _ID_CI_ContactNumber;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_ContactNumber.
        /// </summary>
        [TestVariable("37ac3808-ff9e-4130-9bf3-6f1da16be3a6")]
        public string ID_CI_ContactNumber
        {
            get { return _ID_CI_ContactNumber; }
            set { _ID_CI_ContactNumber = value; }
        }

        string _ID_CI_Address1;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_Address1.
        /// </summary>
        [TestVariable("cf358fc7-d31b-4d50-ba8b-06108c55c5e5")]
        public string ID_CI_Address1
        {
            get { return _ID_CI_Address1; }
            set { _ID_CI_Address1 = value; }
        }

        string _ID_CI_Address2;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_Address2.
        /// </summary>
        [TestVariable("fa4da4c2-f94d-4f79-a566-25ad79756aeb")]
        public string ID_CI_Address2
        {
            get { return _ID_CI_Address2; }
            set { _ID_CI_Address2 = value; }
        }

        string _ID_CI_City;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_City.
        /// </summary>
        [TestVariable("0d017709-ddf5-4629-b02e-77678b5ac69f")]
        public string ID_CI_City
        {
            get { return _ID_CI_City; }
            set { _ID_CI_City = value; }
        }

        string _ID_CI_State;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_State.
        /// </summary>
        [TestVariable("51fcf2e0-a03e-431c-8c2d-7335d34da274")]
        public string ID_CI_State
        {
            get { return _ID_CI_State; }
            set { _ID_CI_State = value; }
        }

        string _ID_CI_Zip;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_Zip.
        /// </summary>
        [TestVariable("d0a1d72a-1554-4c61-ba9c-fd3ae3445d9f")]
        public string ID_CI_Zip
        {
            get { return _ID_CI_Zip; }
            set { _ID_CI_Zip = value; }
        }

        string _ID_CI_UseType;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_UseType.
        /// </summary>
        [TestVariable("ec25c9e7-1181-4983-a4b7-09af4583510d")]
        public string ID_CI_UseType
        {
            get { return _ID_CI_UseType; }
            set { _ID_CI_UseType = value; }
        }

        string _ID_CI_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_PhoneType.
        /// </summary>
        [TestVariable("52c43521-7fff-4063-b757-06b7c2443612")]
        public string ID_CI_PhoneType
        {
            get { return _ID_CI_PhoneType; }
            set { _ID_CI_PhoneType = value; }
        }

        string _ID_CI_Source;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_Source.
        /// </summary>
        [TestVariable("46f7ee1c-0839-4734-ada3-6b9f472de961")]
        public string ID_CI_Source
        {
            get { return _ID_CI_Source; }
            set { _ID_CI_Source = value; }
        }

        string _ID_CI_PhoneNumber;

        /// <summary>
        /// Gets or sets the value of variable ID_CI_PhoneNumber.
        /// </summary>
        [TestVariable("d4421c8a-2df1-4b5a-9ee1-5e74a364a7ea")]
        public string ID_CI_PhoneNumber
        {
            get { return _ID_CI_PhoneNumber; }
            set { _ID_CI_PhoneNumber = value; }
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Adjuster Information') on item 'ApplicationUnderTest.FooterMappingAdjuster_Information'.", repo.ApplicationUnderTest.FooterMappingAdjuster_InformationInfo, new RecordItemIndex(0));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAdjuster_InformationInfo, "Text", "Adjuster Information");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Footer_ClaimInfo' at 50;13.", repo.ApplicationUnderTest.Footer_ClaimInfoInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Footer_ClaimInfo.Click("50;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Insured_Info' at 56;6.", repo.ApplicationUnderTest.Insured_InfoInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Insured_Info.Click("56;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(5));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Insured Insurance Info') on item 'ApplicationUnderTest.FooterMappingInsured_Insurance_Info'.", repo.ApplicationUnderTest.FooterMappingInsured_Insurance_InfoInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingInsured_Insurance_InfoInfo, "InnerText", "Insured Insurance Info");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Insurance Company') on item 'ApplicationUnderTest.FooterMappingInsurance_Company'.", repo.ApplicationUnderTest.FooterMappingInsurance_CompanyInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingInsurance_CompanyInfo, "InnerText", "Insurance Company");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='NATIONAL UNITY INSURANCE CO') on item 'ApplicationUnderTest.FooterMappingInsurance_Company_Value'.", repo.ApplicationUnderTest.FooterMappingInsurance_Company_ValueInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingInsurance_Company_ValueInfo, "InnerText", "NATIONAL UNITY INSURANCE CO");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Claim Number') on item 'ApplicationUnderTest.FooterMappingClaim_Number'.", repo.ApplicationUnderTest.FooterMappingClaim_NumberInfo, new RecordItemIndex(9));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingClaim_NumberInfo, "InnerText", "Claim Number");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_ClaimNumber) on item 'ApplicationUnderTest.FooterMappingID_CI_ClaimNumber'.", repo.ApplicationUnderTest.FooterMappingID_CI_ClaimNumberInfo, new RecordItemIndex(10));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_CI_ClaimNumberInfo, "InnerText", ID_CI_ClaimNumber);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "User", ID_CI_ClaimNumber, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Policy Number') on item 'ApplicationUnderTest.FooterMappingPolicy_Number'.", repo.ApplicationUnderTest.FooterMappingPolicy_NumberInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingPolicy_NumberInfo, "InnerText", "Policy Number");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_PolicyNumber) on item 'ApplicationUnderTest.FooterMappingID_CI_PolicyNumber'.", repo.ApplicationUnderTest.FooterMappingID_CI_PolicyNumberInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_CI_PolicyNumberInfo, "InnerText", ID_CI_PolicyNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_PolicyNumber, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Contact Name') on item 'ApplicationUnderTest.FooterMappingContact_Name'.", repo.ApplicationUnderTest.FooterMappingContact_NameInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingContact_NameInfo, "InnerText", "Contact Name");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_ContactNumber) on item 'ApplicationUnderTest.FooterMappingID_CI_ContactNumber'.", repo.ApplicationUnderTest.FooterMappingID_CI_ContactNumberInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_CI_ContactNumberInfo, "InnerText", ID_CI_ContactNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_ContactNumber, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Address1') on item 'ApplicationUnderTest.FooterMappingAddress1'.", repo.ApplicationUnderTest.FooterMappingAddress1Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAddress1Info, "InnerText", "Address1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_Address1) on item 'ApplicationUnderTest.FooterMappingID_CI_Address1'.", repo.ApplicationUnderTest.FooterMappingID_CI_Address1Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_CI_Address1Info, "InnerText", ID_CI_Address1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_Address1, new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Address2') on item 'ApplicationUnderTest.FooterMappingAddress2'.", repo.ApplicationUnderTest.FooterMappingAddress2Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAddress2Info, "InnerText", "Address2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_Address2) on item 'ApplicationUnderTest.FooterMappingID_CI_Address2'.", repo.ApplicationUnderTest.FooterMappingID_CI_Address2Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_CI_Address2Info, "InnerText", ID_CI_Address2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_Address2, new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='City') on item 'ApplicationUnderTest.FooterMappingAddress_City'.", repo.ApplicationUnderTest.FooterMappingAddress_CityInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAddress_CityInfo, "InnerText", "City");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_City) on item 'ApplicationUnderTest.FooterMappingID_CI_City'.", repo.ApplicationUnderTest.FooterMappingID_CI_CityInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_CI_CityInfo, "InnerText", ID_CI_City);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_City, new RecordItemIndex(26));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='State') on item 'ApplicationUnderTest.FooterMappingState'.", repo.ApplicationUnderTest.FooterMappingStateInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingStateInfo, "InnerText", "State");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_State) on item 'ApplicationUnderTest.FooterMappingID_State'.", repo.ApplicationUnderTest.FooterMappingID_StateInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_StateInfo, "InnerText", ID_CI_State);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_State, new RecordItemIndex(29));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Zip') on item 'ApplicationUnderTest.FooterMappingZip'.", repo.ApplicationUnderTest.FooterMappingZipInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingZipInfo, "InnerText", "Zip");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FooterMappingIDZip' and assigning its value to variable 'ID_CI_Zip'.", repo.ApplicationUnderTest.FooterMappingIDZipInfo, new RecordItemIndex(31));
            ID_CI_Zip = repo.ApplicationUnderTest.FooterMappingIDZip.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_Zip) on item 'ApplicationUnderTest.FooterMappingIDZip'.", repo.ApplicationUnderTest.FooterMappingIDZipInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingIDZipInfo, "InnerText", ID_CI_Zip);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_Zip, new RecordItemIndex(33));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Phone/Fax Information') on item 'ApplicationUnderTest.FooterMappingAD1PIPhoneInformation'.", repo.ApplicationUnderTest.FooterMappingAD1PIPhoneInformationInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1PIPhoneInformationInfo, "InnerText", "Phone/Fax Information");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Use Type') on item 'ApplicationUnderTest.FooterMappingAD1PIUseType'.", repo.ApplicationUnderTest.FooterMappingAD1PIUseTypeInfo, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1PIUseTypeInfo, "InnerText", "Use Type");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FooterMappingAD1LIBusiness' and assigning its value to variable 'ID_CI_UseType'.", repo.ApplicationUnderTest.FooterMappingAD1LIBusinessInfo, new RecordItemIndex(36));
            ID_CI_UseType = repo.ApplicationUnderTest.FooterMappingAD1LIBusiness.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_UseType) on item 'ApplicationUnderTest.FooterMappingAD1LIBusiness'.", repo.ApplicationUnderTest.FooterMappingAD1LIBusinessInfo, new RecordItemIndex(37));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1LIBusinessInfo, "InnerText", ID_CI_UseType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_UseType, new RecordItemIndex(38));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Phone Type') on item 'ApplicationUnderTest.FooterMappingAO1_LI_PhoneType'.", repo.ApplicationUnderTest.FooterMappingAO1_LI_PhoneTypeInfo, new RecordItemIndex(39));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAO1_LI_PhoneTypeInfo, "InnerText", "Phone Type");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FooterMappingAD1LICell' and assigning its value to variable 'ID_CI_PhoneType'.", repo.ApplicationUnderTest.FooterMappingAD1LICellInfo, new RecordItemIndex(40));
            ID_CI_PhoneType = repo.ApplicationUnderTest.FooterMappingAD1LICell.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_PhoneType) on item 'ApplicationUnderTest.FooterMappingAD1LICell'.", repo.ApplicationUnderTest.FooterMappingAD1LICellInfo, new RecordItemIndex(41));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1LICellInfo, "InnerText", ID_CI_PhoneType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_PhoneType, new RecordItemIndex(42));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Source') on item 'ApplicationUnderTest.FooterMappingAO1_LI_1Source'.", repo.ApplicationUnderTest.FooterMappingAO1_LI_1SourceInfo, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAO1_LI_1SourceInfo, "InnerText", "Source");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FooterMappingAO1_LI_Caller_ID' and assigning its value to variable 'ID_CI_Source'.", repo.ApplicationUnderTest.FooterMappingAO1_LI_Caller_IDInfo, new RecordItemIndex(44));
            ID_CI_Source = repo.ApplicationUnderTest.FooterMappingAO1_LI_Caller_ID.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_Source) on item 'ApplicationUnderTest.FooterMappingAO1_LI_Caller_ID'.", repo.ApplicationUnderTest.FooterMappingAO1_LI_Caller_IDInfo, new RecordItemIndex(45));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAO1_LI_Caller_IDInfo, "InnerText", ID_CI_Source);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_Source, new RecordItemIndex(46));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Phone number') on item 'ApplicationUnderTest.FooterMappingAD1PIPhoneNumber'.", repo.ApplicationUnderTest.FooterMappingAD1PIPhoneNumberInfo, new RecordItemIndex(47));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1PIPhoneNumberInfo, "InnerText", "Phone number");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FooterMappingID_PhoneNumber_Value' and assigning its value to variable 'ID_CI_PhoneNumber'.", repo.ApplicationUnderTest.FooterMappingID_PhoneNumber_ValueInfo, new RecordItemIndex(48));
            ID_CI_PhoneNumber = repo.ApplicationUnderTest.FooterMappingID_PhoneNumber_Value.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_CI_PhoneNumber) on item 'ApplicationUnderTest.FooterMappingID_PhoneNumber_Value'.", repo.ApplicationUnderTest.FooterMappingID_PhoneNumber_ValueInfo, new RecordItemIndex(49));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_PhoneNumber_ValueInfo, "InnerText", ID_CI_PhoneNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ID_CI_PhoneNumber, new RecordItemIndex(50));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
