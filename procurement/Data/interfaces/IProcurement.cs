using procurement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace procurement.Data.interfaces
{
    public interface IProcurement
    {
        IEnumerable<Procurement> GetAllCompanies { get; /*set;*/ }
        Procurement getObjectPr(int id);
    }

   
}
