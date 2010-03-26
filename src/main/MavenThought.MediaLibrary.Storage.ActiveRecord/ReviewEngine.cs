using Castle.ActiveRecord;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    [ActiveRecord("review_engines")]
    public class ReviewEngine : ActiveRecordBase<ReviewEngine>, IReviewEngine
    {
        public IMediaReview Find(IMediaElement media)
        {
            throw new System.NotImplementedException();
        }

        [PrimaryKey(PrimaryKeyType.Native, "id")]
        public virtual int Id { get; set; }

        [Property("title", NotNull = true)]
        public virtual string Title { get; set; }

        [Property("description",  NotNull = true)]
        public virtual string Description { get; set; }
    }
}