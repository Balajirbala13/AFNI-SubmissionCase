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
    ///The Edit_InsuredDetails_Attorney_Information recording.
    /// </summary>
    [TestModule("16eff59b-285e-44cb-99fe-d1e6e18a7105", ModuleType.Recording, 1)]
    public partial class Edit_InsuredDetails_Attorney_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Edit_InsuredDetails_Attorney_Information instance = new Edit_InsuredDetails_Attorney_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Edit_InsuredDetails_Attorney_Information()
        {
            ID_AI_SearchAttorney = "";
            ID_AI_UseType = "";
            ID_AI_PhoneType = "";
            ID_AI_Source = "";
            ID_AI_EmailUseType = "";
            ID_AI_EmailSource = "";
            ID_AI_RepresentationDate = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Edit_InsuredDetails_Attorney_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _ID_AI_SearchAttorney;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_SearchAttorney.
        /// </summary>
        [TestVariable("5b244d65-0df7-4422-a599-2ad513b781db")]
        public string ID_AI_SearchAttorney
        {
            get { return _ID_AI_SearchAttorney; }
            set { _ID_AI_SearchAttorney = value; }
        }

        string _ID_AI_UseType;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_UseType.
        /// </summary>
        [TestVariable("1df3ee63-5541-4a37-9def-b5be99962b14")]
        public string ID_AI_UseType
        {
            get { return _ID_AI_UseType; }
            set { _ID_AI_UseType = value; }
        }

        string _ID_AI_PhoneType;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_PhoneType.
        /// </summary>
        [TestVariable("4d5944af-0cb2-48b9-933a-22cb57bde262")]
        public string ID_AI_PhoneType
        {
            get { return _ID_AI_PhoneType; }
            set { _ID_AI_PhoneType = value; }
        }

        string _ID_AI_Source;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_Source.
        /// </summary>
        [TestVariable("a565414e-2739-4995-8bc2-21405efc1613")]
        public string ID_AI_Source
        {
            get { return _ID_AI_Source; }
            set { _ID_AI_Source = value; }
        }

        string _ID_AI_EmailUseType;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_EmailUseType.
        /// </summary>
        [TestVariable("433f6547-681b-42ea-aa3b-31da13c0fe13")]
        public string ID_AI_EmailUseType
        {
            get { return _ID_AI_EmailUseType; }
            set { _ID_AI_EmailUseType = value; }
        }

        string _ID_AI_EmailSource;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_EmailSource.
        /// </summary>
        [TestVariable("0992771b-25d4-4e38-91fb-38a8652769bd")]
        public string ID_AI_EmailSource
        {
            get { return _ID_AI_EmailSource; }
            set { _ID_AI_EmailSource = value; }
        }

        string _ID_AI_RepresentationDate;

        /// <summary>
        /// Gets or sets the value of variable ID_AI_RepresentationDate.
        /// </summary>
        [TestVariable("68ef53b8-883e-4dbd-9a2c-ec5a0f5a3771")]
        public string ID_AI_RepresentationDate
        {
            get { return _ID_AI_RepresentationDate; }
            set { _ID_AI_RepresentationDate = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.ID_Search_Attorney'", repo.ApplicationUnderTest.ID_Search_AttorneyInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.ID_Search_AttorneyInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ID_Search_Attorney' at 175;17.", repo.ApplicationUnderTest.ID_Search_AttorneyInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ID_Search_Attorney.Click("175;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'ApplicationUnderTest.ID_Search_Attorney'.", repo.ApplicationUnderTest.ID_Search_AttorneyInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ID_Search_Attorney.PressKeys("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'ApplicationUnderTest.Select_Attorney'", repo.ApplicationUnderTest.Select_AttorneyInfo, new ActionTimeout(5000), new RecordItemIndex(3));
            repo.ApplicationUnderTest.Select_AttorneyInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_SearchAttorney' on item 'ApplicationUnderTest.ID_Search_Attorney'.", repo.ApplicationUnderTest.ID_Search_AttorneyInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ID_Search_Attorney.Element.SetAttributeValue("TagValue", ID_AI_SearchAttorney);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.ID_Search_Attorney'.", repo.ApplicationUnderTest.ID_Search_AttorneyInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.ID_Search_Attorney.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(7));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_UseType' on item 'ApplicationUnderTest.ID_AI_UseType'.", repo.ApplicationUnderTest.ID_AI_UseTypeInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.ID_AI_UseType.Element.SetAttributeValue("TagValue", ID_AI_UseType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_PhoneType' on item 'ApplicationUnderTest.ID_AI_PhoneType'.", repo.ApplicationUnderTest.ID_AI_PhoneTypeInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.ID_AI_PhoneType.Element.SetAttributeValue("TagValue", ID_AI_PhoneType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_Source' on item 'ApplicationUnderTest.ID_AI_Source'.", repo.ApplicationUnderTest.ID_AI_SourceInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.ID_AI_Source.Element.SetAttributeValue("TagValue", ID_AI_Source);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_EmailUseType' on item 'ApplicationUnderTest.ID_AI_EmailUseType'.", repo.ApplicationUnderTest.ID_AI_EmailUseTypeInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.ID_AI_EmailUseType.Element.SetAttributeValue("TagValue", ID_AI_EmailUseType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_EmailSource' on item 'ApplicationUnderTest.ID_AI_EmailSource'.", repo.ApplicationUnderTest.ID_AI_EmailSourceInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.ID_AI_EmailSource.Element.SetAttributeValue("TagValue", ID_AI_EmailSource);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ID_AI_RepresentationDate' on item 'ApplicationUnderTest.ID_AI_RepresentationDate'.", repo.ApplicationUnderTest.ID_AI_RepresentationDateInfo, new RecordItemIndex(13));
            //repo.ApplicationUnderTest.ID_AI_RepresentationDate.Element.SetAttributeValue("TagValue", ID_AI_RepresentationDate);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ID_AI_RepresentationDate' with focus on 'ApplicationUnderTest.ID_AI_RepresentationDate'.", repo.ApplicationUnderTest.ID_AI_RepresentationDateInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.ID_AI_RepresentationDate.PressKeys(ID_AI_RepresentationDate);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'ApplicationUnderTest.ID_AI_FirstName'.", repo.ApplicationUnderTest.ID_AI_FirstNameInfo, new RecordItemIndex(15));
            //repo.ApplicationUnderTest.ID_AI_FirstName.PressKeys("{Tab}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(16));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}