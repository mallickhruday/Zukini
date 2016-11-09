﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Zukini.API.Examples.Features.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("API Example Features")]
    [NUnit.Framework.CategoryAttribute("api")]
    public partial class APIExampleFeaturesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ApiExamples.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "API Example Features", "\tIn order to provide an example of Zukini.API\r\n\tAs a user\r\n\tI want to try it out " +
                    "against a prototype API", ProgrammingLanguage.CSharp, new string[] {
                        "api"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Get a resource from an API and validate the return data")]
        [NUnit.Framework.CategoryAttribute("get_example")]
        public virtual void GetAResourceFromAnAPIAndValidateTheReturnData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a resource from an API and validate the return data", new string[] {
                        "get_example"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I perform a GET for post \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "userId",
                        "id",
                        "title",
                        "body"});
            table1.AddRow(new string[] {
                        "1",
                        "1",
                        "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                        "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit m" +
                            "olestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"});
#line 10
 testRunner.Then("the Get response should contain the following data", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post to an API and validate that the post data returned is correct")]
        [NUnit.Framework.CategoryAttribute("post_example")]
        public virtual void PostToAnAPIAndValidateThatThePostDataReturnedIsCorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post to an API and validate that the post data returned is correct", new string[] {
                        "post_example"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "title",
                        "body",
                        "userId"});
            table2.AddRow(new string[] {
                        "Checkout this new POST",
                        "Here is a test title to demonstrate testing a post.",
                        "123"});
#line 16
 testRunner.Given("I post the following data to the API", ((string)(null)), table2, "Given ");
#line 19
 testRunner.Then("the post data should return \"Checkout this new POST\" in the \"title\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.And("the post data should return \"Here is a test title to demonstrate testing a post.\"" +
                    " in the \"body\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("the post data should return \"123\" in the \"userId\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch to an API and validate that the patch data returned is correct")]
        [NUnit.Framework.CategoryAttribute("patch_example")]
        public virtual void PatchToAnAPIAndValidateThatThePatchDataReturnedIsCorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch to an API and validate that the patch data returned is correct", new string[] {
                        "patch_example"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "title",
                        "body",
                        "userId"});
            table3.AddRow(new string[] {
                        "Checkout this PATCH",
                        "Here is a test title to demonstrate testing a patch.",
                        "123"});
#line 25
 testRunner.Given("I \"Patch\" a record with id \"1\"", ((string)(null)), table3, "Given ");
#line 28
 testRunner.Then("the \"Patch\" data should return \"Checkout this PATCH\" in the \"title\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("the \"Patch\" data should return \"Here is a test title to demonstrate testing a pat" +
                    "ch.\" in the \"body\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.Then("the \"Patch\" data should return \"123\" in the \"userId\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Put to an API and validate that the put data returned is correct")]
        [NUnit.Framework.CategoryAttribute("put_example")]
        public virtual void PutToAnAPIAndValidateThatThePutDataReturnedIsCorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Put to an API and validate that the put data returned is correct", new string[] {
                        "put_example"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "title",
                        "body",
                        "userId"});
            table4.AddRow(new string[] {
                        "Checkout my PUT",
                        "Here is a test title to demonstrate testing a put.",
                        "456"});
#line 35
 testRunner.Given("I \"Put\" a record with id \"2\"", ((string)(null)), table4, "Given ");
#line 38
 testRunner.Then("the \"Put\" data should return \"Checkout my PUT\" in the \"title\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.Then("the \"Put\" data should return \"Here is a test title to demonstrate testing a put.\"" +
                    " in the \"body\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.Then("the \"Put\" data should return \"456\" in the \"userId\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete a post from our fake API")]
        [NUnit.Framework.CategoryAttribute("delete_example")]
        public virtual void DeleteAPostFromOurFakeAPI()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete a post from our fake API", new string[] {
                        "delete_example"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
 testRunner.Given("I perform a DELETE for postId \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.Then("I should get a status code of \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
