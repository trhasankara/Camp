using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities.Concrete;

namespace GameProject.Business.Abstract
{
    public interface ICampaignService
    {
        Campaign Add(Campaign campaign);
        Campaign Update(Campaign campaign);

        void Delete(Campaign campaign)
    }
}
