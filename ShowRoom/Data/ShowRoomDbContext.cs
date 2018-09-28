using ShowRoom.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowRoom.Data
{
    public class ShowRoomDbContext : DbContext
    {
        public ShowRoomDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Carburant> Carburants { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Model.Model> Models { get; set; }
        public DbSet<Pays> Pays { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<TypeVoiture> TypeVoitures { get; set; }
    }
}
