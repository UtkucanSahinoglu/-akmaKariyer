public interface IRoleService
{
    Task <Role> AddRole(Role role);
    Task <Role> UpdateRole(int Id,Role role);
    Task SetRoleVisibility(bool Visibility);
    Task <IEnumerable<Role>> GetByRoleType(string RoleType);
    Task <Role> GetByRoleId(int Id);
    Task <IEnumerable<Role>> GetAllRole();
}