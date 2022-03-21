public interface IAccountEmployerDetailRepository
{
    Task <AccountEmployerDetail> AddAccountEmployerDetail(AccountEmployerDetail accountEmployerDetail);
    Task <AccountEmployerDetail> UpdateAccountEmployerDetail(AccountEmployerDetail accountEmployerDetail);
    Task <AccountEmployerDetail> GetByAccountEmployerDetailId(int Id);
    Task <IEnumerable<AccountEmployerDetail>> GetAllAccountEmployerDetail();
    Task <IEnumerable<AccountEmployerDetail>> GetByAccountEmployerDetailNameAndLastName(string Name,string LastName);
    Task <IEnumerable<AccountEmployerDetail>> GetByAccountEmployerCompanyName(string CompanyName);
}