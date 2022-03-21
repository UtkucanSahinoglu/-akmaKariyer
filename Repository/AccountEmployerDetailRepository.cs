public class AccountEmployerDetailRepository : IAccountEmployerDetailRepository
{
    private readonly CakmaKariyerContext _CakmaKariyerContext;
    public AccountEmployerDetailRepository(CakmaKariyerContext _CakmaKariyerContext)
    {
        this._CakmaKariyerContext = _CakmaKariyerContext;
    }
    public async Task<AccountEmployerDetail> AddAccountEmployerDetail(AccountEmployerDetail accountEmployerDetail)
    {
        await _CakmaKariyerContext.Set<AccountEmployerDetail>().AddAsync(accountEmployerDetail);
        await _CakmaKariyerContext.SaveChangesAsync();
        return accountEmployerDetail;
    }

    public async Task<IEnumerable<AccountEmployerDetail>> GetAllAccountEmployerDetail()
    {
        return await _CakmaKariyerContext.Set<AccountEmployerDetail>().ToListAsync();
    }

    public async Task<IEnumerable<AccountEmployerDetail>> GetByAccountEmployerCompanyName(string CompanyName)
    {
        return await _CakmaKariyerContext.Set<AccountEmployerDetail>().Where(x =>x.CompanyName == CompanyName).ToListAsync();
    }

    public async Task<AccountEmployerDetail> GetByAccountEmployerDetailId(int Id)
    {
        return await _CakmaKariyerContext.Set<AccountEmployerDetail>().Where(x =>x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<AccountEmployerDetail>> GetByAccountEmployerDetailName(string Name)
    {
        return await _CakmaKariyerContext.Set<AccountEmployerDetail>().Where(x =>x.Name == Name).ToListAsync();
    }

    public async Task<IEnumerable<AccountEmployerDetail>> GetByAccountEmployerDetailNameAndLastName(string Name, string LastName)
    {
        return await _CakmaKariyerContext.Set<AccountEmployerDetail>().Where(x =>x.Name == Name && x.LastName == LastName).ToListAsync();
    }

    public async Task<AccountEmployerDetail> UpdateAccountEmployerDetail(AccountEmployerDetail accountEmployerDetail)
    {
        var UpdateAccountEmployerDetail = _CakmaKariyerContext.Update(accountEmployerDetail);
        await _CakmaKariyerContext.SaveChangesAsync();
        return accountEmployerDetail;
    }
}