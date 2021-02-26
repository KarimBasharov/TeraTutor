using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace t
{
    [Table("Recipe")]
    public class Recipe
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
