using MTGManager.Shared.Models;

namespace MTGManager.DataAccess.Repository.IRepository
{
    public interface ICollectionRepository : IRepository<Collection>
    {
        void Update(Collection obj);
    }
}
