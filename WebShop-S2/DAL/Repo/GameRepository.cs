using DAL.Interface;
using DAL.SQLContext;
using Model;
using System;
using System.Collections.Generic;

namespace DAL.Repo
{
    public class GameRepository
    {
        IGameContext gameContext = new GameSQLContext(); 
        public Game GetGame(int id)
        {
            return gameContext.GetGame(id);
        }

        public List<Game> GetAllGames()
        {
            return gameContext.GetAllGames();
        }

    }
}
