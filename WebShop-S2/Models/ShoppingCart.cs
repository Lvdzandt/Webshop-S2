using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public static class ShoppingCart
    {
        public static List<Game> GameList { get; set; }

        static ShoppingCart()
        {
            GameList = new List<Game>();
        }

        public static void AddGame(Game game)
        {
            GameList.Add(game);
        }
    }
}
