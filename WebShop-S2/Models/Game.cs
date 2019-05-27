using System;
using System.Collections.Generic;

namespace Model
{
    public enum Tag
    {
        Action,
        RPG,
        FPS,
        Platformer
    }

    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        //public Tag GameTag  { get; set; }
        public string GameTag { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
