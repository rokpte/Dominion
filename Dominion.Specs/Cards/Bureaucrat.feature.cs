// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs.Cards
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Bureaucrat")]
    public partial class BureaucratFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Bureaucrat.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Bureaucrat", "", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays a bureaucrat, puts silver on top and then players must select a vict" +
            "ory card on top")]
        public virtual void PlayerPlaysABureaucratPutsSilverOnTopAndThenPlayersMustSelectAVictoryCardOnTop()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays a bureaucrat, puts silver on top and then players must select a vict" +
                    "ory card on top", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has a Bureaucrat in hand instead of a Copper");
#line 6
testRunner.And("Player2 has a hand of Copper, Copper, Copper, Duchy, Estate");
#line 7
testRunner.And("Player3 has a hand of Copper, Copper, Copper, Duchy, Estate");
#line 8
testRunner.When("Player1 plays a Bureaucrat");
#line 9
testRunner.Then("Player1 should have a Silver on top of the deck");
#line 10
testRunner.And("Player2 must select 1 victory card");
#line 11
testRunner.And("Player3 must select 1 victory card");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays a bureaucrat and opponent puts selected victory card on top")]
        public virtual void PlayerPlaysABureaucratAndOpponentPutsSelectedVictoryCardOnTop()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays a bureaucrat and opponent puts selected victory card on top", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
testRunner.Given("A new game with 2 players");
#line 15
testRunner.And("Player1 has a Bureaucrat in hand instead of a Copper");
#line 16
testRunner.And("Player2 has a hand of Copper, Copper, Copper, Duchy, Estate");
#line 17
testRunner.When("Player1 plays a Bureaucrat");
#line 18
testRunner.And("Player2 selects a Duchy to put on top");
#line 19
testRunner.Then("Player2 should have a Duchy on top of the deck");
#line 20
testRunner.And("Player2 should have 4 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Opponents automatically put victory card on top if there is no choice")]
        public virtual void OpponentsAutomaticallyPutVictoryCardOnTopIfThereIsNoChoice()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opponents automatically put victory card on top if there is no choice", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
testRunner.Given("A new game with 2 players");
#line 24
testRunner.And("Player1 has a Bureaucrat in hand instead of a Copper");
#line 25
testRunner.And("Player2 has a hand of Copper, Copper, Copper, Copper, Duchy");
#line 26
testRunner.When("Player1 plays a Bureaucrat");
#line 27
testRunner.Then("Player2 should have a Duchy on top of the deck");
#line 28
testRunner.And("Player2 should have 4 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Opponents automatically reveal if there are no victory cards")]
        public virtual void OpponentsAutomaticallyRevealIfThereAreNoVictoryCards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opponents automatically reveal if there are no victory cards", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
testRunner.Given("A new game with 2 players");
#line 32
testRunner.And("Player1 has a Bureaucrat in hand instead of a Copper");
#line 33
testRunner.And("Player2 has a hand of Copper, Copper, Copper, Copper, Copper");
#line 34
testRunner.When("Player1 plays a Bureaucrat");
#line 35
testRunner.Then("The game log should report that Player2 revealed Copper, Copper, Copper, Copper, " +
                    "Copper");
#line 36
testRunner.And("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
