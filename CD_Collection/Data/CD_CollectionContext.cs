using CD_Collection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CD_Collection.Data
{
    public class CD_CollectionContext : DbContext
    {
        public CD_CollectionContext(DbContextOptions<CD_CollectionContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }


    }
}
