using MvcContrib.TestHelper;
using MavenThought.Commons.Testing;

namespace MavenThought.MediaLibrary.WebClient.Tests.Controllers
{
    /// <summary>
    /// Specification when calling create with get
    /// </summary>
    [Specification]
    public class When_movies_controller_calls_create_action : MoviesControllerSpecification
    {
        /// <summary>
        /// Checks the view returned is to add a movie
        /// </summary>
        [It]
        public void Should_return_the_form_to_create()
        {
            this.ActualResult.AssertViewRendered();
        }

        /// <summary>
        /// Call create to show the form
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Create();
        }
    }
}