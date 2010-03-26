using System.Collections.Generic;
using Castle.ActiveRecord;

namespace MediaLibrary.Core.Model.ActiveRecord
{
    [ActiveRecord("search_engines")]
    public class SearchEngine : ActiveRecordBase<SearchEngine>, ISearchEngine {
        
        [PrimaryKey(PrimaryKeyType.Native, "id")]
        public virtual int Id { get; set; }

        [Property("name", NotNull = true)]
        public virtual string Name { get; set; }

        [Property("description", NotNull = true)]
        public virtual string Description { get; set; }

        public IEnumerable<IMediaElement> Find(string title)
        {
            throw new System.NotImplementedException();
        }
    }
}