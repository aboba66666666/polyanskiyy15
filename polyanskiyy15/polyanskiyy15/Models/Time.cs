using System;
using SQLite;

namespace polyanskiyy15.Models
{
    class Time
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Interval { get; set; }
    }
}
