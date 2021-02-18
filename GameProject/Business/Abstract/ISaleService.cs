using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities.Concrete;

namespace GameProject.Business.Abstract
{
    public interface ISaleService
    {
        Sale Add(Game game, Gamer gamer);
    }
}
