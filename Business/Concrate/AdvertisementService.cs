using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess;
using DataAccess.Contexts;
using DataAccess.Repositories;

namespace Business.Concrate
{
    public class AdvertisementService:AdvertisementRepository,IAdvertisementService
    {
        public AdvertisementService(AdvertisementContext context):base(context)
        {
            
        }

        public async Task AddAdvertisementAsync(Advertisement advertisement)
        {
            await AddAsync(advertisement);
        }

        public async Task<List<Advertisement>> GetAdvertisemetsAsync()
        {
            return await GetAllAsync();
        }
    }
}