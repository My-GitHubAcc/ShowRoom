using ShowRoom.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShowRoom.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ShowRoom.Data.Repository
{
    public class MarqueRepository : Repository<Marque>, IMarqueRepository
    {
        public MarqueRepository(ShowRoomDbContext context) : base(context)
        {
            
        }
        public Marque FindWithModels(int id)
        {
            return _context.Marque
                .Where(mq => mq.MarqueId == id)
                .Include(md => md.Models)
                .FirstOrDefault();
        }
    }
}
