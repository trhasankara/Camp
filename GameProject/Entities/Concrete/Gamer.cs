using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string NationalityId { get; set; }
        public int BirthYear { get; set; }
    }
}
