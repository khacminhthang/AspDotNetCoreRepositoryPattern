using AspDotNetCoreRepositoryPattern.Models;

namespace AspDotNetCoreRepositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, DBContext>
    {
        public EfCoreMovieRepository(DBContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
