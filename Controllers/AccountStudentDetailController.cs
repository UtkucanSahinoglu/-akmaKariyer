using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class AccountStudentDetailController : ControllerBase
{
    private readonly IAccountStudentDetailService _AccountStudentDetailService;
    public AccountStudentDetailController(IAccountStudentDetailService _AccountStudentDetailController)
    {
        this._AccountStudentDetailService = _AccountStudentDetailService;
    }
    [HttpPost]
    public async Task <AccountStudentDetail> AccountStudentDetail(AccountStudentDetail accountStudentDetail)
    {
        return await _AccountStudentDetailService.AddAccountStudentDetail(accountStudentDetail);
    }
    [HttpPut]
    public async Task <AccountStudentDetail> UpdateAccountStudentDetail(int Id,AccountStudentDetail accountStudentDetail)
    {
        return await _AccountStudentDetailService.UpdateAccountStudentDetail(Id,accountStudentDetail);
    }
    [HttpGet]
    public async Task <IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailNameAndLastName(string Name,string LastName)
    {
        return await _AccountStudentDetailService.GetByAccountStudentDetailNameAndLastName(Name,LastName);
    }
    [HttpGet]
    public async Task <IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailEducationStatus(string EducationStatus)
    {
        return await _AccountStudentDetailService.GetByAccountStudentDetailEducationStatus(EducationStatus);
    }
    [HttpGet]
    public async Task <IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailAbilities(string Abilities)
    {
        return await _AccountStudentDetailService.GetByAccountStudentDetailAbilities(Abilities);
    }
    [HttpGet]
    public async Task <IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailWorkExperince(string WorkExperince)
    {
        return await _AccountStudentDetailService.GetByAccountStudentDetailWorkExperince(WorkExperince);
    }
}