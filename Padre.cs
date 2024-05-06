namespace EjercicioHerencia
{
    public class Padre
    {
        //Propiedad pública
        public int Id { get; set; }
        public string? Cadena { get; set; }
        public DateTime Fecha { get; set; }
        //Propiedad privada, no se hereda
        private string DatoPrivado { get; set; }
        //Propiedad protegida, se hereda pero se convierte en privada en la herencia
        protected string DatoProtegido { get; set; }

        //Constructor: Se ejecuta cada vez que se crea un objeto de esta clase
        public Padre()
        {
            Cadena = "";
            DatoPrivado = "Dato Privado";
        }
    }
}
