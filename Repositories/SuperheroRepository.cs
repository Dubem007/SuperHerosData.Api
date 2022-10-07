using SuperHerosDatas.Api.Data;
using SuperHerosDatas.Api.Interfaces;

namespace SuperHerosDatas.Api.Repositories
{
    public class SuperheroRepository : ISuperheroRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperheroRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
