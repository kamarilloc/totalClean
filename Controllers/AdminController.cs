using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TotalClean.Models;

namespace TotalClean.Controllers
{
    public class AdminController : Controller
    {
        private readonly MvcContext _context;

        public AdminController(MvcContext context)
        {
            _context = context;
        }

        
        
 public async Task<IActionResult> Usuarios(string searchString)
        {
             var usuarios = from m in _context.Usuario
                 select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                usuarios = usuarios.Where(u => u.Nombre.Contains(searchString));
            }
            
            return View(await usuarios.ToListAsync());
        }
public async Task<IActionResult> Conectar(string contraseña)
        {
             var admins = from t in _context.Admin
                 select t;

            if (!String.IsNullOrEmpty(contraseña))
            {
                admins = admins.Where(a => a.Contraseña.Equals(contraseña));
                
                return RedirectToAction("Conectado");
            }
            
            return View(await admins.ToListAsync());
        }
       
        public async Task<IActionResult> Conectado(string contraseña)
        {
            var admins = from t in _context.Admin
                 select t;

            
                admins = admins.Where(a => a.Contraseña.Equals(contraseña));
                
           
            
            return View(await admins.ToListAsync());
        }

    public async Task<IActionResult> Oficinas(string searchString)
        {
             var oficinas = from m in _context.Oficina
                 select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                oficinas = oficinas.Where(u => u.User.Contains(searchString));
            }
            
            return View(await oficinas.ToListAsync());
        }
        public async Task<IActionResult> Hogares(string usuario, string ciudad,string distrito,string tipo)
        {
             var hogares = from m in _context.Hogar
                 select m;

            if (!String.IsNullOrEmpty(usuario))
            {
                hogares = hogares.Where(h => h.User.Contains(usuario));
            }
            if (!String.IsNullOrEmpty(ciudad))
            {
                hogares = hogares.Where(h => h.Ciudad.Contains(ciudad));
            }

            if (!String.IsNullOrEmpty(distrito))
            {
                hogares = hogares.Where(h => h.Distrito.Contains(distrito));
            }
            if (!String.IsNullOrEmpty(tipo))
            {
                hogares = hogares.Where(h => h.Tipo.Contains(tipo));
            }
            
            return View(await hogares.ToListAsync());
        }
       
    }
}