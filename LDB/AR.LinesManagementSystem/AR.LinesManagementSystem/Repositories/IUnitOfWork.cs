namespace AR.LinesManagementSystem.Repositories
{
    public interface IUnitOfWork
    {
        ConnectivityCategoryRepository connectivityCategoryRepository { get; }
        ConnectivityProviderTypeRepository connectivityProviderTypeRepository { get; }
        ReasonRepository reasonRepository { get; }
        void Dispose();
    }
}