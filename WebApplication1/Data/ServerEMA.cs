using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

    public class ServerEMA : DbContext
    {
        public ServerEMA (DbContextOptions<ServerEMA> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.OrdenTrabajo> OrdenTrabajo { get; set; } = default!;

public DbSet<WebApplication1.Models.Pagos> Pagos { get; set; } = default!;

public DbSet<WebApplication1.Models.Empleado> Empleado { get; set; } = default!;
    }
