using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IAdvertisementRepository
    {
        Task<List<Advertisement>> GetAllAsync();
        Task<Advertisement> GetByIdAsync(int id);
        Task AddAsync(Advertisement advertisement);
    }
}