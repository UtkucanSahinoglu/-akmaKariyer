public class RoleRepository : IRoleRepository
{
    private readonly CakmaKariyerContext _CakmaKariyerContext;
    public RoleRepository(CakmaKariyerContext _CakmaKariyerContext)
    {
        this._CakmaKariyerContext = _CakmaKariyerContext;
    }
    public async Task<Role> AddRole(Role role)
    {
        await _CakmaKariyerContext.Set<Role>().AddAsync(role);
        await _CakmaKariyerContext.SaveChangesAsync();
        return role;
    }

    public async Task<IEnumerable<Role>> GetAllRole()
    {
        return await _CakmaKariyerContext.Set<Role>().ToListAsync();
    }

    public async Task<Role> GetByRoleId(int Id)
    {
        return await _CakmaKariyerContext.Set<Role>().Where(x =>x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Role>> GetByRoleType(string RoleType)
    {
        return await _CakmaKariyerContext.Set<Role>().Where(x =>x.RoleType == RoleType).ToListAsync();
    }

    public async Task SetRoleVisibiliy(bool Visibility)
    {
        //todo
        var SetRoleVisibiliy = _CakmaKariyerContext.Update(Visibility);
        await _CakmaKariyerContext.SaveChangesAsync();
    }

    public async Task<Role> UpdateRole(Role role)
    {
        var UpdateRole = _CakmaKariyerContext.Update(role);
        await _CakmaKariyerContext.SaveChangesAsync();
        return role;
    }
}