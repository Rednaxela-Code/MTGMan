using MTGManager.Shared.Models;

namespace MTGManager.DataAccess.Repository.IRepository
{
    public interface ICardRepository : IRepository<Card>
    {
        void Update(Card obj);
    }
}
