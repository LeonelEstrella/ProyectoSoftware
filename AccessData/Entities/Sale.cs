using AccessData.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }
        public double TotalPay { get; set; }
        public double Subtotal {  get; set; }
        public double TotalDiscount { get; set; }
        public double Taxes { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<SaleProduct> SaleProduct { get; set; }
    }
}
