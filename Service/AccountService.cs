public class AccountService : IAccountService
{
    private readonly IAccountRepository _AccountRepository;
    public AccountService(IAccountRepository _AccountRepository)
    {
        this._AccountRepository = _AccountRepository;
    }
    public async Task<Account> AddAccount(Account account)
    {
        return await _AccountRepository.AddAccount(account);
    }

    public async Task<IEnumerable<Account>> GetAllAccount()
    {
        return await _AccountRepository.GetAllAccount();
    }

    public async Task<IEnumerable<Account>> GetByAccountEmail(string Email)
    {
        return await _AccountRepository.GetByAccountEmail(Email);
    }

    public async Task<Account> GetByAccountId(int Id)
    {
        return await _AccountRepository.GetByAccountId(Id);
    }

    public async Task SetAccountIsBlocked(bool IsBlocked)
    {
        //todo
        await _AccountRepository.SetAccountIsBlocked(IsBlocked);
    }

    public async Task SetAccountVisibility(bool Visibility)
    {
        //todo
        if(Visibility == true)
        {
            await _AccountRepository.SetAccountVisibility(Visibility);
        }
        else
        {
            throw new Exception();
        }
    }

    public async Task<Account> UpdateAccount(int Id,Account account)
    {
        var UpdateAccount = _AccountRepository.GetByAccountId(Id);
        await _AccountRepository.UpdateAccount(account);
        return account;
        
    }
}