namespace Millitary.API.Models.Local
{
    public class CategoryRequest
    {
        public string? Name { get; set; }
    }

    public class UpdateCategoryRequest : CategoryRequest
    {
        public int Id { get; set; }
    }
}