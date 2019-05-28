using System;
using DAL.Repo;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class GameLogic
    {
        private readonly GameRepository _repo = new GameRepository();

        public Game GetGame(int id)
        {
            return _repo.GetGame(id);
        }

        public List<Game> GetAllGames()
        {
            return _repo.GetAllGames();
        }

        public void AddGame(Game game)
        {
            _repo.AddGame(game);
        }

        public List<Tuple<string, int>> GetGameCount()
        {
            return _repo.GetGameCount();
        }
    }
}
