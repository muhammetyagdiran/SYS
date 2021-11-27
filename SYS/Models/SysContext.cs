using Microsoft.EntityFrameworkCore;
using SYS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYS.Models
{
    public class SysContext:DbContext
    {
        public SysContext(DbContextOptions<SysContext> options):base(options)
        {

        }
        public DbSet<SporcuBilgi> SporcuBilgiler { get; set; }
    }
}
