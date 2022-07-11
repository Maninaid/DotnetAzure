using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodebasedEvaluation6.Models;

namespace CodebasedEvaluation6.Data
{
    public class CodebasedEvaluation6Context : DbContext
    {
        public CodebasedEvaluation6Context (DbContextOptions<CodebasedEvaluation6Context> options)
            : base(options)
        {
        }

        public DbSet<CodebasedEvaluation6.Models.Employee> Employee { get; set; }
    }
}
