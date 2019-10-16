using SQLite;

namespace MovieList.Models
{
    public class Role
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NameOfRole { get; set; }
    }
}