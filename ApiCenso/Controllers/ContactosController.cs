using ApiCenso.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCenso.Models;

namespace ApiCenso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactosController : ControllerBase
    {
     
          private readonly ContactoContext _context;

        public ContactosController(ContactoContext contexto)
        {
            _context = contexto;

        }

        [HttpGet]

        public async Task<IActionResult> GetContacto()
        {
            var list = await _context.ContactoItems.OrderBy(c => c.nombre).ToListAsync();

            return Ok(list);
        }

 

        [HttpPost]
        public async Task<IActionResult> AgregarContactos(Contacto contactos)
        {
            if (contactos == null)
            {
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.AddAsync(contactos);
            await _context.SaveChangesAsync();

            return Ok();
        } 
        [HttpGet("{DateTime}")]
        public async Task<IActionResult> GetAge (DateTime DateTime)
           
        {
            DateTime now = DateTime.Today;
            int age = now.Year - DateTime.Year;

            if (DateTime.Today < DateTime.AddYears(age)) age--;

            return Ok(age);



        
           





        }

    }
}
