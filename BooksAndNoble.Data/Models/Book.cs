using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndNoble.Data.Models
{
    internal class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Author { get; set; } = null!;

        [Required]
        public string Genre { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public string Price { get; set; } = null!;
    }
}
