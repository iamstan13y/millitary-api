namespace Millitary.API.Models.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IRoleRepository Role { get; }
        ISoldierRepository Soldier { get; }
        ICategoryRepository Category { get; }
        void SaveChanges();
    }
}