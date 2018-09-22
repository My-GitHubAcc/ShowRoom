namespace ShowRoom.Repository
{
    public class TypeVoitureRepository : Repository<TypeVoiture, DbEntities>
    {
        private static TypeVoitureRepository typeVoitureRepository = null;

        public static TypeVoitureRepository getInstance()
        {
            typeVoitureRepository = new TypeVoitureRepository();
            return typeVoitureRepository;
        }
    }
}