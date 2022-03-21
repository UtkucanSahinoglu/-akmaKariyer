public class AccountStudentDetailService : IAccountStudentDetailService
{
    private readonly IAccountStudentDetailRepository _AccountStudentDetailRepository;
    public AccountStudentDetailService(IAccountStudentDetailRepository _AccountStudentDetailRepository)
    {
        this._AccountStudentDetailRepository = _AccountStudentDetailRepository;
    }
    public async Task<AccountStudentDetail> AddAccountStudentDetail(AccountStudentDetail accountStudentDetail)
    {
        return await _AccountStudentDetailRepository.AddAccountStudentDetail(accountStudentDetail);
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetAllAccountStudentDetail()
    {
        return await _AccountStudentDetailRepository.GetAllAccountStudentDetail();
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailAbilities(string Abilities)
    {
        return await _AccountStudentDetailRepository.GetByAccountStudentDetailAbilities(Abilities);
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailEducationStatus(string EducationStatus)
    {
        return await _AccountStudentDetailRepository.GetByAccountStudentDetailEducationStatus(EducationStatus);
    }

    public async Task<AccountStudentDetail> GetByAccountStudentDetailId(int Id)
    {
        return await _AccountStudentDetailRepository.GetByAccountStudentDetailId(Id);
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailNameAndLastName(string Name, string LastName)
    {
        return await _AccountStudentDetailRepository.GetByAccountStudentDetailNameAndLastName(Name,LastName);
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailWorkExperince(string WorkExperince)
    {
        return await _AccountStudentDetailRepository.GetByAccountStudentDetailWorkExperince(WorkExperince);
    }

    public async Task<AccountStudentDetail> UpdateAccountStudentDetail(int Id,AccountStudentDetail accountStudentDetail)
    {
        var UpdateAccountStudentDetail = _AccountStudentDetailRepository.GetByAccountStudentDetailId(Id);
        await _AccountStudentDetailRepository.UpdateAccountStudentDetail(accountStudentDetail);
        return accountStudentDetail;
    }
}