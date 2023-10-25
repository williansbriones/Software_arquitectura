using Newtonsoft.Json;
using ServicioUsuario.Models;
using System.Data;

namespace ServicioUsuario.Servicio.Implements
{
    public class ServicioUsuario : icurdUsuario
    {
        public Usuario Getinformacion(String rut)
        {
            List<Usuario> listausuarios =  GetUsuarios();

            List<Usuario> lista_Result = listausuarios.Where(listausuario => listausuario.Rut == rut).ToList();

            return listausuarios[0];
            
        }

        public List<Usuario> GetUsuarios()
        {

            string urlwindos = "C:\\Users\\willi\\OneDrive\\Escritorio\\arquitectura\\ServicioUsuario\\db\\usuarios.json";
            IList<Usuario> ListaUsuarios = new List<Usuario>();
            string path = File.ReadAllText(@"db/usuarios.json");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(path, typeof(DataTable));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool estado = (bool)dt.Rows[i]["estado"];
                int id = Convert.ToInt32(dt.Rows[i]["id"]);
                string rut = dt.Rows[i]["rut"].ToString();
                string nombre = dt.Rows[i]["nombre"].ToString();
                string apellido = dt.Rows[i]["apellido"].ToString();
                string correo = dt.Rows[i]["correo"].ToString();

                ListaUsuarios.Add(new Administrador(estado, id, rut, nombre, apellido, correo));
            };


            return (List<Usuario>)ListaUsuarios;
        }

        public string Login(string Correo, string Rut)
        {

            List<Usuario> listausuario = GetUsuarios();
            List<Usuario> lista_Result = listausuario.Where( listausuario => listausuario.Rut == Rut ).ToList();
            
            return lista_Result[0].Rut;
        }
    }
}
