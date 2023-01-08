using Microsoft.AspNetCore.Mvc;

namespace Subdivision.Api.Controllers
{
    [ApiController]
    [Route("api/v[version]/[feature]/[controller]/[action]")]

    //
    public class ApiBaseController : ControllerBase
    {
    }
}
