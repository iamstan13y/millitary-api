namespace RudoRwedu.API.Services
{
    public interface ICodeGeneratorService
    {
        Task<string> GenerateVerificationCode();
    }
}