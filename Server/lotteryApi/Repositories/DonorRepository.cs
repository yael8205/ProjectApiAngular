using Home_Fashion.Data;
using lotteryApi.Data;
using lotteryApi.Dtos;
using lotteryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace lotteryApi.Repositories
{
    public class DonorRepository
    {
        private readonly LotteryDBContext _lotteryContext = LotteryDBtFactory.CreateContext();

        public async Task<IEnumerable<DonorModel?>> GetDonorsAsync()
        {
            return await _lotteryContext.Donors.ToListAsync();
        }

        public async Task<DonorModel?> GetByIdAsync(int id)
        {
            return await _lotteryContext.Donors
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<DonorModel> CreateDonorsAsync(DonorModel donor )
        {

            _lotteryContext.Donors.Add(donor);
            await _lotteryContext.SaveChangesAsync();
            return donor;
        }
        public async Task<DonorModel?> UpdateDonorsAsync(DonorModel donor)
        {
            var existing = await _lotteryContext.Donors.FindAsync(donor.Id);
            if (existing == null) return null;

            _lotteryContext.Entry(existing).CurrentValues.SetValues(donor);

            _lotteryContext.Donors.Update(donor);
            await _lotteryContext.SaveChangesAsync();
            return existing;
        }
    }
}
