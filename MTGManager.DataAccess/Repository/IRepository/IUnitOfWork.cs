namespace MTGManager.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICardRepository Card { get; }

        ICollectionRepository Collection { get; }

        Task Save();
    }
}
