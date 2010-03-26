using MavenThought.MediaLibrary.Core;

namespace MavenThought.MediaLibrary.Storage.NHibernate.Tests
{
    /// <summary>
    /// Base specification for PersistentMovie
    /// </summary>
    public abstract class PersistentMovieSpecification
        : BaseStorageSpecification<Movie>
    {
        /// <summary>
        /// Creates a movie
        /// </summary>
        /// <returns></returns>
        protected override Movie Build()
        {
            return new Movie();
        }
    }
}