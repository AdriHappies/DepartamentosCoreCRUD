using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepartamentosCoreCRUD.Data;
using DepartamentosCoreCRUD.Models;

namespace DepartamentosCoreCRUD.Controllers
{
    public class DepartamentosController : Controller
    {
        DepartamentosContext context;
        public DepartamentosController(DepartamentosContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
