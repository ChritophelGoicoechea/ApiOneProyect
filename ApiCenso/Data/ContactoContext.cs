using ApiCenso.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCenso.Data
{
    public class ContactoContext : DbContext
    {
        public ContactoContext(DbContextOptions<ContactoContext> options):base(options)
        {

        }
        public DbSet<Contacto> ContactoItems { get; set; }

        
    }
}
