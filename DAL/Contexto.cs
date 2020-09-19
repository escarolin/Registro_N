using Microsoft.EntityFrameworkCore;
using Registro_N.Entidades;

namespace Registro_N.DAL{
            public class Contexto: DbContext{
                public DbSet<Persona> Persona { get; set; }
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    optionsBuilder.UseSqlite(@"Data Source= Persona.db");
                }

            }
}
