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
            List<Departamento> listadepartamentos = this.context.GetDepartamentos();
            return View(listadepartamentos);
        }
        public IActionResult Details(int iddepartamento)
        {
            Departamento departamento = this.context.FindDepartamento(iddepartamento);
            return View(departamento);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int iddepartamento, String nombre, String localidad)
        {
            this.context.InsertarDepartamento(iddepartamento, nombre, localidad);
            //para que nos envie a otra vista
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int iddepartamento)
        {
            Departamento departamento = this.context.FindDepartamento(iddepartamento);
            return View(departamento);
        }
        [HttpPost]
        public IActionResult Edit(int iddepartamento, String nombre, String localidad)
        {
            this.context.UpdateDepartamento(iddepartamento, nombre, localidad);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int iddepartamento)
        {
            this.context.DeleteDepartamento(iddepartamento);
            return RedirectToAction("Index");
        }
    }
}
