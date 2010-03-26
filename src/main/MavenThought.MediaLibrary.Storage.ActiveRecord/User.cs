using System.Collections.Generic;
using System.Linq;
using Castle.ActiveRecord;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    [ActiveRecord("users")]
    public class User : ActiveRecordBase<User>, IUser {
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType = "Int32")]
        public virtual int Id { get; set; }

        [Property("first_name",  NotNull = true)]
        public virtual string FirstName { get; set; }

        [Property("last_name",  NotNull = true)]
        public virtual string LastName { get; set; }

        public virtual IUserIdentification Identification { get; set; }

        [HasAndBelongsToMany(typeof (Media), ColumnRef = "media_id", ColumnKey = "user_id", Table = "users_media")]
        public virtual IList<Media> MediaList { get; set; }

        public IEnumerable<IMediaElement> MediaCollection
        {
            get { return this.MediaList.Cast<IMediaElement>(); }
        }

        public IUserRole Role
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}