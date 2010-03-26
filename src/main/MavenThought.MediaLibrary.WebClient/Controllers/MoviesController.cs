using System.Linq;
using System.Web.Mvc;
using MavenThought.MediaLibrary.Core;
using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.WebClient.Controllers
{
    /// <summary>
    /// Controller for movies
    /// </summary>
    public class MoviesController : Controller
    {
        /// <summary>
        /// Library instance
        /// </summary>
        private readonly IMediaLibrary _library;

        /// <summary>
        /// Initializes the controller
        /// </summary>
        /// <param name="library">Library to use</param>
        public MoviesController(IMediaLibrary library)
        {
            _library = library;
        }

        /// <summary>
        /// Gets the list of movies GET : /Movies/
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(this._library.Contents.ToList());
        }

        /// <summary>
        /// Gets the form to add a new movie to the library
        /// </summary>
        /// <returns>The view to the form</returns>
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Creates the new title in the library
        /// </summary>
        /// <param name="title">Title to add</param>
        /// <returns>Redirects to the movies</returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(string title)
        {
            this._library.Add(new Movie { Title = title} );

            return Redirect("Index");
        }

        /// <summary>
        /// Gets the detail of one movie GET: /Movies/Details/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
