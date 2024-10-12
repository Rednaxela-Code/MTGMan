using MTGManager.DataAccess.Database;
using MTGManager.DataAccess.Repository.IRepository;
using MTGManager.Shared.Models;

namespace MTGManager.DataAccess.Repository
{
    public class CollectionRepository : Repository<Collection>, ICollectionRepository
    {
        private ApplicationDbContext _db;

        public CollectionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Collection obj)
        {
            _db.Collections.Update(obj);
        }
    }
}
