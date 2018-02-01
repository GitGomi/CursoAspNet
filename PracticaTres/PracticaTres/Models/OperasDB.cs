using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PracticaTres.Models
{
    public class OperasDB : DbContext
    {
        public OperasDB() : base("EmpresaDB") { }
        public DbSet<Opera> Operas { get; set; }
    }
}