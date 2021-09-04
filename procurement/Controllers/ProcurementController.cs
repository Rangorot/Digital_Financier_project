using Microsoft.AspNetCore.Mvc;
using procurement.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace procurement.Controllers
{
    public class ProcurementController : Controller
    {
        private readonly IProcurement _proc;
        public ProcurementController(IProcurement iProcurement)
        {
            _proc = iProcurement;

        }

        public ViewResult List()
        {
            ViewBag.Procu = "Some New";
            var procs = _proc.GetAllCompanies;
            return View(procs);
        }
    }
}
