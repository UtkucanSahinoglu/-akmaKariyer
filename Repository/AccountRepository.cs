public class AccountRepository : IAccountRepository
{
    private readonly CakmaKariyerContext _CakmaKariyerContext;
    public AccountRepository(CakmaKariyerContext _CakmaKariyerContext)
    {
        this._CakmaKariyerContext = _CakmaKariyerContext;
    }
    public async Task<Account> AddAccount(Account account)
    {
        await _CakmaKariyerContext.Set<Account>().AddAsync(account);
        await _CakmaKariyerContext.SaveChangesAsync();
        return account;
    }
    public async Task SetAccountIsBlocked(bool IsBlocked)
    {
        //todo
        await _CakmaKariyerContext.Update(IsBlocked).ReloadAsync();
        await _CakmaKariyerContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Account>> GetByAccountEmail(string Email)
    {
        return await _CakmaKariyerContext.Set<Account>().Where(x => x.Email == Email).ToListAsync();
    }

    public async Task<Account> GetByAccountId(int Id)
    {
        return await _CakmaKariyerContext.Set<Account>().Where(e =>e.Id == Id).FirstOrDefaultAsync();
    }

    public async Task SetAccountVisibility(bool Visibility)
    {
        //todo
        await _CakmaKariyerContext.Update(Visibility).ReloadAsync();
        await _CakmaKariyerContext.SaveChangesAsync();

    }

    public async Task<Account> UpdateAccount(Account account)
    {
        var UpdateAccount = _CakmaKariyerContext.Update(account);
        await _CakmaKariyerContext.SaveChangesAsync();
        return account;
    }

    public async Task<IEnumerable<Account>> GetAllAccount()
    {
        return await _CakmaKariyerContext.Set<Account>().ToListAsync();
    }


}