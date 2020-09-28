using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Contexts;
using DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class AdvertisementRepository : IAdvertisementRepository
    {
        private AdvertisementContext _context;
        public AdvertisementRepository(AdvertisementContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Advertisement advertisement)
        {
            await _context.Advertisements.AddAsync(advertisement);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Advertisement>> GetAllAsync()
        {
            return await _context.Advertisements.ToListAsync();
        }

        public async Task<Advertisement> GetByIdAsync(int id)
        {
            return await _context.Advertisements.FirstOrDefaultAsync(x=>x.Id==id);  
        }
    }
}