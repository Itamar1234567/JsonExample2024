using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{

   


        public class Monkey
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Details { get; set; }
            public string Image { get; set; }
            public int Population { get; set; }
            public float Latitude { get; set; }
            public float Longitude { get; set; }
        }

    public class MonkeyList
    {
        public List<Monkey> Monkeys { get; set; }

        public MonkeyList()
        {
            Monkeys = new List<Monkey>();
        }
        
        
    }



}
