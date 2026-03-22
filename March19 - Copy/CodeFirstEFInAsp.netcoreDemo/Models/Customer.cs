using System.ComponentModel.DataAnnotations;

namespace CodeFirstEFInAsp.netcoreDemo.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public List<Product> Products { get; set; }

    }
}
