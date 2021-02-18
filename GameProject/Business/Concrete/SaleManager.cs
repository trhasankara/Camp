using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;

namespace GameProject.Business.Concrete
{
    public class SaleManager : ISaleService
    {
        public Sale Add(Game game, Gamer gamer)
        {
            Console.WriteLine("Oyun satın alındı");
            return new Sale();
        }

        public Sale Add(Game game, Gamer gamer, ICampaignService campaign)
        {
            Console.WriteLine("Oyun kampanyalı satın alındı");
            return new Sale();
        }
    }
}
