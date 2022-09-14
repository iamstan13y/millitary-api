namespace Millitary.API.Services
{
    public interface ICodeGeneratorService
    {
        Task<string> GenerateVerificationCode();
    }
}