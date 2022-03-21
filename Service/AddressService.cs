public class AddressService : IAddressService
{
    private readonly IAddressRepository _AddressRepository;
    public AddressService(IAddressRepository _AddressRepository)
    {
        this._AddressRepository = _AddressRepository;
    }
    public async Task<Address> AddAddress(Address address)
    {
        return await _AddressRepository.AddAddress(address);
    }

    public async Task<Address> DeleteAddress(int Id,Address address)
    {
        var DeleteAddress = _AddressRepository.GetByAddressId(Id);
        await _AddressRepository.DeleteAddress(address);
        return address;
    }

    public async Task<IEnumerable<Address>> GetAllAddress()
    {
        return await _AddressRepository.GetAllAddress();
    }

    public async Task<IEnumerable<City>> GetAllCity()
    {
        return await _AddressRepository.GetAllCity();
    }

    public async Task<IEnumerable<District>> GetAllDistrict()
    {
        return await _AddressRepository.GetAllDistrict();
    }

    public async Task<Address> GetByAddressId(int Id)
    {
        return await _AddressRepository.GetByAddressId(Id);
    }

    public async Task<IEnumerable<Address>> GetByAddressName(string Name)
    {
        return await _AddressRepository.GetByAddressName(Name);
    }

    public async Task<City> GetByCityId(int Id)
    {
        return await _AddressRepository.GetByCityId(Id);
    }

    public async Task<IEnumerable<City>> GetByCityName(string Name)
    {
        return await _AddressRepository.GetByCityName(Name);
    }

    public async Task<District> GetByDistrictId(int Id)
    {
        return await _AddressRepository.GetByDistrictId(Id);
    }

    public async Task<IEnumerable<District>> GetByDistrictName(string Name)
    {
        return await _AddressRepository.GetByDistrictName(Name);
    }

    public async Task<Address> UpdateAddress(int Id, Address address)
    {
        var UpdateAddress = _AddressRepository.GetByAddressId(Id);
        await _AddressRepository.UpdateAddress(address);
        return address;
    }

    public async Task<City> UpdateCity(int Id, City city)
    {
        var UpdateCity = _AddressRepository.GetByCityId(Id);
        await _AddressRepository.UpdateCity(city);
        return city;
    }

    public async Task<District> UpdateDistrict(int Id, District district)
    {
        var UpdateDistrict = _AddressRepository.GetByDistrictId(Id);
        await _AddressRepository.UpdateDistrict(district);
        return district;
    }
}