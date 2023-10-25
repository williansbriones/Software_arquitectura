using Newtonsoft.Json;
using ServicioUsuario.Models;
using System.Data;

namespace ServicioUsuario.Servicio
{
    public interface icurdUsuario
    {

        public Usuario Getinformacion(String rut);



        public List<Usuario> GetUsuarios();


        public string Login(string correo, string rut);
       




    }
}
