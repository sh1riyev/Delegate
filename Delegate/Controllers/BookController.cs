using System;
using Delegate.Services;

namespace Delegate.Controllers
{
	public class BookController
	{
		private readonly BookService _bookService;
		public BookController()
		{
			_bookService = new BookService();
		}
		public void GetBooksByAuthor()
		{
			string author = "Nizami";
			Console.WriteLine(_bookService.GetBooksByAuthor(m => m.Author.Equals(author)).Count());
		}
	}
}

