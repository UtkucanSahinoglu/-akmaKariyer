public class AccountEmployerDetailService : IAccountEmployerDetailService
{
    private readonly IAccountEmployerDetailRepository _AccountEmployerDetailRepository;
    public AccountEmployerDetailService(IAccountEmployerDetailRepository _AccountEmployerDetailRepository)
    {
        this._AccountEmployerDetailRepository = _AccountEmployerDetailRepository;
    }
    public async Task<AccountEmployerDetail> AddAccountEmployerDetail(AccountEmployerDetail accountEmployerDetail)
    {
        return await _AccountEmployerDetailRepository.AddAccountEmployerDetail(accountEmployerDetail);
    }

    public async Task<IEnumerable<AccountEmployerDetail>> GetAllAccountEmployerDetail()
    {
        return await _AccountEmployerDetailRepository.GetAllAccountEmployerDetail();
    }

    public async Task<IEnumerable<AccountEmployerDetail>> GetByAccountEmployerCompanyName(string CompanyName)
    {
        return await _AccountEmployerDetailRepository.GetByAccountEmployerCompanyName(CompanyName);
    }

    public async Task<AccountEmployerDetail> GetByAccountEmployerDetailId(int Id)
    {
        return await _AccountEmployerDetailRepository.GetByAccountEmployerDetailId(Id);
    }

    public async Task<IEnumerable<AccountEmployerDetail>> GetByAccountEmployerDetailNameAndLastName(string Name, string LastName)
    {
        return await _AccountEmployerDetailRepository.GetByAccountEmployerDetailNameAndLastName(Name,LastName);
    }

    public async Task<AccountEmployerDetail> UpdateAccountEmployerDetail(int Id,AccountEmployerDetail accountEmployerDetail)
    {
        var UpdateAccountEmployerDetail = _AccountEmployerDetailRepository.GetByAccountEmployerDetailId(Id);
        await _AccountEmployerDetailRepository.UpdateAccountEmployerDetail(accountEmployerDetail);
        return accountEmployerDetail;
    }
}