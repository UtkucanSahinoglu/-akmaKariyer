public class AccountStudentDetailRepository : IAccountStudentDetailRepository
{
    private readonly CakmaKariyerContext _CakmaKariyerContext;
    public AccountStudentDetailRepository(CakmaKariyerContext _CakmaKariyerContext)
    {
        this._CakmaKariyerContext = _CakmaKariyerContext;
    }
    public async Task<AccountStudentDetail> AddAccountStudentDetail(AccountStudentDetail accountStudentDetail)
    {
        await _CakmaKariyerContext.Set<AccountStudentDetail>().AddAsync(accountStudentDetail);
        await _CakmaKariyerContext.SaveChangesAsync();
        return accountStudentDetail;
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetAllAccountStudentDetail()
    {
        return await _CakmaKariyerContext.Set<AccountStudentDetail>().ToListAsync();
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailAbilities(string Abilities)
    {
        return await _CakmaKariyerContext.Set<AccountStudentDetail>().Where(x =>x.Abilities == Abilities).ToListAsync();
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailEducationStatus(string EducationStatus)
    {
        return await _CakmaKariyerContext.Set<AccountStudentDetail>().Where(x =>x.EducationStatus == EducationStatus).ToListAsync();
    }

    public async Task<AccountStudentDetail> GetByAccountStudentDetailId(int Id)
    {
        return await _CakmaKariyerContext.Set<AccountStudentDetail>().Where(x =>x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailNameAndLastName(string Name, string LastName)
    {
        return await _CakmaKariyerContext.Set<AccountStudentDetail>().Where(x =>x.Name == Name && x.LastName == LastName).ToListAsync();
    }

    public async Task<IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailWorkExperince(string WorkExperince)
    {
        return await _CakmaKariyerContext.Set<AccountStudentDetail>().Where(x =>x.WorkExperince == WorkExperince).ToListAsync();
    }

    public async Task<AccountStudentDetail> UpdateAccountStudentDetail(AccountStudentDetail accountStudentDetail)
    {
        var UpdateAccountStudentDetail = _CakmaKariyerContext.Update(accountStudentDetail);
        await _CakmaKariyerContext.SaveChangesAsync();
        return accountStudentDetail;
    }
}