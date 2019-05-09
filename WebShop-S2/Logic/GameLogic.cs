using DAL.Repo;
using Model;
using System;
using System.Collections.Generic;

namespace Logic
{
    public class GameLogic
    {
        private GameRepository _repo = new GameRepository();

        public Game GetGame(int id)
        {
            return _repo.GetGame(id);
        }

        public List<Game> GetAllGames()
        {
            return _repo.GetAllGames();
        }
    }
}
