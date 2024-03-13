using System;
using Delegate.Services;

namespace Delegate.Controllers
{
	public class PersonController
	{
		private readonly PersonService _personService;
		public PersonController()
		{
			_personService = new PersonService();
		}
		public void GetPeopleBySallary()
		{
			int sallary = 1000;
			var result=_personService.GetPeopleBySallary(m=>m.Sallary>sallary);

			foreach (var item in result)
			{
				Console.WriteLine(item.Name+ " " +item.Surname+ " " +item.Adress);
			}
		}
	}
}

