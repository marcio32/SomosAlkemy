using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomosAlkemy.DTOs;
using SomosAlkemy.Helpers;
using SomosAlkemy.Infrastructure;
using SomosAlkemy.Services;

namespace SomosAlkemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TokenJwtHelper _tokenJwtHelper;

        public AuthorizeController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _tokenJwtHelper = new TokenJwtHelper(configuration);
        }


        [HttpPost]
        public async Task<IActionResult> Login (UserLoginDTO userLoginDTO)
        {
            try
            {
                var userCredentials = await _unitOfWork.UserRepository.AuthenticateCredentials(userLoginDTO);
                if(userCredentials == null)
                {
                    return ResponseFactory.CreateErrorResponse(401, "No Se pudo autorizar");
                }
                var token = _tokenJwtHelper.GenerateToken(userCredentials);

                return ResponseFactory.CreateSuccessResponse(200, token);
            }
            catch (Exception ex) {
                return ResponseFactory.CreateErrorResponse(500, "Contacte a sistemas");
            }
        }
    }
}
