namespace MediaLibrary.Core.Model.ActiveRecord
{
    /// <summary>
    /// Person implementation
    /// </summary>
    public class Person: IPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}