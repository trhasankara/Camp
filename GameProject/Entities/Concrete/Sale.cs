using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities.Concrete
{
    public class Sale:IEntity
    {
        public int Id { get; set; }
        public int GamerId { get; set; }
        public int GameId { get; set; }
    }
}
