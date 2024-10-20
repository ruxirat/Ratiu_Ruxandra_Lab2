using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ratiu_Ruxandra_Lab2.Models;

namespace Ratiu_Ruxandra_Lab2.Data
{
    public class Ratiu_Ruxandra_Lab2Context : DbContext
    {
        public Ratiu_Ruxandra_Lab2Context (DbContextOptions<Ratiu_Ruxandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ratiu_Ruxandra_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ratiu_Ruxandra_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
