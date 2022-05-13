using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        [Required]
        public string? InventoryName { get; set; }//bu bazen yeni

        [Range(0, int.MaxValue,ErrorMessage = "Miktar daha büyük veya eşit olmalıdır {0}")]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Fiyat daha büyük veya eşit olmalıdır {0}")]
        public double Price { get; set; }

    }
}