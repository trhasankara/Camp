using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter:IPlayerCheckService
    {
        public bool CheckPlayerValid(Gamer player)
        {
            //mernis doğrulama kodlarının olduğu kısım
            return true;
        }
    }
}
