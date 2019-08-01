using System.ComponentModel.DataAnnotations;

namespace Warehouse.Models
{
    public class City : BaseModel
    {
        

        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20, ErrorMessage="Ime nesmije imati vise od 20 znakova")]
        public string Name { get; set;}

        
        public string Zip { get; set;}
    }
}