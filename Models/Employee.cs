using System.ComponentModel.DataAnnotations;

namespace Warehouse.Models
{
    public class Employee : BaseModel
    {
      

        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20, ErrorMessage="Ime nesmije imati vise od 20 znakova")]
        public string FirstName { get; set;}

        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20, ErrorMessage="Ime nesmije imati vise od 20 znakova")]
        public string LastName { get; set;} 
        
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int WarehouseId { get; set;}
        public Warehouse Warehouse { get; set;}
    }
}