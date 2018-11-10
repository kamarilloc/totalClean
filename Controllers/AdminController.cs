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

    public async Task<IActionResult> Oficinas(string empresa,string usuario,string ciudad,string distrito)
        {
             var oficinas = from m in _context.Oficina
                 select m;

            if (!String.IsNullOrEmpty(empresa))
            {
                oficinas = oficinas.Where(u => u.Empresa.Contains(empresa));
            }
            if (!String.IsNullOrEmpty(usuario))
            {
                oficinas = oficinas.Where(u => u.User.Contains(usuario));
            }
            if (!String.IsNullOrEmpty(ciudad))
            {
                oficinas = oficinas.Where(u => u.Ciudad.Contains(ciudad));
            }
            if (!String.IsNullOrEmpty(distrito))
            {
                oficinas = oficinas.Where(u => u.Distrito.Contains(distrito));
            }
            
            return View(await oficinas.ToListAsync());
        }
        public async Task<IActionResult> Hogares(string usuario, string ciudad,string distrito,string tipo)
        {
             var hogares = from m in _context.Hogar
                 select m;

            if (!String.IsNullOrEmpty(usuario))
            {
                hogares = hogares.Where(h => h.User.Equals(usuario));
            }
            if (!String.IsNullOrEmpty(ciudad))
            {
                hogares = hogares.Where(h => h.Ciudad.Equals(ciudad));
            }

            if (!String.IsNullOrEmpty(distrito))
            {
                hogares = hogares.Where(h => h.Distrito.Equals(distrito));
            }
            if (!String.IsNullOrEmpty(tipo))
            {
                hogares = hogares.Where(h => h.Tipo.Equals(tipo));
            }
            
            return View(await hogares.ToListAsync());
        }
        public async Task<IActionResult> Usuarios(string usuario,string nombre)
        {
             var usuarios = from m in _context.Usuario
                 select m;

            if (!String.IsNullOrEmpty(usuario))
            {
                usuarios = usuarios.Where(u => u.Nombre.Equals(usuario));
            }
            if (!String.IsNullOrEmpty(nombre))
            {
                usuarios = usuarios.Where(u => u.User.Equals(nombre));
            }
            
            
            return View(await usuarios.ToListAsync());
        }
       
    }
}