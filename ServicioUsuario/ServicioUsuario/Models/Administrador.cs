namespace ServicioUsuario.Models
{
    public class Administrador:Usuario
    {
        public Administrador(bool estado, int id, string rut, string nombre, string apellido, string correo) {
            this.estado = estado;
            this.Id = id;
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
        }
        private bool estado;
        public bool Estado { get { return estado; } }

    }
}
