namespace ShowRoom.Repository
{
    public class PaysRepository : Repository<Pays, DbEntities>
    {
        private static PaysRepository paysRepository = null;

        public static PaysRepository getInstance()
        {
            paysRepository = new PaysRepository();
            return paysRepository;
        }
    }
}