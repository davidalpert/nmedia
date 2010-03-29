import System.Web.Mvc
import MavenThought.MediaLibrary.WebClient.Controllers
import MavenThought.MediaLibrary.Storage.NHibernate
import MavenThought.MediaLibrary.Domain

component "HomeController", HomeController:
  @lifestyle = "transient"

component "MoviesController", MoviesController:
  @lifestyle = "transient"
  
component IMediaLibrary, StorageMediaLibrary:
  connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=medialib;Integrated Security=SSPI;"
