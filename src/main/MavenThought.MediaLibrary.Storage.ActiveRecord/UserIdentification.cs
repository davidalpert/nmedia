using Castle.ActiveRecord;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    [ActiveRecord("login")]
    public class UserIdentification : ActiveRecordBase<UserIdentification>, IUserIdentification {

        [PrimaryKey(PrimaryKeyType.Native, "id")]
        public virtual int Id { get; set; }

        [Property("login", NotNull = true)]
        public virtual string LoginId { get; set; }

        public string Login { get { return this.LoginId; } }

        [Property("password",  NotNull = true)]
        public virtual string Password { get; set; }

        [BelongsTo("user_id")]
        public virtual User User { get; set; }
    }
}