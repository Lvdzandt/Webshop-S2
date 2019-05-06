using DAL.Interface;
using DAL.SQLContext;
using Model;
using System;

namespace DAL.Repo
{
    public class GameRepository
    {
        IGameContext gameContext = new GameSQLContext(); 
        public Game GetGame(int id)
        {
            return gameContext.GetGame(id);
        }

    }
}
