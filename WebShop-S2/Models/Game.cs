using System;
using System.Collections.Generic;

namespace Model
{
    public enum Tags
    {
        Action,
    }

    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public List<Tags> GameTags  { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
