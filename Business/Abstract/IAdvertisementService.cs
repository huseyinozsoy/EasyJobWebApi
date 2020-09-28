using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Repositories.Abstract;

namespace Business.Abstract
{
    public interface IAdvertisementService:IAdvertisementRepository
    {
        Task<List<Advertisement>> GetAdvertisemetsAsync();
        Task AddAdvertisementAsync(Advertisement advertisement);
    }
}