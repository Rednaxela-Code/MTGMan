using MTGManager.Shared.Models;

namespace MTGManager.DataAccess.Repository.IRepository
{
    public interface ICardRepository : IRepository<ScryfallCard>
    {
        void Update(ScryfallCard obj);
    }
}
