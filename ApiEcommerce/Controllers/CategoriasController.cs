using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.Entidades;
using Manejadores.IManejadores;
using DTOS;

namespace ApiEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : Controller
    {
        //public IRepositorioCategoria RepoCat { get; set; }
        public IManejadorCategoria ManejadorCat { get; set; }
        public CategoriasController(IManejadorCategoria repInj)
        {
            ManejadorCat = repInj;
        }

        // GET: CategoriasController
        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()//FIND ALL
        {
            try
            {
                var categorias = ManejadorCat.ObtenerTodosLasCategorias();
                if (categorias == null) return BadRequest();
                return Ok(categorias);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }
        }

        // GET: CategoriasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


       

        // POST: CategoriasController/Create
        [HttpPost]
        [Route("Alta")]
        public ActionResult<CategoriaDTO> Alta([FromBody] CategoriaDTO categoria)
        {
            try
            {
                if(categoria == null) return BadRequest();
                Categoria nuevaCategoria = new Categoria();
                nuevaCategoria.Nombre = categoria.Nombre;
                bool resultado = ManejadorCat.DarDeAltaCategoria(nuevaCategoria);
                return Ok(resultado);
            }
            catch
            {
                return View();
            }
        }
        // GET: CategoriasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }


        // POST: CategoriasController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            bool ok = false;
            try
            {
                if (id <= 0) return BadRequest();
                
                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }
    }
}
