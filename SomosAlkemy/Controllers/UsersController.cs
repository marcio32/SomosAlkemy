using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomosAlkemy.DTOs;
using SomosAlkemy.Services;

namespace SomosAlkemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _unitOfWork.UserRepository.GetAll();

            return Ok(users);
        }

    }
}
