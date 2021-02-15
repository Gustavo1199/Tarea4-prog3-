using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infracciones
{
    class MultaContex: DbContext
    {
        public DbSet<error> datos { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder opcion)
        {
            if (!opcion.IsConfigured)
            {
                opcion.UseSqlite("Data Source = Personas.db");
            }
        }

        public virtual DbSet<error> lista { get; set;}


    }
}
