namespace rudo_rwedu_api.Models.Local
{
    public class RoleRequest
    {
        public string? Name { get; set; }
    }

    public class UpdateRoleRequest : RoleRequest
    {
        public int Id { get; set; }
    }
}