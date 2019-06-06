using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Model
{
    public static class ShoppingCart
    {
        private static List<Game> GameList { get; set; }

        static ShoppingCart()
        {
            GameList = new List<Game>();
        }

        public static List<Game> GetShoppingList()
        {
            return GameList;
        }

        public static void ClearList()
        {
            GameList.Clear();
        }

        public static void RemoveGame(int id)
        {
            GameList.RemoveAll(item => item.Id == id);
            
        }

        public static void AddGame(Game game)
        {
            bool alreadyExists = false;
            foreach (var item in GameList)
            {
                if (item.Name == game.Name)
                {
                    alreadyExists = true;
                }
            }
            if (!alreadyExists)
            {
                GameList.Add(game);
            }
        }
    }
}
