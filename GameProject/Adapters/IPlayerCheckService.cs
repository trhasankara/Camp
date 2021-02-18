using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public interface IPlayerCheckService
    {
        bool CheckPlayerValid(Gamer player);
    }
}
