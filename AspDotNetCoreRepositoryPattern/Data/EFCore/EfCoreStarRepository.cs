using AspDotNetCoreRepositoryPattern.Models;

namespace AspDotNetCoreRepositoryPattern.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, DBContext>
    {
        public EfCoreStarRepository(DBContext context) : base(context)
        {

        }
    }
}
