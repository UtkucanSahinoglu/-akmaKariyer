using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class AccountController : ControllerBase
{
    private readonly IAccountService _AccountService;
    public AccountController(IAccountService _AccountService)
    {
        this._AccountService = _AccountService;
    }

    [HttpPost]
    public async Task<Account> AddAccount(Account account)
    {
       return await _AccountService.AddAccount(account);
    } 
    [HttpPut]
    public async Task<Account> UpdateAccount(int Id,Account account)
    {
        return await _AccountService.UpdateAccount(Id,account);
    }
    [HttpGet]
    public async Task<IEnumerable<Account>> GetAllAccount()
    {
        return await _AccountService.GetAllAccount();
    }
    [HttpGet("getbyemail")]
    public async Task<IEnumerable<Account>> GetByAccountEmail(string Email)
    {
        return await _AccountService.GetByAccountEmail(Email);
    }
    [HttpPut]
    public async Task SetAccountVisibility(bool Visibility)
    {
        await _AccountService.SetAccountVisibility(Visibility);
    }
    [HttpPut]
    public async Task SetAccountIsBlocked(bool IsBlocked)
    {
        await _AccountService.SetAccountIsBlocked(IsBlocked);
    }

}