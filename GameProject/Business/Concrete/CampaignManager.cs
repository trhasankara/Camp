using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;

namespace GameProject.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public Campaign Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
            return campaign;
        }

        public Campaign Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
            return campaign;
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        
    }
}
