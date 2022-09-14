namespace Millitary.API.Models.Data
{
    public class Ammunition
    {
        public int Id { get; set; }
        public string? SerialNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}