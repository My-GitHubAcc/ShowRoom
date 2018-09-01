using ShowRoom.Models;

namespace ShowRoom.Repository
{
    public class ModelRepository : Repository<Model, DbEntities>
    {
        private static ModelRepository modelRepository = null;

        public static ModelRepository getInstance()
        {
            modelRepository = new ModelRepository();
            return modelRepository;
        }
    }
}