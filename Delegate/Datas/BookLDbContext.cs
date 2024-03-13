using System;
using Delegate.Models;

namespace Delegate.Datas
{
	public class BookLDbContext
	{
		public static List<Book> books;
		static BookLDbContext()
		{
			books = new List<Book>()
			{
				new Book
				{
					Author="Nizami"
				},
				new Book
				{
					Author="Ourel"
				},
				new Book
				{
					Author="Dostoyevski"
				},
				new Book
				{
					Author="Nizami"
				}
			};
		}
	}
}

