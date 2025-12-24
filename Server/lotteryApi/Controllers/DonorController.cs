using lotteryApi.Dtos;
using lotteryApi.Models;
using lotteryApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lotteryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase
    {
        private readonly DonorService _donorService = new();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonorDto>>> GetDonorsAsync()
        {
            var donors = await _donorService.GetDonorsAsync();
            return Ok(donors);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UpdateDonorDto>> GetByIdAsync(int id)
        {
            var donor = await _donorService.GetByIdAsync(id);

            if (donor == null)
            {
                return NotFound(new { message = $"donor with ID {id} not found 😒" });
            }

            return Ok(donor);
        }
        [HttpPost]
        public async Task<ActionResult<DonorDto>> CreateDonorsAsync([FromBody]DonorDto donor)
        {
             await _donorService.CreateDonorsAsync(donor);
            return Ok(donor);
        }
    }
}
