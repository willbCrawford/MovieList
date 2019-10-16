using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MovieList.Models
{
    public class Credit
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}