using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace procurement.Data.Models
{
    public class Procurement
    {
        public int id { set; get; }

        public string productName { set; get; }

        public string company { set; get; }

        public string date { set; get; }

        public int price { set; get; }


    }
}
