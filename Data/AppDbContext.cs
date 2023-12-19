using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMWebApi.Models;

namespace MMWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; } // DbSET Representação da tabela

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite("DataSourc=app.db;Cache=Shared");

 
    }
}