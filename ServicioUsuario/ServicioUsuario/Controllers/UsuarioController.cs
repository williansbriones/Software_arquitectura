using Microsoft.AspNetCore.Mvc;
using ServicioUsuario.Models;
using ServicioUsuario.Servicio;
using ServicioUsuario.Servicio.Implements;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicioUsuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
         icurdUsuario servicio = new Servicio.Implements.ServicioUsuario();

        // GET: api/<ValuesController>
        [HttpGet("usuarios")]
        public ObjectResult Get()
        {
            try
            {
                List<Usuario> listausuarios = servicio.GetUsuarios();
                return Ok(listausuarios);

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("login")]
        public string login([FromHeader]string Usuriao, [FromHeader]string contrasena)
        {

            return servicio.Login(Usuriao, contrasena);
        }

        [HttpGet("informacion")]
        public Usuario informacion([FromHeader] string rut)
        {

            return servicio.Getinformacion(rut);
        }
    }
}
