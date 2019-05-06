using DAL.Repo;
using Model;
using System;

namespace Logic
{
    public class GameLogic
    {
        private GameRepository _repo = new GameRepository();

        public Game GetGame(int id)
        {
            return _repo.GetGame(id);
        }
    }
}
