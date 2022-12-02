namespace WebApiAutores.Entities
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public int LibroId { get; set; }
        //propiedad navegacion que me permite conectar las tablas
        public Libro Libro { get; set; }
    }
}
