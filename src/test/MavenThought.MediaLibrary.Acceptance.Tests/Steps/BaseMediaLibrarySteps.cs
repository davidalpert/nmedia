using System.Text.RegularExpressions;
using MavenThought.MediaLibrary.Domain;
using SharpTestsEx;
using TechTalk.SpecFlow;

namespace MavenThought.MediaLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Base steps to share
    /// </summary>
    public class BaseMediaLibrarySteps
    {
        /// <summary>
        /// Assert the text is found on the page
        /// </summary>
        /// <param name="text">Text to found</param>
        protected void AssertTextFound(string text)
        {
            var found = MediaLibraryHelper.Browser.FindText(new Regex(text));

            found.Should().Be.EqualTo(text);
        }

        /// <summary>
        /// Gets the library
        /// </summary>
        protected IMediaLibrary Library
        {
            get { return MediaLibraryHelper.Library; }
        }
    }
}