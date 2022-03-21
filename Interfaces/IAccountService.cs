public interface IAccountService
{
    Task <Account> AddAccount(Account account);
    Task <Account> UpdateAccount(int Id,Account account);
    Task SetAccountVisibility(bool Visibility);
    Task SetAccountIsBlocked(bool IsBlocked);
    Task <Account> GetByAccountId(int Id);
    Task <IEnumerable<Account>> GetByAccountEmail(string Email);
    Task <IEnumerable<Account>> GetAllAccount();
}