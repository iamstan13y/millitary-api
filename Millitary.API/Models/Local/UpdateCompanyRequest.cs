namespace RudoRwedu.API.Models.Local
{
    public class UpdateCompanyRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int CategoryId { get; set; }
    }
}