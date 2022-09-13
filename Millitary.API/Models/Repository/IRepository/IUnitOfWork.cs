namespace RudoRwedu.API.Models.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IRoleRepository Role { get; }
        ICompanyRepository Company { get; }
        ICategoryRepository Category { get; }
        void SaveChanges();
    }
}