namespace ShowRoom.Repository
{
    public class TransmissionRepository : Repository<Transmission, DbEntities>
    {
        private static TransmissionRepository transmissionRepository = null;

        public static TransmissionRepository getInstance()
        {
            transmissionRepository = new TransmissionRepository();
            return transmissionRepository;
        }
    }
}