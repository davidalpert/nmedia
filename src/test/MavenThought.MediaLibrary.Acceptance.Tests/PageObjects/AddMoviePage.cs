using MavenThought.MediaLibrary.Acceptance.Tests.Steps;

namespace MavenThought.MediaLibrary.Acceptance.Tests.PageObjects
{
    /// <summary>
    /// Page for adding a movie
    /// </summary>
    public class AddMoviePage
    {
        /// <summary>
        /// Gets or sets the movie title
        /// </summary>
        public string MovieTitle
        {
            get
            {
                return MediaLibraryHelper.Browser.TextField("Title").Value;
            }

            set
            {
                MediaLibraryHelper.Browser.TextField("Title").Value = value;
            }
        }

        /// <summary>
        /// Submits the form to add the movie
        /// </summary>
        public void Add()
        {
            MediaLibraryHelper.Browser.Button("Submit").Click();    
        }
    }
}