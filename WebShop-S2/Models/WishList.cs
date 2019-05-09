using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public static class WishList
    {
        public static List<Game> GameList { get; set; }

        static WishList()
        {
            GameList = new List<Game>();
        }

        public static void AddGame(Game game)
        {
            GameList.Add(game);
        }
    }
}
