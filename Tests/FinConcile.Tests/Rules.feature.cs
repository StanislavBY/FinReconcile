﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FinConcile.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Rules")]
    public partial class RulesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Rules.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Rules", "\tIn order to match transactions\r\n\tAs a user\r\n\tI want to define custom rules", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Define A simple PropertyRule to Equal two fields")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void DefineASimplePropertyRuleToEqualTwoFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define A simple PropertyRule to Equal two fields", new string[] {
                        "rules"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "SourceProperty",
                        "TargetProperty",
                        "Operator"});
            table1.AddRow(new string[] {
                        "WalletReference",
                        "WalletReference",
                        "Equal"});
#line 8
 testRunner.Given("a set of PropertyRules", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table2.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table2.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 11
 testRunner.And("A list of client transactions to match", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table3.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table3.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 15
 testRunner.And("a list of bank transactions slightly different descriptions", ((string)(null)), table3, "And ");
#line 19
 testRunner.When("I call evaluate for each transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "MatchType"});
            table4.AddRow(new string[] {
                        "Matched"});
            table4.AddRow(new string[] {
                        "Matched"});
#line 20
 testRunner.Then("the result should be matched ReconciledItems as Follows", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Define A simple DateRule to Equal two dates within a delta of 600 seconds")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void DefineASimpleDateRuleToEqualTwoDatesWithinADeltaOf600Seconds()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define A simple DateRule to Equal two dates within a delta of 600 seconds", new string[] {
                        "rules"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("a DateRule with Delta\tof 3600 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table5.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table5.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 28
 testRunner.And("A list of client transactions to match", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table6.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:59:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table6.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  11:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 32
 testRunner.And("a list of bank transactions slightly different descriptions", ((string)(null)), table6, "And ");
#line 36
 testRunner.When("I call evaluate for each transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "MatchType"});
            table7.AddRow(new string[] {
                        "Matched"});
            table7.AddRow(new string[] {
                        "Matched"});
#line 37
 testRunner.Then("the result should be matched ReconciledItems as Follows", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Define PropertyRules to Equal two fields")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void DefinePropertyRulesToEqualTwoFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define PropertyRules to Equal two fields", new string[] {
                        "rules"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "SourceProperty",
                        "TargetProperty",
                        "Operator"});
            table8.AddRow(new string[] {
                        "Date",
                        "Date",
                        "Equal"});
            table8.AddRow(new string[] {
                        "Amount",
                        "Amount",
                        "Equal"});
            table8.AddRow(new string[] {
                        "WalletReference",
                        "WalletReference",
                        "Equal"});
            table8.AddRow(new string[] {
                        "Id",
                        "Id",
                        "Equal"});
            table8.AddRow(new string[] {
                        "Narrative",
                        "Narrative",
                        "Equal"});
            table8.AddRow(new string[] {
                        "Description",
                        "Description",
                        "Equal"});
#line 43
 testRunner.Given("a set of PropertyRules", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table9.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table9.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 51
 testRunner.And("A list of client transactions to match", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table10.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table10.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 55
 testRunner.And("a list of bank transactions slightly different descriptions", ((string)(null)), table10, "And ");
#line 59
 testRunner.When("I call evaluate for each transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "MatchType"});
            table11.AddRow(new string[] {
                        "Matched"});
            table11.AddRow(new string[] {
                        "Matched"});
#line 60
 testRunner.Then("the result should be matched ReconciledItems as Follows", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Define PropertyRules Which Unmatch if any two fields do not match")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void DefinePropertyRulesWhichUnmatchIfAnyTwoFieldsDoNotMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define PropertyRules Which Unmatch if any two fields do not match", new string[] {
                        "rules"});
#line 66
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "SourceProperty",
                        "TargetProperty",
                        "Operator"});
            table12.AddRow(new string[] {
                        "Date",
                        "Date",
                        "Equal"});
            table12.AddRow(new string[] {
                        "Amount",
                        "Amount",
                        "Equal"});
            table12.AddRow(new string[] {
                        "WalletReference",
                        "WalletReference",
                        "Equal"});
#line 67
 testRunner.Given("a set of PropertyRules", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table13.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table13.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table13.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 72
 testRunner.And("A list of client transactions to match", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table14.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-30000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table14.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/12/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table14.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 77
 testRunner.And("a list of bank transactions slightly different descriptions", ((string)(null)), table14, "And ");
#line 82
 testRunner.When("I call evaluate for each transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "MatchType"});
            table15.AddRow(new string[] {
                        "NotMatched"});
            table15.AddRow(new string[] {
                        "NotMatched"});
            table15.AddRow(new string[] {
                        "NotMatched"});
#line 83
 testRunner.Then("the result should be matched ReconciledItems as Follows", ((string)(null)), table15, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Define PropertyFuzzyMatchRule to fuzzy string match two string fields")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void DefinePropertyFuzzyMatchRuleToFuzzyStringMatchTwoStringFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define PropertyFuzzyMatchRule to fuzzy string match two string fields", new string[] {
                        "rules"});
#line 90
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "sourceproperty",
                        "targetproperty",
                        "levenshteidistance"});
            table16.AddRow(new string[] {
                        "Narrative",
                        "Narrative",
                        "1"});
#line 91
 testRunner.Given("I have a Rule", ((string)(null)), table16, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table17.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table17.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 94
 testRunner.And("A list of client transactions to match", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "ProfileName",
                        "Date",
                        "Amount",
                        "Narrative",
                        "Description",
                        "WalletReference",
                        "Type"});
            table18.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "-20000",
                        "*MLPS ATM25             MOLEPOLOLE    BW",
                        "DEDUCT",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
            table18.AddRow(new string[] {
                        "584011808649511",
                        "Card Campaign",
                        "1/11/2014  10:27:00 PM",
                        "20000",
                        "*MOLEPS ATM25             MOLEPOLOLE    BW",
                        "REVERSAL",
                        "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5",
                        "1"});
#line 98
 testRunner.And("a list of bank transactions slightly different descriptions", ((string)(null)), table18, "And ");
#line 102
 testRunner.When("I call evaluate for each transactions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "MatchType"});
            table19.AddRow(new string[] {
                        "Matched"});
            table19.AddRow(new string[] {
                        "Matched"});
#line 103
 testRunner.Then("the result should be matched ReconciledItems as Follows", ((string)(null)), table19, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
