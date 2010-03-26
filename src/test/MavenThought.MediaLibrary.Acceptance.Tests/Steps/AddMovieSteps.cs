using MavenThought.MediaLibrary.Acceptance.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace MavenThought.MediaLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Steps for adding a movie
    /// </summary>
    [Binding]
    public class AddMovieSteps : BaseMediaLibrarySteps
    {
        /// <summary>
        /// Initializes an instance of <see cref="AddMovieSteps"/> class.
        /// </summary>
        public AddMovieSteps()
        {
            this.AddPage = new AddMoviePage();
        }

        /// <summary>
        /// Gets tor sets the add movie page abstraction
        /// </summary>
        protected AddMoviePage AddPage { get; set; }

        /// <summary>
        /// Step to enter the title in the page
        /// </summary>
        [When(@"I enter (.*) in the title")]
        public void WhenIEnterInTheTitle(string title)
        {
            this.AddPage.MovieTitle = title;
        }

        /// <summary>
        /// Step to click on submit
        /// </summary>
        [When(@"I click Submit")]
        public void WhenISubmit()
        {
            this.AddPage.Add();
        }
    }
}
