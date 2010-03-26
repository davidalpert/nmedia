using Castle.ActiveRecord;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    [ActiveRecord("reviews")]
    public class MediaReview : ActiveRecordBase<MediaReview>, IMediaReview 
    {
        public string Review
        {
            get { return this.ReviewContent; }
        }

        [PrimaryKey(PrimaryKeyType.Native, "id")]
        public virtual int Id { get; set; }

        [Property("review", NotNull = true)]
        public virtual string ReviewContent { get; set; }

        [BelongsTo("media_id")]
        public virtual Media Media { get; set; }

        [BelongsTo("review_engine_id")]
        public virtual ReviewEngine ReviewEngine { get; set; }
    }
}