using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IGameContext
    {
        Game GetGame(int id);
    }
}
