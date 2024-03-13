using System;
using Delegate.Models;

namespace Delegate.Datas
{
	public  class PersonDbContext
	{
		public static  List<Person> persons;
		static PersonDbContext()
		{
			persons = new List<Person>()
			{
				new Person
				{
					Name="Ilqar",
					Surname="Shiriyev",
					Adress="Bayil",
					Sallary=1200,
				},
				new Person
				{
					Name="Chingiz",
					Surname="Cafarov",
					Adress="Baksover",
					Sallary=1500
				},
				new Person
				{
					Name="Nurush",
					Surname="Alizade",
					Adress="Baki",
					Sallary=800
				}
			};
			
		}
	}
}

