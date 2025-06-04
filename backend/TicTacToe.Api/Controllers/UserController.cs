using Microsoft.AspNetCore.Mvc;
using TicTacToe.Application.Interfaces;
using TicTacToe.Domain.Entities;

namespace TicTacToe.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            var user = _service.Get(name);

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _service.GetAllUserNames();
            return Ok(users);
        }

        [HttpPost("{name}")]
        public IActionResult Create(string name)
        {
            User user;
            try
            {
                 user = _service.Create(name);

            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            return Ok(user);
        }


    }
}
