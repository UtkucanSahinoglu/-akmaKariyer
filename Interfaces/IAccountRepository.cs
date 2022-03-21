public interface IAccountRepository
{
    Task <Account> AddAccount(Account account);
    Task <Account> UpdateAccount(Account account);
    Task SetAccountVisibility(bool visibility);
    Task SetAccountIsBlocked(bool IsBlocked);
    Task <Account> GetByAccountId(int Id);
    Task <IEnumerable<Account>> GetByAccountEmail(string Email);
    Task <IEnumerable<Account>> GetAllAccount();
    
}