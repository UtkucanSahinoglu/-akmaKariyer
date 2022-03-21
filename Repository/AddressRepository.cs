public class AddressRepository : IAddressRepository
{
    private readonly CakmaKariyerContext _CakmaKariyerContext;
    public AddressRepository(CakmaKariyerContext _CakmaKariyerContext)
    {
        this._CakmaKariyerContext = _CakmaKariyerContext;
    }
    public async Task<Address> AddAddress(Address address)
    {
        await _CakmaKariyerContext.Set<Address>().AddAsync(address);
        await _CakmaKariyerContext.SaveChangesAsync();
        return address;
    }

    public async Task<Address> DeleteAddress(Address address)
    {
        var DeleteAddress = _CakmaKariyerContext.Set<Address>().Remove(address);
        await _CakmaKariyerContext.SaveChangesAsync();
        return address;
    }

    public async Task<IEnumerable<Address>> GetAllAddress()
    {
        return await _CakmaKariyerContext.Set<Address>().ToListAsync();
    }

    public async Task<IEnumerable<City>> GetAllCity()
    {
        return await _CakmaKariyerContext.Set<City>().ToListAsync();
    }

    public async Task<IEnumerable<District>> GetAllDistrict()
    {
        return await _CakmaKariyerContext.Set<District>().ToListAsync();
    }

    public async Task<Address> GetByAddressId(int Id)
    {
        return await _CakmaKariyerContext.Set<Address>().Where(e =>e.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Address>> GetByAddressName(string Name)
    {
        return await _CakmaKariyerContext.Set<Address>().Where(e =>e.Name == Name).ToListAsync();
    }

    public async Task<City> GetByCityId(int Id)
    {
        return await _CakmaKariyerContext.Set<City>().Where(e =>e.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<City>> GetByCityName(string Name)
    {
        return await _CakmaKariyerContext.Set<City>().Where(e =>e.Name == Name).ToListAsync();
    }

    public async Task<District> GetByDistrictId(int Id)
    {
        return await _CakmaKariyerContext.Set<District>().Where(e =>e.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<District>> GetByDistrictName(string Name)
    {
        return await _CakmaKariyerContext.Set<District>().Where(e =>e.Name == Name).ToListAsync();
    }

    public async Task<Address> UpdateAddress(Address address)
    {
        var UpdateAddress = _CakmaKariyerContext.Update(address);
        await _CakmaKariyerContext.SaveChangesAsync();
        return address;
    }

    public async Task<City> UpdateCity(City city)
    {
        var UpdateCityName = _CakmaKariyerContext.Update(city);
        await _CakmaKariyerContext.SaveChangesAsync();
        return city;
    }

    public async Task<District> UpdateDistrict(District district)
    {
        var UpdateDistrictName = _CakmaKariyerContext.Update(district);
        await _CakmaKariyerContext.SaveChangesAsync();
        return district;
    }
}