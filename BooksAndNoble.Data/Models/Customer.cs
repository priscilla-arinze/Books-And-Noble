using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndNoble.Data.Models
{
    internal class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        public string? Phone { get; set; }

        // navigation property (one-to-many relationship)
        public ICollection<Order> Orders { get; set; } = null!;

    }
}
