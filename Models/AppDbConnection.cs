using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaAspNet.Models
{
    public class AppDbConnection : DbContext
    {
        public AppDbConnection(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
