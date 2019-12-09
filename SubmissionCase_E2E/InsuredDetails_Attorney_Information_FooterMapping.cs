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
    ///The InsuredDetails_Attorney_Information_FooterMapping recording.
    /// </summary>
    [TestModule("05e3e23f-8b94-4e32-8b8e-fc46b4599b11", ModuleType.Recording, 1)]
    public partial class InsuredDetails_Attorney_Information_FooterMapping : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static InsuredDetails_Attorney_Information_FooterMapping instance = new InsuredDetails_Attorney_Information_FooterMapping();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsuredDetails_Attorney_Information_FooterMapping()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsuredDetails_Attorney_Information_FooterMapping Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(0));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Footer_ClaimInfo' at 50;13.", repo.ApplicationUnderTest.Footer_ClaimInfoInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Footer_ClaimInfo.Click("50;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Insured_Info' at 56;6.", repo.ApplicationUnderTest.Insured_InfoInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Insured_Info.Click("56;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(3));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Insured_Attorney_Details' at 56;6.", repo.ApplicationUnderTest.Insured_Attorney_DetailsInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Insured_Attorney_Details.Click("56;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Firm Name') on item 'ApplicationUnderTest.FooterMappingFirm_Name'.", repo.ApplicationUnderTest.FooterMappingFirm_NameInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingFirm_NameInfo, "Text", "Firm Name");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AD_Attorney_FirmName') on item 'ApplicationUnderTest.FooterMappingID_AI_FirmName'.", repo.ApplicationUnderTest.FooterMappingID_AI_FirmNameInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_FirmNameInfo, "Text", "AD_Attorney_FirmName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='First name\r\n') on item 'ApplicationUnderTest.FooterMappingFirstName'.", repo.ApplicationUnderTest.FooterMappingFirstNameInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingFirstNameInfo, "Text", "First name\r\n");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AD_Attorney_FirstName') on item 'ApplicationUnderTest.FooterMappingID_AI_FirstName'.", repo.ApplicationUnderTest.FooterMappingID_AI_FirstNameInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_FirstNameInfo, "Text", "AD_Attorney_FirstName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Last Name') on item 'ApplicationUnderTest.FooterMappingLastName'.", repo.ApplicationUnderTest.FooterMappingLastNameInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingLastNameInfo, "Text", "Last Name");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AD_Attorney_LastName') on item 'ApplicationUnderTest.FooterMappingID_AI_LastName'.", repo.ApplicationUnderTest.FooterMappingID_AI_LastNameInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_LastNameInfo, "Text", "AD_Attorney_LastName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Address Line1') on item 'ApplicationUnderTest.FooterMappingAddress_line1'.", repo.ApplicationUnderTest.FooterMappingAddress_line1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAddress_line1Info, "Text", "Address Line1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AD_Attorney_Address1') on item 'ApplicationUnderTest.FooterMappingID_AI_Address1'.", repo.ApplicationUnderTest.FooterMappingID_AI_Address1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_Address1Info, "Text", "AD_Attorney_Address1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Address Line2') on item 'ApplicationUnderTest.FooterMappingAddress_line2'.", repo.ApplicationUnderTest.FooterMappingAddress_line2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAddress_line2Info, "Text", "Address Line2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AD_Attorney_Address2') on item 'ApplicationUnderTest.FooterMappingID_AI_Address2'.", repo.ApplicationUnderTest.FooterMappingID_AI_Address2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_Address2Info, "Text", "AD_Attorney_Address2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='City') on item 'ApplicationUnderTest.FooterMappingAddress_City'.", repo.ApplicationUnderTest.FooterMappingAddress_CityInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAddress_CityInfo, "Text", "City");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AD_Attorney_City') on item 'ApplicationUnderTest.FooterMappingID_AI_City'.", repo.ApplicationUnderTest.FooterMappingID_AI_CityInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_CityInfo, "Text", "AD_Attorney_City");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='State') on item 'ApplicationUnderTest.FooterMappingState'.", repo.ApplicationUnderTest.FooterMappingStateInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingStateInfo, "Text", "State");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='LA') on item 'ApplicationUnderTest.FooterMappingID_AI_State'.", repo.ApplicationUnderTest.FooterMappingID_AI_StateInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_StateInfo, "Text", "LA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Zip') on item 'ApplicationUnderTest.FooterMappingZip'.", repo.ApplicationUnderTest.FooterMappingZipInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingZipInfo, "Text", "Zip");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='12345-5432') on item 'ApplicationUnderTest.FooterMappingID_AI_Zip'.", repo.ApplicationUnderTest.FooterMappingID_AI_ZipInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_ZipInfo, "Text", "12345-5432");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Representation Date') on item 'ApplicationUnderTest.FooterMappingRepresentationDate'.", repo.ApplicationUnderTest.FooterMappingRepresentationDateInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingRepresentationDateInfo, "Text", "Representation Date");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='06/04/19') on item 'ApplicationUnderTest.FooterMappingID_AI_Representation_Date'.", repo.ApplicationUnderTest.FooterMappingID_AI_Representation_DateInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_Representation_DateInfo, "Text", "06/04/19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Phone/Fax Information') on item 'ApplicationUnderTest.FooterMappingAD1PIPhoneInformation'.", repo.ApplicationUnderTest.FooterMappingAD1PIPhoneInformationInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1PIPhoneInformationInfo, "Text", "Phone/Fax Information");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Use Type\r\n') on item 'ApplicationUnderTest.FooterMappingAD1PIUseType'.", repo.ApplicationUnderTest.FooterMappingAD1PIUseTypeInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1PIUseTypeInfo, "Text", "Use Type\r\n");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Personal') on item 'ApplicationUnderTest.FooterMappingAD1PIPersonal'.", repo.ApplicationUnderTest.FooterMappingAD1PIPersonalInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1PIPersonalInfo, "Text", "Personal");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Phone Type') on item 'ApplicationUnderTest.FooterMappingAD1PIPhoneType'.", repo.ApplicationUnderTest.FooterMappingAD1PIPhoneTypeInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1PIPhoneTypeInfo, "Text", "Phone Type");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Cell') on item 'ApplicationUnderTest.FooterMappingAO1_LI_Cell'.", repo.ApplicationUnderTest.FooterMappingAO1_LI_CellInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAO1_LI_CellInfo, "Text", "Cell");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Source') on item 'ApplicationUnderTest.FooterMappingAO1_LI_1Source'.", repo.ApplicationUnderTest.FooterMappingAO1_LI_1SourceInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAO1_LI_1SourceInfo, "Text", "Source");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Caller ID') on item 'ApplicationUnderTest.FooterMappingAO1_LI_Caller_ID'.", repo.ApplicationUnderTest.FooterMappingAO1_LI_Caller_IDInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAO1_LI_Caller_IDInfo, "Text", "Caller ID");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Phone number') on item 'ApplicationUnderTest.FooterMappingAD1PIPhoneNumber'.", repo.ApplicationUnderTest.FooterMappingAD1PIPhoneNumberInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD1PIPhoneNumberInfo, "Text", "Phone number");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='(950) 009-5002') on item 'ApplicationUnderTest.FooterMappingID_AI_EmailUseType'.", repo.ApplicationUnderTest.FooterMappingID_AI_EmailUseTypeInfo, new RecordItemIndex(32));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_EmailUseTypeInfo, "Text", "(950) 009-5002");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='(950) 009-5002') on item 'ApplicationUnderTest.FooterMappingID_AI_EmailSource'.", repo.ApplicationUnderTest.FooterMappingID_AI_EmailSourceInfo, new RecordItemIndex(33));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_EmailSourceInfo, "Text", "(950) 009-5002");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='(950) 009-5002') on item 'ApplicationUnderTest.FooterMappingID_AI_Email'.", repo.ApplicationUnderTest.FooterMappingID_AI_EmailInfo, new RecordItemIndex(34));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_AI_EmailInfo, "Text", "(950) 009-5002");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
