using System.ComponentModel.DataAnnotations;

namespace BooksAndNoble.Data.Models
{
    internal class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderPlaced { get; set; }

        [Required]
        public DateTime? OrderFulfilled { get; set; }

        // foreign key relationship to Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        // navigation property (one-to-many relationship)
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}