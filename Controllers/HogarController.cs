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
    public class HogarController : Controller
    {
        private readonly MvcContext _context;

        public HogarController(MvcContext context)
        {
            _context = context;
        }
        // Cotroller Inicio
        public IActionResult Inicio()
        {
            return View();
        }
        // Luego de Conectarse pasa a un estado de conectado
        public async Task<IActionResult>  Conectado(string usuario)
        {
            var usuarios = from m in _context.Usuario
                 select m;

            
                usuarios = usuarios.Where(u => u.User.Equals(usuario));
                
            return View(await usuarios.ToListAsync());
        }
        // Registrar Usuario si no tiene una cuneta
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
        // Registrar el servicio de Hogar [*]
        public async Task<IActionResult> RegistrarServicio([Bind("User","Telefono","Dia","Horas","Ciudad","Distrito","Direccion","Tipo")] Hogar hogar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hogar);
                await _context.SaveChangesAsync();
                return RedirectToAction("Inicio");
            }
            return View(hogar);
        }
        //Conectar si ya tiene una cuenta
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
        //Confirmar Usuario
        public async Task<IActionResult> ConfirmarUsuarioO(string usuario)
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
        //
        public async Task<IActionResult> ConfirmarUsuarioH(string usuario)
        {
             var hogares = from m in _context.Oficina
                 select m;

            if (!String.IsNullOrEmpty(usuario))
            {
                hogares = hogares.Where(o => o.User.Equals(usuario));
                
                return RedirectToAction("Empresa");
            }
            
            return View(await hogares.ToListAsync());
        }
       //Servicios de limpieza solicitados [*]
       public async Task<IActionResult> Oficinas (string usuario)
        {
             var oficinas = from m in _context.Oficina
                 select m;

            
                oficinas= oficinas.Where(o => o.User.Equals(usuario));
                
           
            
            return View(await oficinas.ToListAsync());
        }
        //
        public async Task<IActionResult> Hogares (string usuario)
        {
             var hogares = from m in _context.Oficina
                 select m;

            
                hogares= hogares.Where(o => o.User.Equals(usuario));
                
           
            
            return View(await hogares.ToListAsync());
        }
        
    }
}