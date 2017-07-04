﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EjemploApi.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options): base(options)
        {
        }

        public DbSet<EjemploApi.Models.Cobros> Cobros { get; set; }
    }
}
