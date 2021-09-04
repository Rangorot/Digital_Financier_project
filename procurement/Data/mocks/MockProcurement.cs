using procurement.Data.interfaces;
using procurement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace procurement.Data.mocks
{
    public class MockProcurement : IProcurement
    {
        public IEnumerable<Procurement> GetAllCompanies
        {

            get 
            {
                return new List<Procurement>
                {
                    new Procurement { productName = "Стулья", company = "ФЭНС", date = "29.06.2001", price = 100000 }
                };
            }
            /*set; */}

        public Procurement getObjectPr(int id)
        {
            throw new NotImplementedException();
        }
    }
}

