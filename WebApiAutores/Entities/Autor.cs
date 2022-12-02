using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validations;

namespace WebApiAutores.Entities
{
    public class Autor 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 10, ErrorMessage = "El campo {0} no debe de tener mas {1} caracteres")]
        [PrimeraLetraMayuscula]
        public string Name { get; set; }
       
        public List<AutorLibro> AutoresLibros { get; set; }





    }
}
