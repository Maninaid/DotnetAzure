using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Codebasedexam5.Models;

namespace Codebasedexam5.Data
{
    public class Codebasedexam5Context : DbContext
    {
        public Codebasedexam5Context (DbContextOptions<Codebasedexam5Context> options)
            : base(options)
        {
        }

        public DbSet<Codebasedexam5.Models.Student> Student { get; set; }
    }
}
