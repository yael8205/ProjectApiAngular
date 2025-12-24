using lotteryApi.Dtos;
using lotteryApi.Models;
using lotteryApi.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;


namespace lotteryApi.Services
{
    public class DonorService
    {
        private readonly DonorRepository _donorRepository = new();

        public async Task<IEnumerable<DonorDto>> GetDonorsAsync()
        {
            var donors=await _donorRepository.GetDonorsAsync();
            return  donors.Select(d => new DonorDto
            {
                Tz = d.Tz,
                Name = d.Name,
                Phone = d.Phone,
                Email = d.Email,
            }).ToList();

        }
        public async Task<UpdateDonorDto?> GetByIdAsync(int id)
        {
            var donor = await _donorRepository.GetByIdAsync(id);
            return donor != null ? new UpdateDonorDto { Id = id, Name = donor.Name, Phone = donor.Phone, Tz = donor.Tz, Email = donor.Email } : null;
        }
        public async Task<DonorDto> CreateDonorsAsync(DonorDto donor)
        {
            var newDonor = new DonorModel
            {
                Tz = donor.Tz,
                Name = donor.Name,
                Phone = donor.Phone,
                Email = donor.Email,
            };
            var createDonor= await _donorRepository.CreateDonorsAsync(newDonor);     
            return new DonorDto { Tz=newDonor.Tz,Name=newDonor.Name,Email = newDonor.Email,Phone=newDonor.Phone};
                 
        }
        public async Task<DonorDto?> UpdateDonorsAsync(int id, UpdateDonorDto donor)
        {

            var existingDonor = await _donorRepository.GetByIdAsync(id);
            if (existingDonor == null) return null;
            if(donor.Tz!=null)existingDonor.Tz = donor.Tz;
            if(donor.Name!=null)existingDonor.Name = donor.Name;
            if(donor.Phone!=null)existingDonor.Name=donor.Phone;
            if(donor.Email!=null)existingDonor.Email = donor.Email;
         
            var updatedDonor = await _donorRepository.UpdateDonorsAsync(existingDonor);
            return updatedDonor != null ? new DonorDto { Email=updatedDonor.Email,Tz=updatedDonor.Tz,Name=updatedDonor.Name,Phone=updatedDonor.Phone} : null;
        }

       
    }

}