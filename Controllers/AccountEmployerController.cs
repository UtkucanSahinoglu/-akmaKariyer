using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AccountEmployerDetailController : ControllerBase
{
    private readonly IAccountEmployerDetailService _AccountEmployerDetailService;
    public AccountEmployerDetailController(IAccountEmployerDetailService _AccountEmployerDetailService)
    {
        this._AccountEmployerDetailService = _AccountEmployerDetailService;
    }
    [HttpPost]
    public async Task <AccountEmployerDetail> AddAccountEmployerDetail(AccountEmployerDetail accountEmployerDetail)
    {
        return await _AccountEmployerDetailService.AddAccountEmployerDetail(accountEmployerDetail);
    }
    [HttpPut]
    public async Task <AccountEmployerDetail> UpdateAccountEmployerDetail(int Id,AccountEmployerDetail accountEmployerDetail)
    {
        return await _AccountEmployerDetailService.UpdateAccountEmployerDetail(Id,accountEmployerDetail);
    }
    [HttpGet]
    public async Task <IEnumerable<AccountEmployerDetail>> GetAllAccountEmployerDetail()
    {
        return await _AccountEmployerDetailService.GetAllAccountEmployerDetail();
    }
    [HttpGet]
    public async Task <IEnumerable<AccountEmployerDetail>> GetByAccountEmployerDetailNameAndLastName(string Name,string LastName)
    {
        return await _AccountEmployerDetailService.GetByAccountEmployerDetailNameAndLastName(Name,LastName);
    }
    [HttpGet]
    public async Task <IEnumerable<AccountEmployerDetail>> GetByAccountEmployerCompanyName(string CompanyName)
    {
        return await _AccountEmployerDetailService.GetByAccountEmployerCompanyName(CompanyName);
    }
} 