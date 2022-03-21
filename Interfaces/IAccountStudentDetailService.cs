public interface IAccountStudentDetailService
{
    Task <AccountStudentDetail> AddAccountStudentDetail(AccountStudentDetail accountStudentDetail);
    Task <AccountStudentDetail> UpdateAccountStudentDetail(int Id,AccountStudentDetail accountStudentDetail);
    Task <AccountStudentDetail> GetByAccountStudentDetailId(int Id);
    Task <IEnumerable<AccountStudentDetail>> GetAllAccountStudentDetail();
    Task <IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailNameAndLastName(string Name,string LastName);
    Task <IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailEducationStatus(string EducationStatus);
    Task <IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailAbilities(string Abilities);
    Task <IEnumerable<AccountStudentDetail>> GetByAccountStudentDetailWorkExperince(string WorkExperince);
}