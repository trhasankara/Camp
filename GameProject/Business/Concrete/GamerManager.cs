using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using GameProject.Adapters;
using GameProject.Business.Abstract;

namespace GameProject.Business
{
    public class GamerManager:IGamerService
    {
        public Gamer Add(Gamer player)
        {
            if (new MernisServiceAdapter().CheckPlayerValid(player))
            {
                Console.WriteLine("Oyuncu kaydedildi");
            }
            else
            {
                Console.WriteLine("Oyuncu kaydedilemedi");
            }
            return player;
        }

        public Gamer Update(Gamer player)
        {
            Console.WriteLine("Oyuncu güncellendi");
            return player;
        }

        public void Delete(Gamer player)
        {
            Console.WriteLine("Oyuncu silindi");
        }
    }
}
