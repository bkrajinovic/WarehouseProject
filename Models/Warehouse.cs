

using System.ComponentModel.DataAnnotations;

namespace Warehouse.Models
{
    public class Warehouse : BaseModel
    {
        
        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20, ErrorMessage="Ime nesmije imati vise od 20 znakova")]
        public string Name { get; set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20, ErrorMessage="Ime nesmije imati vise od 20 znakova")]
        public string Street { get; set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int CityId { get; set;}
        public City City { get; set;}
    }
}