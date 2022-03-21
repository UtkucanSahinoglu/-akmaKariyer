public interface IAddressService
{
    Task <Address> AddAddress(Address address);
    Task <Address> UpdateAddress(int Id,Address address);
    Task <Address> GetByAddressId(int Id);
    Task <IEnumerable<Address>> GetByAddressName(string Name);
    Task <IEnumerable<City>> GetByCityName(string Name);
    Task <IEnumerable<District>> GetByDistrictName(string Name);
    Task <City> GetByCityId(int Id);
    Task <City> UpdateCity(int Id,City city);
    Task <District> GetByDistrictId(int Id);
    Task <District> UpdateDistrict(int Id,District district);
    Task <IEnumerable<Address>> GetAllAddress();
    Task <IEnumerable<City>> GetAllCity();
    Task <IEnumerable<District>> GetAllDistrict();
    Task <Address> DeleteAddress(int Id,Address address);
}