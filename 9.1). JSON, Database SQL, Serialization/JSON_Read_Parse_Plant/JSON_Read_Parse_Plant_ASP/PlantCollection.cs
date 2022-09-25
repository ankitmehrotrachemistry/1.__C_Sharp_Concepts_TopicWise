using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSON_Read_Parse_Plant_ASP
{
    public class PlantCollection
    {
        private List<Plant> plants;
        public List<Plant> Plants { get => plants; set => plants = value; }
    }
}