using EFCoreSession01.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using var DBContext = new ApplicationDBContext();

            DBContext.Database.EnsureCreated();
            Console.WriteLine("Database created successfully");

            if (!DBContext.Books.Any())
            {
                var Category01 = new Category
                { 
                    Name = "Science Fiction",
                    Description = "Books that explore futuristic concepts and advanced technology.",
                    IsActive = true
                };
                var Author01 = new Author
                {
                    FirstName = "Ganna",
                    LastName = "Attia",
                    Email = "gannaattia48@gmail.com",
                    biography = "Ganna Attia is a science fiction author known for her imaginative storytelling and futuristic concepts.",
                    DOB = new DateTime(2005, 5, 15)
                };

                var Book01 = new Book
                {
                    Title = "The Time Traveler's Odyssey",
                    ISBN = "2023000001478236",
                    Price = 19.99m,
                    NumberOfPages = 255,
                    Year = 1951,
                    IsInStock = true,
                    Category = Category01,
                    Author = Author01
                };
                DBContext.Books.Add(Book01);
                DBContext.SaveChanges();
                Console.WriteLine("Data Added Successfully");
            }
            var storedBooks = DBContext.Books
                .Include(b => b.Author)
                .Include(b => b.Category).ToList();

            if (storedBooks != null)
            {
                Console.WriteLine("Stored Books:");
                foreach (var storedBook in storedBooks)
                    Console.WriteLine($"Title: {storedBook.Title}" +
                        $", Author: {storedBook.Author.FirstName} {storedBook.Author.LastName}," +
                        $" Category: {storedBook.Category.Name}");
            }

        }
    }
}
