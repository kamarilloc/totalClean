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
    }
}