using ShowRoom.Models;

namespace ShowRoom.Repository
{
    public class MarqueRepository : Repository<Marque, DbEntities>
    {
        private static MarqueRepository marqueRepository = null;

        public static MarqueRepository getInstance()
        {
            marqueRepository = new MarqueRepository();
            return marqueRepository;
        }
    }
}