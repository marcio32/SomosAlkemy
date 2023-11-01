using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomosAlkemy.DTOs;

namespace SomosAlkemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok("Marcio;Rosario;Pepe");
        }

        [HttpPost]
        public ActionResult AgregarUsuario(UserLoginDTO userloginDTO)
        {
            return Ok(userloginDTO);
        }


        [HttpPut]
        public ActionResult EditarUsuario(UserLoginDTO userloginDTO)
        {
            return Ok(userloginDTO);
        }

        [HttpDelete]
        public ActionResult EliminarUsuario(int id)
        {
            return Ok("Eliminado");
        }



    }
}
