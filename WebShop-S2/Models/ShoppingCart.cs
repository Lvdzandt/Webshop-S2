using System.Collections.Generic;

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
            bool Double = false;
            foreach (var item in GameList)
            {
                if (item.Name == game.Name)
                {
                    Double = true;
                }
            }
            if (!Double)
            {
                GameList.Add(game);
            }
        }
    }
}
