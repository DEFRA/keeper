using Keeper.Core;
using Microsoft.AspNetCore.Mvc;

namespace Keeper.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController(ILogger<TestController> logger, ICoreFacade facade) : ControllerBase
{
    [HttpGet("{id}", Name = "TestGet")]
    public async Task<IActionResult> GetAsync(string id)
    {
        return Ok(await facade.FakeService.GetAsync(id));
    }
}
