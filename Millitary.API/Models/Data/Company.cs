namespace RudoRwedu.API.Models.Data
{
    public class Company
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public Account? Account { get; set; }
    }
}