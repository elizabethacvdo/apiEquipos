using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equiposApi.models;
using Microsoft.EntityFrameworkCore;

namespace equiposApi
{
    public class equipoContext: DbContext
    {
        public equipoContext(DbContextOptions<equipoContext>options):base(options)
        {

        }

        public DbSet<equipos> equipos{ get; set; }

    }
}
