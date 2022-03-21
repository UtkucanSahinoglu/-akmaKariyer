public interface IRoleRepository
{
    Task <Role> AddRole(Role role);
    Task <Role> UpdateRole(Role role);
    Task SetRoleVisibiliy(bool Visibility);
    Task <IEnumerable<Role>> GetByRoleType(string RoleType);
    Task <Role> GetByRoleId(int Id);
    Task <IEnumerable<Role>> GetAllRole();
}