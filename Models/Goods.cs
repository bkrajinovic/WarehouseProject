using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Models
{
    public class Goods  : BaseModel
    {
        
        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20, ErrorMessage="Ime nesmije imati vise od 20 znakova")]
        public string Name { get; set;}
        public DateTime? ExpirationDate { get; set;}
        public DateTime? DateOfManufacture { get; set;}
        public int MinimalAmount { get; set;}
        public int CurrentAmount { get; set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public string UnitOfMeasure { get; set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]
        [Column(TypeName = "decimal(10, 2)")]

        public decimal Price { get; set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]

        public int? WarehouseId { get; set;}
        public Warehouse Warehouse { get; set;}

        public int? PositionId { get; set;}
        public Position Position { get; set;}
    }
}