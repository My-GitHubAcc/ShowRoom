using ShowRoom.Data.Interfaces;
using ShowRoom.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowRoom.Data.Repository
{
    public class TransmissionRepository : Repository<Transmission>, ITransmissionRepository
    {
        public TransmissionRepository(ShowRoomDbContext context) : base(context)
        {

        }
    }
}
