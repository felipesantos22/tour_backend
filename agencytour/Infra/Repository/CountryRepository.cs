using agencytour.Domain.Entities;
using agencytour.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace agencytour.Infra.Repository;

public class CountryRepository : IBaseRepository<Country>
{
    
    private readonly DataContext _dataContext;

    public CountryRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }


    public async Task<Country> Insert(Country obj)
    {
        await _dataContext.Countries.AddAsync(obj);
        await _dataContext.SaveChangesAsync();
        return obj;
    }

    public async Task<List<Country?>> Select()
    {
        var countries = await _dataContext.Countries.ToListAsync();
        return countries;
    }

    public Task<Country> Select(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Country> Update(int id, Country obj)
    {
        throw new NotImplementedException();
    }

    public Task<Country> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Country> SelectName(string name)
    {
        throw new NotImplementedException();
    }
}