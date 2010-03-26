using System.Collections.Generic;

namespace MediaLibrary.Core.Model.ADOEF
{
    public partial class User: IUser
    {
        public IUserIdentification Identification
        {
            get { throw new System.NotImplementedException(); }
        }

        public IEnumerable<IMediaElement> MediaCollection
        {
            get { throw new System.NotImplementedException(); }
        }

        public IUserRole Role
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}