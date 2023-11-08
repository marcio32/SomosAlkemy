using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomosAlkemy.DTOs;
using SomosAlkemy.Infrastructure;
using SomosAlkemy.Services;

namespace SomosAlkemy.Controllers
{
    [Authorize(Policy = "Administradores")]
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
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return ResponseFactory.CreateSuccessResponse(200, await _unitOfWork.UserRepository.GetAll());
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            var result = await _unitOfWork.UserRepository.InsertUser(userRegisterDTO);
            if (result)
            {
             
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(201, "El usuario se registro correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");
          
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(int id, UserRegisterDTO userRegisterDTO)
        {
            var result = await _unitOfWork.UserRepository.UpdateUser(userRegisterDTO, id);
            if (result)
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "El usuario se actualizo correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");

        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.UserRepository.DeleteUser(id);
            if (result)
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "El usuario se Elimino correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");

        }

    }
}
