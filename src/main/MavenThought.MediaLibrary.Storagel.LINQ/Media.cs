using System.Collections.Generic;

namespace MediaLibrary.Core.Model.ADOEF
{
    public partial class Media
    {
        public ISearchEngine SearchEngine
        {
            get { throw new System.NotImplementedException(); }
        }

        public ICollection<IMediaReview> Reviews
        {
            get { throw new System.NotImplementedException(); }
        }


    }
}