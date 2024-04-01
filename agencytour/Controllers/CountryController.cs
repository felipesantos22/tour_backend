using agencytour.Domain.Entities;
using agencytour.Infra.Repository;
using Microsoft.AspNetCore.Mvc;

namespace agencytour.Controllers;

[Route("api/v1/country")]
[ApiController]
public class CountryController: ControllerBase
{
    private readonly IBaseRepository<Country> _baseRepository;

    public CountryController(IBaseRepository<Country> baseRepository)
    {
        _baseRepository = baseRepository;
    }

    [HttpPost]
    public async Task<ActionResult<Country>> Insert([FromBody] Country obj)
    {
        var country = await _baseRepository.Insert(obj);
        return Ok(country);
    }
    
    
    [HttpGet]
    public async Task<ActionResult<List<Country>>> Select()
    {
        var countries = await _baseRepository.Select();
        return Ok(countries);
    }
}