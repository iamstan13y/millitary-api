﻿using Millitary.API.Models.Local;
using Millitary.API.Models.Data;
using Millitary.API.Models.Local;

namespace Millitary.API.Models.Repository.IRepository
{
    public interface IAccountRepository
    {
        Task<Result<Account>> AddAsync(Account account);
        Task<Result<Account>> GetByIdAsync(int id);
        Task<Result<IEnumerable<Account>>> GetAllAsync();
        Task<Result<Account>> UpdateAsync(Account account);
        Task<Result<bool>> DeleteAsync(Account account);
        Task<Result<Account>> LoginAsync(LoginRequest login);
        Task<Result<Account>> ChangePasswordAsync(ChangePasswordRequest changePassword);
        Task<Result<string>> GetResetPasswordCodeAsync(string email);
        Task<Result<Account>> ResetPasswordAsync(ResetPasswordRequest resetPassword);
        Task<Result<Account>> ConfirmAccountAsync(ConfirmAccountRequest confirmAccount);
        Task<Result<string>> ResendOtpAsync(string email);
    }
}