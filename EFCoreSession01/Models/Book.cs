using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession01.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int Year { get; set; }
        public bool IsInStock { get; set; }
        // Relationships with Author & Category
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null;
    }
}
