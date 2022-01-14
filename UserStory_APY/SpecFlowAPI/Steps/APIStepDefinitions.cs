using FluentAssertions;
using TechTalk.SpecFlow;
using UserStory_APY;

namespace SpecFlowAPI.Steps
{
    [Binding]
    public sealed class APIStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly UserStory_API userStory_API = new UserStory_API();

        private int _resultInt;
        private bool _resultBool;

        public APIStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the maxParticipants is (.*)")]
        public void GivenTheMaxParticipants(int maxParticipants)
        {
            userStory_API.MaxParticipants = maxParticipants;
        }

        [Given("the maxVotes is (.*)")]
        public void GivenTheMaxVotes(int maxVotes)
        {
            userStory_API.MaxVotes = maxVotes;
        }

        [When("the participants are init")]
        public void WhenTheParticipantsAreInit()
        {
            _resultInt = userStory_API.setMaxParticipants();
        }

        [When("the votes are init")]
        public void WhenTheVotesAreInit()
        {
            _resultInt = userStory_API.setMaxVotes();
        }

        [When("the votes are closed")]
        public void WhenTheVotesAreClosed()
        {
            _resultBool = userStory_API.isClosed();
        }

        [Then("the int result should be (.*)")]
        public void ThenTheIntResultShouldBe(int result)
        {
            _resultInt.Should().Be(result);
        }

        [Then("the bool result should be (.*)")]
        public void ThenTheBoolResultShouldBe(bool result)
        {
            _resultBool.Should().Be(result);
        }
    }
}
