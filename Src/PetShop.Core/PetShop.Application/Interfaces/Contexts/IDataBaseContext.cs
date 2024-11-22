using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Entities.Users;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop.Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
         DbSet<User> Users { get; set; }
         DbSet<Role> Roles { get; set; }
         DbSet<UserInRole> UserInRoles { get; set; }
        int SaveChanges(bool AcceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool AcceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
