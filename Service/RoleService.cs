public class RoleService : IRoleService
{
    private readonly IRoleRepository _RoleRepository;
    public RoleService(IRoleRepository _RoleRepository)
    {
        this._RoleRepository = _RoleRepository;
    }
    public async Task<Role> AddRole(Role role)
    {
        return await _RoleRepository.AddRole(role);
    }

    public async Task<IEnumerable<Role>> GetAllRole()
    {
        return await _RoleRepository.GetAllRole();
    }

    public async Task<Role> GetByRoleId(int Id)
    {
        return await _RoleRepository.GetByRoleId(Id);
    }

    public async Task<IEnumerable<Role>> GetByRoleType(string RoleType)
    {
        return await _RoleRepository.GetByRoleType(RoleType);
    }

    public async Task SetRoleVisibility(bool Visibility)
    {
        //todo
        await _RoleRepository.SetRoleVisibiliy(Visibility);
    }

    public async Task<Role> UpdateRole(int Id,Role role)
    {
        //todo
        var UpdateRole = _RoleRepository.GetByRoleId(Id);
        await _RoleRepository.UpdateRole(role);
        return role;
    }
}