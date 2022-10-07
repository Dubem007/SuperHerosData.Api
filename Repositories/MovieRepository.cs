using SuperHerosDatas.Api.Data;
using SuperHerosDatas.Api.Interfaces;

namespace SuperHerosDatas.Api.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
