using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionarioApp
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext()
        {
        }
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;");
            }
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
