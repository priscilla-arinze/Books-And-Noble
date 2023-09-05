using System.ComponentModel.DataAnnotations;

namespace BooksAndNoble.Data.Models
{
    internal class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int BookId { get; set; }

        public int OrderId { get; set; }

        // foreign key relationship to Order and Book
        public Order? Order { get; set; }
        public Book? Book { get; set; }
    }
}