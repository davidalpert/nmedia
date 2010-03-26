using System.Collections.Generic;
using Castle.ActiveRecord;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    /// <summary>
    /// Movie implementation of media
    /// </summary>
    [ActiveRecord("movies" )]
    public class Movie: Media, IMovieElement
    {
        /// <summary>
        /// Collection of directors associated to the movie
        /// </summary>
        public IEnumerable<IPerson> Directors
        {
            get 
            {
                return DeserializePersons( this.ActorsImpl );
            }
        }

        /// <summary>
        /// Collection of actors associated to the movie
        /// </summary>
        public IEnumerable<IPerson> Actors
        {
            get
            {
                return DeserializePersons(this.DirectorsImpl);
            }
        }

        [JoinedKey("movie_id")]
        public virtual int MovieId { get; set;}

        [Property("media_id", NotNull = true)]
        public virtual int MediaId { get; set; }

        [Property("actors")]
        protected string ActorsImpl { get; set; }

        [Property("directors")]
        protected string DirectorsImpl { get; set; }

        /// <summary>
        /// Deserialize a string with a collection of <FirstName, LastName>
        /// </summary>
        /// <param name="persons"></param>
        /// <returns></returns>
        private static IEnumerable<IPerson> DeserializePersons( string persons )
        {
            var result = new List<IPerson>();

            if( persons != null)
            {
                var splitted = persons.Split(';');

                foreach( var split in splitted )
                {
                    var names = split.Split(',');

                    var person = new Person {FirstName = names[0], LastName = names[1]};

                    result.Add(person);
                }
            }

            return result;
        
        }
    }

    
}