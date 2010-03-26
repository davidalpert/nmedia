using TechTalk.SpecFlow;

namespace MavenThought.MediaLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Events for scenarios and steps
    /// </summary>
    [Binding]
    public class FeatureEvents
    {
        /// <summary>
        /// Clear the library before the scenario runs
        /// </summary>
        [BeforeScenario]
        public void BeforeScenario()
        {
            MediaLibraryHelper.Library.Clear(); 
        }

        /// <summary>
        /// Pending
        /// </summary>
        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }

        /// <summary>
        /// Setup the browser
        /// </summary>
        [BeforeFeature]
        public static void BeforeFeature()
        {
            MediaLibraryHelper.InitializeBrowser();
        }

        /// <summary>
        /// Close the browser
        /// </summary>
        [AfterFeature]
        public static void AfterFeature()
        {
            MediaLibraryHelper.ShutdownBrowser();
        }
    }
}


