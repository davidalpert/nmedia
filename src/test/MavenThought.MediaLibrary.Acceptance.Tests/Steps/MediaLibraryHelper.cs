using MavenThought.MediaLibrary.Domain;
using MavenThought.MediaLibrary.Storage.NHibernate;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace MavenThought.MediaLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Base class for movie library steps
    /// </summary>
    public class MediaLibraryHelper
    {
        /// <summary>
        /// Main URL for the application
        /// </summary>
        private const string ApplicationURL = @"http://localhost:1591";

        /// <summary>
        /// Setup the library
        /// </summary>
        static MediaLibraryHelper()
        {
            const string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=medialib;Integrated Security=SSPI;";

            Library = new StorageMediaLibrary(connection);             
        }

        /// <summary>
        /// Gets the instance of the library
        /// </summary>
        public static IMediaLibrary Library
        {
            get; private set;
        }

        /// <summary>
        /// Browser used or the tests
        /// </summary>
        public static IE Browser
        {
            get { return (IE) FeatureContext.Current["browser"]; }
            
            set { FeatureContext.Current["browser"] = value;  }
        }

        /// <summary>
        /// Go to a path in the application
        /// </summary>
        /// <param name="path">Path to go</param>
        public static void GoTo(string path)
        {
            Browser.GoTo(string.Format("{0}/{1}", ApplicationURL, path));  
            Browser.Refresh();          
        }

        /// <summary>
        /// Initialize the browser
        /// </summary>
        public static void InitializeBrowser()
        {
            Browser = new IE(ApplicationURL);
        }

        /// <summary>
        /// Shutdown the browser
        /// </summary>
        public static void ShutdownBrowser()
        {
            Browser.Close();
        }
    }
}