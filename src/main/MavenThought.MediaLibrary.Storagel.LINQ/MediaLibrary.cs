using System.Collections.Generic;
using System.Linq;

namespace MediaLibrary.Core.Model.ADOEF
{
    /// <summary>
    /// Implementation of the media library using the entities defined
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
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets all the users in the storage
        /// </summary>
        public IEnumerable<IUser> Users
        {
            get
            {
                var userList = EntitiesGateway.Entities.Users.ToList();

                return userList.Cast<IUser>();
            }
        }

        public void Add(IUser user)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets all the media contents in the storage
        /// </summary>
        public IEnumerable<IMediaElement> Contents
        {
            get
            {
                var mediaList = EntitiesGateway.Entities.Media.ToList();

                return mediaList.Cast<IMediaElement>();
            }
        }

        
    }
}