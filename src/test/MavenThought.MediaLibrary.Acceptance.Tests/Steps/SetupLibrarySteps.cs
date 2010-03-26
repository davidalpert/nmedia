using TechTalk.SpecFlow;

namespace MavenThought.MediaLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Steps that involve accessing the library
    /// </summary>
    [Binding]
    public class SetupLibrarySteps : BaseMediaLibrarySteps
    {
        /// <summary>
        /// Setup no movies exist
        /// </summary>
        [Given(@"I have no movies")]
        public void GivenIHaveNoMovies()
        {
            this.Library.Clear();
        }
    }
}
