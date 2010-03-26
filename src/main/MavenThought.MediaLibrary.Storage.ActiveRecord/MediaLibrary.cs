using System;
using System.Collections.Generic;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    /// <summary>
    /// Implementation of the media library interface
    /// </summary>
    public class MediaLibrary: IMediaLibrary
    {
        /// <summary>
        /// Adds a new element to the library
        /// </summary>
        /// <param name="title">Title for the media</param>
        /// <param name="user">User who adds the media element</param>
        /// <param name="engine">Engine used to find the media</param>
        public IMediaElement AddMedia<T>(string title, IUser user, ISearchEngine engine) where T : IMediaElement
        {
            if( !typeof(T).Equals( typeof(IMovieElement) ) )
                throw new NotImplementedException( String.Format( "The type {0} is not implemented as valid media to be added", typeof(T)) ) ;

            var media = new Movie { Title = title, 
                                    AddedDate = DateTime.Now, 
                                    User = (User) user,
                                    SourceEngine = (SearchEngine) engine};

            
            media.Create();

            
            return media;
        }


        /// <summary>
        /// Gets the collection of media
        /// </summary>
        public IEnumerable<IMediaElement> Contents
        {
            // ReSharper disable AccessToStaticMemberViaDerivedType
            get { return Media.FindAll(); }
            // ReSharper restore AccessToStaticMemberViaDerivedType
        }

        /// <summary>
        /// Gets the users registered in the media library
        /// </summary>
        public IEnumerable<IUser> Users
        {
            // ReSharper disable AccessToStaticMemberViaDerivedType
            get { return User.FindAll(); }
            // ReSharper restore AccessToStaticMemberViaDerivedType
        }


        /// <summary>
        /// Adds a new user to the media library
        /// </summary>
        /// <param name="user">User to add</param>
        public void Add(IUser user)
        {
            var u = (User) user;

            u.CreateAndFlush();
        }
    }


    
}
