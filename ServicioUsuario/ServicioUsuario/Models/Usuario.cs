namespace ServicioUsuario.Models
{
    public abstract class Usuario
    {
        private int id;
        private string rut;
        private string nombre;
        private string apellido;
        private string correo;

        public int Id { get { return id; } set { this.id = value; } }
        public string Rut { get {  return rut; } set { this.rut = value; }  }
        public string Nombre { get { return nombre; } set { this.nombre = value; } }
        public string Correo { get {  return correo; } set { this.correo = value; } }
        public string Apellido { get {  return apellido; } set { this.apellido = value; } }
    }
}
