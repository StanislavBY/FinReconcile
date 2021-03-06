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
    [NUnit.Framework.DescriptionAttribute("RulesEvaluator")]
    public partial class RulesEvaluatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RulesEvaluator.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RulesEvaluator", "\tIn order to reconcile transactions\r\n\tAs a user\r\n\tI want to define rules", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Match Ids of two transactions")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void MatchIdsOfTwoTransactions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Match Ids of two transactions", new string[] {
                        "rules"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("two transacions with same Ids", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("A rule to match Ids", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I call Evaluate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("the result should be matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Match Dates of two transactions which are within 2 minutes")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void MatchDatesOfTwoTransactionsWhichAreWithin2Minutes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Match Dates of two transactions which are within 2 minutes", new string[] {
                        "rules"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("two transacions with same id \'584011808649511\' and dates \'1/11/2014  10:27:00 PM\'" +
                    " and \'1/11/2014  10:27:44 PM\' respectively", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And("A rule to match Ids and Dates with a delta of 120 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I call Evaluate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the result should be matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Match Ids and Amount")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void MatchIdsAndAmount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Match Ids and Amount", new string[] {
                        "rules"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("two transacions with same \'584011808649511\' and amount -20000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("A rule to match Ids and amount", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("I call Evaluate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the result should be matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Match Ids and But Not Amount")]
        [NUnit.Framework.CategoryAttribute("rules")]
        public virtual void MatchIdsAndButNotAmount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Match Ids and But Not Amount", new string[] {
                        "rules"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("two transacions with same Id \'584011808649511\' and different amount -20000 and -2" +
                    "0002", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.And("A rule to match Ids and amount", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("I call Evaluate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("the result should be not matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Match all the fields of transactions")]
        [NUnit.Framework.CategoryAttribute("rules")]
        [NUnit.Framework.TestCaseAttribute("584011808649511", "584011808649511", "Card Campaign", "Card Campaign", "1/11/2014  10:27:00 PM", "1/11/2014  10:27:00 PM", "-20000", "-20000", "*MOLEPS ATM25             MOLEPOLOLE    BW", "*MOLEPS ATM25             MOLEPOLOLE    BW", "DEDUCT", "DEDUCT", "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5", "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5", null)]
        [NUnit.Framework.TestCaseAttribute("84012233581869", "84012233581869", "Card Campaign", "Card Campaign", "1/12/2014  6:26:00 AM", "1/12/2014  6:26:00 AM", "-20000", "-20000", "Molepolole Filli100558    Gaborone      BW", "Molepolole Filli100558    Gaborone      BW", "DEDUCT", "DEDUCT", "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2", "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2", null)]
        [NUnit.Framework.TestCaseAttribute("0584012395072004", "0584012395072004", "Card Campaign", "Card Campaign", "2014-01-12 14:58:27", "2014-01-12 14:58:27", "-10000", "-10000", "MAHALAPYE BRANCH          BOTSWANA      BW", "MAHALAPYE BRANCH          BOTSWANA      BW", "DEDUCT", "DEDUCT", "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2", "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2", null)]
        [NUnit.Framework.TestCaseAttribute("0164012401925347", "0164012401925347", "Card Campaign", "Card Campaign", "2014-01-12 15:09:52", "2014-01-12 15:09:52", "3880", "3880", "370592 ENGEN LOBATSE      BOTSWANA      BW", "370592 ENGEN LOBATSE      BOTSWANA      BW", "REVERSAL", "REVERSAL", "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1", "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1", null)]
        public virtual void MatchAllTheFieldsOfTransactions(string c_Id, string t_Id, string c_Profilename, string t_Profilename, string c_Date, string t_Date, string c_Amount, string t_Amount, string c_Narrative, string t_Narrative, string c_Description, string t_Description, string c_Walletreference, string t_Walletreference, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "rules"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Match all the fields of transactions", @__tags);
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given(string.Format("ClientTransacion with \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\' \'{6}\'", c_Id, c_Profilename, c_Date, c_Amount, c_Narrative, c_Description, c_Walletreference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.And(string.Format("BankTransacion with \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\' \'{6}\'", t_Id, t_Profilename, t_Date, t_Amount, t_Narrative, t_Description, t_Walletreference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("A ruleset to match all fields of Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("I call Evaluate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("the result should be matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Match all the fields exactly and dates with a delta of 120 seconds")]
        [NUnit.Framework.CategoryAttribute("rules")]
        [NUnit.Framework.TestCaseAttribute("584011808649511", "584011808649511", "Card Campaign", "Card Campaign", "1/11/2014  10:27:00 PM", "1/11/2014  10:27:44 PM", "-20000", "-20000", "*MOLEPS ATM25             MOLEPOLOLE    BW", "*MOLEPS ATM25             MOLEPOLOLE    BW", "DEDUCT", "DEDUCT", "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5", "P_NzI2ODY2ODlfMTM4MjcwMTU2NS45MzA5", null)]
        [NUnit.Framework.TestCaseAttribute("84012233581869", "84012233581869", "Card Campaign", "Card Campaign", "1/12/2014  6:26:00 AM", "1/12/2014  6:26:17 AM", "-20000", "-20000", "Molepolole Filli100558    Gaborone      BW", "Molepolole Filli100558    Gaborone      BW", "DEDUCT", "DEDUCT", "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2", "P_NzI5OTE3NjZfMTM4MTkzNjk5Mi45NTc2", null)]
        [NUnit.Framework.TestCaseAttribute("0584012395072004", "0584012395072004", "Card Campaign", "Card Campaign", "2014-01-12 14:58:40", "2014-01-12 14:58:27", "-10000", "-10000", "MAHALAPYE BRANCH          BOTSWANA      BW", "MAHALAPYE BRANCH          BOTSWANA      BW", "DEDUCT", "DEDUCT", "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2", "P_NzUzMDAzODVfMTM4NzI4MTQ5NC4zNzI2", null)]
        [NUnit.Framework.TestCaseAttribute("0164012401925347", "0164012401925347", "Card Campaign", "Card Campaign", "2014-01-12 15:09:00", "2014-01-12 15:10:20", "3880", "3880", "370592 ENGEN LOBATSE      BOTSWANA      BW", "370592 ENGEN LOBATSE      BOTSWANA      BW", "REVERSAL", "REVERSAL", "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1", "P_NzUzNDA5MjRfMTM4MDg4NDc0OC4yNjA1", null)]
        public virtual void MatchAllTheFieldsExactlyAndDatesWithADeltaOf120Seconds(string c_Id, string t_Id, string c_Profilename, string t_Profilename, string c_Date, string t_Date, string c_Amount, string t_Amount, string c_Narrative, string t_Narrative, string c_Description, string t_Description, string c_Walletreference, string t_Walletreference, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "rules"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Match all the fields exactly and dates with a delta of 120 seconds", @__tags);
#line 51
this.ScenarioSetup(scenarioInfo);
#line 52
 testRunner.Given(string.Format("ClientTransacion with \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\' \'{6}\'", c_Id, c_Profilename, c_Date, c_Amount, c_Narrative, c_Description, c_Walletreference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.And(string.Format("BankTransacion with \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\' \'{6}\'", t_Id, t_Profilename, t_Date, t_Amount, t_Narrative, t_Description, t_Walletreference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("A ruleset to match all fields exactly and date field with a delta of 120 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.When("I call Evaluate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("the result should be matched ReconciledItem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
