namespace EjercicioHerencia
{
    public class HijaA : Padre
    {
        public string otraCadena {  get; set; }
        
        public HijaA()
        {
            otraCadena = string.Empty; //""
            DatoProtegido = "Dato Protegido";
        }
    }
}
