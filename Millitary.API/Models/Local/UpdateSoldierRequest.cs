namespace Millitary.API.Models.Local
{
    public class UpdateSoldierRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalId { get; set; }
        public string? ForceId { get; set; }
    }
}