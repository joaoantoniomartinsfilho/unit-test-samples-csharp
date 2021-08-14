namespace OrderEcommerce.Domain.Repositories
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}
