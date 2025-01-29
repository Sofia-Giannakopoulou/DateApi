using DateApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DateApi.Controllers;

[ServiceFilter(typeof(LogUserActivity))]
[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
}
