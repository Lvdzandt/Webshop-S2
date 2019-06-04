using System;
using DAL.Interface;
using DAL.SQLContext;
using Model;
using System.Collections.Generic;

namespace DAL.Repo
{
    public class GameRepository
    {
        public readonly IGameContext GameContext = new GameSqlContext();

        public GameRepository()
        {

        }

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

        public List<Tuple<string, int>> GetGameCount()
        {
            return GameContext.GetGameCount();
        }

    }
}
