using ShowRoom.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShowRoom.Data.Interfaces;

namespace ShowRoom.Data.Repository
{
    public class MarqueRepository : Repository<Marque>, IMarqueRepository
    {
        public MarqueRepository(ShowRoomDbContext context) : base(context)
        {
            
        }
    }
}
