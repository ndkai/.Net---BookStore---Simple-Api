using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    public class BookRepo : IBookRepo
    {
        public List<Book> books = new List<Book>()
        {
            new Book{Id = 1,Author = "duy", CallNumber = "1", IsAvalable = true, Title = "Duy 1", PublicationYear = "1999"   },
            new Book{Id = 2,Author = "duy", CallNumber = "1", IsAvalable = true, Title = "Duy 1", PublicationYear = "1999"   },
            new Book{Id = 3,Author = "duy", CallNumber = "1", IsAvalable = true, Title = "Duy 1", PublicationYear = "1999"   },
            new Book{Id = 4,Author = "duy", CallNumber = "1", IsAvalable = true, Title = "Duy 1", PublicationYear = "1999"   },
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(book => book.Id == id);
        }
    }
}
