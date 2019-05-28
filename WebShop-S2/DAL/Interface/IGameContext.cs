using System;
using Model;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IGameContext
    {
        Game GetGame(int id);
        List<Game> GetAllGames();
        void AddGame(Game game);
        List<Tuple<string, int>> GetGameCount();
    }
}
