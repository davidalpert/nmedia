using System;
using System.Linq;
using MavenThought.Commons.Extensions;
using MavenThought.MediaLibrary.Acceptance.Tests.PageObjects;
using MavenThought.MediaLibrary.Core;
using SharpTestsEx;
using TechTalk.SpecFlow;

namespace MavenThought.MediaLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Steps to implement browse movie feature
    /// </summary>
    [Binding]
    public class BrowseMoviesSteps : BaseMediaLibrarySteps
    {
        /// <summary>
        /// Setup the movies page
        /// </summary>
        public BrowseMoviesSteps()
        {
            this.Movies = new BrowseMoviesPage();
        }

        /// <summary>
        /// Gets the movies page
        /// </summary>
        protected BrowseMoviesPage Movies { get; private set; }

        /// <summary>
        /// Setup the movies in the library
        /// </summary>
        [Given(@"I have the following movies:")]
        public void GivenIHaveTheFollowingMovies(Table movies)
        {
            movies.Rows.ForEach(row => AddMovie(row["title"]));
        }

        /// <summary>
        /// Checks the movie is in the listing
        /// </summary>
        /// <param name="movies">Movies to look for</param>
        [Then(@"I should see in the listing:")]
        public void ThenIShouldSee(Table movies)
        {
            var expected = movies.Rows.Select(row => row["title"]);

            var listing = this.Movies.Listing;

            listing.Should().Have.SameSequenceAs(expected);
        }

        /// <summary>
        /// Checks the movie is in the listing
        /// </summary>
        /// <param name="title">Title to check for</param>
        [Then(@"I should see (.*) in the listing")]
        public void ThenIShouldSeeInTheListing(string title)
        {
            var listing = this.Movies.Listing;

            listing.Should().Contain(title);
        }

        /// <summary>
        /// Checks no movies are shown
        /// </summary>
        [Then(@"I should see the message (.*)")]
        public void ThenIShouldSee(string message)
        {
            this.Movies.Find(message).Should().Not.Be.Null();
        }

        /// <summary>
        /// Checks the image for the case is empty
        /// </summary>
        [Then(@"the case for (.*) should be empty")]
        public void ThenTheCaseForTitleShouldBeEmpty(string title)
        {
            this.Movies.HasEmptyCase(title).Should().Be.True();
        }

        /// <summary>
        /// Checks the image for the case is empty
        /// </summary>
        [Then(@"the case for (.*) should not be empty")]
        public void ThenTheCaseForTitleShouldNotBeEmpty(string title)
        {
            this.Movies.HasEmptyCase(title).Should().Be.False();
        }
        
        /// <summary>
        /// Adds a movie to the media library
        /// </summary>
        /// <param name="title">Title of the movie to add</param>
        private void AddMovie(string title)
        {
            var movie = new Movie
                            {
                                Title = title,
                                ReleaseDate = DateTime.Now
                            };

            this.Library.Add(movie);
        }
    }
}


