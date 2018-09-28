﻿using ShowRoom.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowRoom.Data.Repository
{
    public class ModelRepository : Repository<Model.Model>, IModelRepository
    {
        public ModelRepository(ShowRoomDbContext context) : base(context)
        {

        }
    }
}
