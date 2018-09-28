using ShowRoom.Data.Interfaces;
using ShowRoom.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowRoom.Data.Repository
{
    public class CarburantRepository : Repository<Carburant>, ICarburantRepository
    {
        public CarburantRepository(ShowRoomDbContext context) : base(context)
        {

        }
    }
}
