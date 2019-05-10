using System.Collections.Generic;

namespace Model
{
    public static class WishList
    {
        public static List<Game> GameList { get; set; }

        static WishList()
        {
            GameList = new List<Game>();
        }

        public static void RemoveGame(int id)
        {
            foreach (var item in GameList)
            {
                if (item.Id == id)
                {
                    GameList.Remove(item);
                    break;
                }
            }
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
