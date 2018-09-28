using ShowRoom.Data.Interfaces;
using ShowRoom.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowRoom.Data.Repository
{
    public class PaysRepository : Repository<Pays>, IPaysRepository
    {
        public PaysRepository(ShowRoomDbContext context) : base(context)
        {

        }
    }
}
