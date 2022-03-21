using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class RoleController : ControllerBase
{
    private readonly IRoleService _RoleService;
    public RoleController(IRoleService _RoleService)
    {
        this._RoleService = _RoleService;
    }
    [HttpPost]
    public async Task<Role> AddRole(Role role)
    {
        return await _RoleService.AddRole(role);
    }
    [HttpPut]
    public async Task<Role> UpdateRole(int Id,Role role)
    {
        return await _RoleService.UpdateRole(Id,role);
    }
    [HttpGet]
    public async Task<IEnumerable<Role>> GetAllRole()
    {
        return await _RoleService.GetAllRole();
    }
    [HttpPut]
    public async Task SetRoleVisibility(bool Visibility)
    {
        await _RoleService.SetRoleVisibility(Visibility);
    }
    
}