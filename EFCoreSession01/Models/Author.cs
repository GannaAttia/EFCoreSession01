using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession01.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string biography { get; set; }
        public DateTime DOB { get; set; }
        // 1 : M : Author has many books
        public List<Book> Books { get; set; } = new List<Book>();

    }
}
