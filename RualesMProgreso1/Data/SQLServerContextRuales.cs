using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RualesMProgreso1.Models;

    public class SQLServerContextRuales : DbContext
    {
        public SQLServerContextRuales (DbContextOptions<SQLServerContextRuales> options)
            : base(options)
        {
        }

        public DbSet<RualesMProgreso1.Models.Dueno> Dueno { get; set; } = default!;

public DbSet<RualesMProgreso1.Models.Cita> Cita { get; set; } = default!;

public DbSet<RualesMProgreso1.Models.Mascota> Mascota { get; set; } = default!;
    }
