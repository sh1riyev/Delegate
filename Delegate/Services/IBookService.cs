using System;
using Delegate.Models;

namespace Delegate.Services
{
	public interface IBookService
	{
		public List<Book> GetBooksByAuthor(Predicate<Book> author);
	}
}

