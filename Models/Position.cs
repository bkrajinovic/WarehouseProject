using System.ComponentModel.DataAnnotations;

namespace Warehouse.Models
{
    public class Position : BaseModel
    {
        
        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20, ErrorMessage="Ime nesmije imati vise od 20 znakova")]
        public string Name { get; set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int GoodsId { get; set;}
        public Goods Goods { get; set;}
        public string Shelf { get; set;}
        public string PositionOnShelf { get; set;}
    }
}