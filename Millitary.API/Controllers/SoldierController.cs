using Microsoft.AspNetCore.Mvc;
using Millitary.API.Models.Data;
using Millitary.API.Models.Local;
using Millitary.API.Models.Repository.IRepository;

namespace RudoRwedu.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SoldierController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SoldierController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _unitOfWork.Company.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _unitOfWork.Company.FindAsync(id);
            if (!result.Success) return NotFound(result);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSoldierRequest request)
        {
            var result = await _unitOfWork.Company.UpdateAsync(new Soldier
            {
                Id = request.Id,
                AccountId = request.AccountId,
                FirstName = request.FirstName,
                LastName = request.LastName,
                ForceId = request.ForceId,
                NationalId = request.NationalId
            });

            _unitOfWork.SaveChanges();

            return Ok(result);
        }
    }
}