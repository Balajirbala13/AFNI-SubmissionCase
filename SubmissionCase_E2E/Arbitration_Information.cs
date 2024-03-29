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
    ///The Arbitration_Information recording.
    /// </summary>
    [TestModule("f859ad00-b6ba-4d10-b4bc-043e0b7b83b6", ModuleType.Recording, 1)]
    public partial class Arbitration_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Arbitration_Information instance = new Arbitration_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Arbitration_Information()
        {
            ClaimInformation_Product = "394713";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Arbitration_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _ClaimInformation_Product;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Product.
        /// </summary>
        [TestVariable("fefa7a0a-363d-4b4b-a405-f85c1d96a6be")]
        public string ClaimInformation_Product
        {
            get { return _ClaimInformation_Product; }
            set { _ClaimInformation_Product = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClaimInformation_Product' with focus on 'ApplicationUnderTest.ProductName'.", repo.ApplicationUnderTest.ProductNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ProductName.PressKeys(ClaimInformation_Product);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InsuranceList' at 13;12.", repo.ApplicationUnderTest.InsuranceListInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.InsuranceList.Click("13;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'ApplicationUnderTest.InsuranceList'.", repo.ApplicationUnderTest.InsuranceListInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.InsuranceList.PressKeys("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'ApplicationUnderTest.InsuranceList'.", repo.ApplicationUnderTest.InsuranceListInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.InsuranceList.PressKeys("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.InsuranceList'.", repo.ApplicationUnderTest.InsuranceListInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.InsuranceList.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.InsuranceList'.", repo.ApplicationUnderTest.InsuranceListInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.InsuranceList.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.InsuranceList'.", repo.ApplicationUnderTest.InsuranceListInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.InsuranceList.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubmitButton1' at 60;11.", repo.ApplicationUnderTest.SubmitButton1Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.SubmitButton1.Click("60;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
