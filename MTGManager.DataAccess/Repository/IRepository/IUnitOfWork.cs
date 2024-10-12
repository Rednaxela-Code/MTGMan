namespace MTGManager.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICardRepository Card { get; }

        Task Save();
    }
}
