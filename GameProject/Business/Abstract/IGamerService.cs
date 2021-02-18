using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface IGamerService
    {
        Gamer Add(Gamer player);
        Gamer Update(Gamer player);
        void Delete(Gamer player);
    }
}
