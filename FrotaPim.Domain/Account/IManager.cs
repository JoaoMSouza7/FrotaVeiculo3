using System.Collections.Generic;
using System.Threading.Tasks;
using Aurochses.AspNetCore.Identity.EntityFrameworkCore;

namespace FrotaPim.Domain.Account
{
    public interface IManager
    {
        Task<bool> CreateAsync(string email, string password, string role);
        List<IUser> ListAll();
    }
}