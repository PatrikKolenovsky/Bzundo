﻿using Bzundo.Models;
using Microsoft.EntityFrameworkCore;

namespace Bzundo.Repository
{
    public class BzundoContext : DbContext
    {
        public BzundoContext(DbContextOptions<BzundoContext> opt) : base(opt)
        {
            
        }

        public DbSet<BzundoCmd> Commands { get; set; }
    }
}