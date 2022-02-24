using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MusicEvents.Security.API.Filters;
using MusicEvents.Services.Interfaces;
//using MusicEvents.Dto.Request;
//using MusicEvents.Dto.Response;
//using MusicEvents.Services.Interfaces;

namespace MusicEvents.Security.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[TypeFilter(typeof(MusicFilterErrors))]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

}
