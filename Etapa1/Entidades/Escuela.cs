namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoDeCreacion{ set; get; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TiposEscuela{get;set;}
        public Escuela(string nombre, int año) =>(Nombre, AñoDeCreacion)=(nombre, año);
        public Escuela(string Nombre, 
                        int año, 
                        TiposEscuela tipos,
                        string pais = "", 
                        string ciudad ="")
                        {
                            (Nombre, AñoDeCreacion) = (nombre, año);
                            Pais = pais;
                            Ciudad = ciudad;
                        }
        public override string ToString()
        {
            return $"Nombre:{Nombre}, \n Tipo:{TiposEscuela},  \n Pais:{Pais}, \n Ciudad:{Ciudad}";
        }
    }
}