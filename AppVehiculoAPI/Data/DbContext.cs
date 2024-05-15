﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppVehiculos.Entidades;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<AppVehiculos.Entidades.Marca> Marcas { get; set; } = default!;

        public DbSet<AppVehiculos.Entidades.Vehiculo> Vehiculos { get; set; } = default!;
    }
