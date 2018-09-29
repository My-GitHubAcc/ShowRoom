using Microsoft.EntityFrameworkCore;
using ShowRoom.Data.Interfaces;
using ShowRoom.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowRoom.Data.Repository
{
    public class ModelRepository : Repository<Model.Models>, IModelRepository
    {
        public ModelRepository(ShowRoomDbContext context) : base(context)
        {

        }

        public Models FindWithDetails(int id)
        {
            return _context.Models
                .Where(md => md.ModelId == id)
                .Include(c => c.Carburant)
                .Include(t => t.TypeVoiture)
                .Include(tr => tr.Transmission)
                .Include(p => p.PayFabricationNavigation)
                .Include(mq => mq.Marque)
                .FirstOrDefault();
        }
    }
}
