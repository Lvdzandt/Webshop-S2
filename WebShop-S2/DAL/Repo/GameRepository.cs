using DAL.Interface;
using DAL.SQLContext;
using Model;
using System.Collections.Generic;

namespace DAL.Repo
{
    public class GameRepository
    {
        public readonly IGameContext GameContext = new GameSqlContext(); 
        public Game GetGame(int id)
        {
            return GameContext.GetGame(id);
        }

        public List<Game> GetAllGames()
        {
            return GameContext.GetAllGames();
        }

        public void AddGame(Game game)
        {
            GameContext.AddGame(game);
        }

    }
}
