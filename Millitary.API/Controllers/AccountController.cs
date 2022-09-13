using Microsoft.AspNetCore.Mvc;
using RudoRwedu.API.Enums;
using RudoRwedu.API.Models.Data;
using RudoRwedu.API.Models.Local;
using RudoRwedu.API.Models.Repository.IRepository;

namespace RudoRwedu.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountRepository _accountRepository;

        public AccountController(IUnitOfWork unitOfWork, IAccountRepository accountRepository)
        {
            _unitOfWork = unitOfWork;
            _accountRepository = accountRepository;
        }

        [HttpPost("sign-up")]
        [ProducesResponseType(typeof(Result<Account>), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateAccount([FromBody] AccountRequest request)
        {
            var result = await _accountRepository.AddAsync(new Account
            {
                RoleId = request.RoleId,
                Email = request.Email,
                Password = request.Password,
                PhoneNumber = request.PhoneNumber,
                Status = AccountStatus.Unverified,
                DateCreated = DateTime.Now
            });

            if (!result.Success) return BadRequest(result);

            await _unitOfWork.Company.AddAsync(new Company
            {
                AccountId = result.Data!.Id,
                CategoryId = request.CategoryId,
                Location = request.Location,
                Name = request.CompanyName
            });

            return Ok(result);
        }

        [HttpGet("sign-up/resend-otp/{email}")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> ResendOtp(string email)
        {
            var result = await _accountRepository.ResendOtpAsync(email);
            if (!result.Success) return NotFound(result);

            return Ok(result);
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(Result<Account>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Result<Account>), StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _accountRepository.LoginAsync(request);

            if (!result.Success)
                return StatusCode(StatusCodes.Status403Forbidden, result);

            return Ok(result);
        }

        [HttpPost("confirm-account")]
        public async Task<IActionResult> ConfirmAccount(ConfirmAccountRequest request)
        {
            var result = await _accountRepository.ConfirmAccountAsync(request);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("change-password")]
        [ProducesResponseType(typeof(Result<Account>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Result<Account>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequest request)
        {
            var result = await _accountRepository.ChangePasswordAsync(request);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("reset-password/verification-code/{email}")]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(Result<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ResetPassword(string email)
        {
            var result = await _accountRepository.GetResetPasswordCodeAsync(email);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("reset-password")]
        [ProducesResponseType(typeof(Result<Account>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Result<Account>), StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
        {
            var result = await _accountRepository.ResetPasswordAsync(request);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }
    }
}