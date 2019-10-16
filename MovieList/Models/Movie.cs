using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MovieList.Models
{
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        [OneToMany]
        public List<Credit> Credits { get; set; }
    }
}
