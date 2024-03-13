using System;
using Delegate.Datas;
using Delegate.Models;

namespace Delegate.Services
{
	public class BookService :IBookService
	{
        public List<Book> GetBooksByAuthor(Predicate<Book> author)
        {
            return BookLDbContext.books.FindAll(author);
        }
    }
}

