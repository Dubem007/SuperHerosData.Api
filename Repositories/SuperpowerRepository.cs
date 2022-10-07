using SuperHerosDatas.Api.Data;
using SuperHerosDatas.Api.Interfaces;

namespace SuperHerosDatas.Api.Repositories
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperpowerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
