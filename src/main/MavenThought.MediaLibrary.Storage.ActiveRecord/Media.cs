using System;
using System.Collections.Generic;
using Castle.ActiveRecord;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    /// <summary>
    /// Media base class (joined by key)
    /// </summary>
    [ActiveRecord("media"), JoinedBase]
    public abstract class Media : ActiveRecordBase<Media>, IMediaElement {
        
        public ISearchEngine SearchEngine
        {
            get { return this.SourceEngine; }
        }

        public ICollection<IMediaReview> Reviews
        {
            get { throw new NotImplementedException(); }
        }

        [PrimaryKey(PrimaryKeyType.Native, "id" )]
        public virtual int Id { get; set; }

        [Property("title", NotNull = true)]
        public virtual string Title { get; set; }

        [Property("release_date", NotNull = true)]
        public virtual DateTime? ReleaseDate { get; set; }

        [Property("added_date", NotNull = true)]
        public virtual DateTime AddedDate { get; set; }

        [HasMany(typeof(MediaReview), ColumnKey = "media_id", Table = "reviews")]
        public virtual IList<MediaReview> ReviewList { get; set; }

        [BelongsTo("search_engine_id")]
        public virtual SearchEngine SourceEngine { get; set; }

        [HasAndBelongsToMany(typeof (User), ColumnRef = "user_id", ColumnKey = "media_id", Table = "users_media")]
        public virtual IList<User> Users { get; set; }

        public User User
        {
            get { return Users[0]; }

            set { Users = new List<User> {value}; }
        }
    }
}