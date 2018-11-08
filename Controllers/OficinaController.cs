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
    public class OficinaController : Controller
    {
        private readonly MvcContext _context;

        public OficinaController(MvcContext context)
        {
            _context = context;
        }

        public IActionResult Inicio()
        {
            return View();
        }
        public async Task<IActionResult>  Conectado(string usuario)
        {
            var usuarios = from m in _context.Usuario
                 select m;

            
                usuarios = usuarios.Where(u => u.User.Equals(usuario));
                
            return View(await usuarios.ToListAsync());
        }

        
        public IActionResult RegistrarUsuario()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarUsuario([Bind("Nombre","Apellidos","User","Contraseña","ConfirmarContraseña","Correo","ConfirmarCorreo")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Inicio");
            }
            return View(usuario);
        }

        public async Task<IActionResult> RegistrarServicio([Bind("User","Empresa","RUC","Correo","Telefono","Dia","Horas","Ciudad","Distrito","Direccion")] Oficina oficina)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oficina);
                await _context.SaveChangesAsync();
                return RedirectToAction("Inicio");
            }
            return View(oficina);
        }

public async Task<IActionResult> Conectar(string usuario)
        {
             var usuarios = from m in _context.Usuario
                 select m;

            if (!String.IsNullOrEmpty(usuario))
            {
                usuarios = usuarios.Where(u => u.User.Equals(usuario));
                
                return RedirectToAction("RegistrarServicio");
            }
            
            return View(await usuarios.ToListAsync());
        }

        
         
        public async Task<IActionResult> ConfirmarUsuario(string usuario)
        {
             var oficinas = from m in _context.Oficina
                 select m;

            if (!String.IsNullOrEmpty(usuario))
            {
                oficinas = oficinas.Where(o => o.User.Equals(usuario));
                
                return RedirectToAction("Empresa");
            }
            
            return View(await oficinas.ToListAsync());
        }
       
       public async Task<IActionResult> Oficinas (string usuario)
        {
             var oficinas = from m in _context.Oficina
                 select m;

            
                oficinas= oficinas.Where(o => o.User.Equals(usuario));
                
           
            
            return View(await oficinas.ToListAsync());
        }
        
    }
}