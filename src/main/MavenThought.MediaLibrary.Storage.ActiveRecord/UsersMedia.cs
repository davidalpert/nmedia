using Castle.ActiveRecord;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    [ActiveRecord("users_media")]
    public class UsersMedia : ActiveRecordBase<UsersMedia>
    {
        [PrimaryKey(PrimaryKeyType.Native, "id")]
        public virtual int Id { get; set; }

        [Property("user_id", NotNull = true)]
        public virtual int UserId { get; set; }

        [Property("media_id", NotNull = true)]
        public virtual int MediaId { get; set; }
    }
}
