using System;
using Delegate.Models;

namespace Delegate.Services
{
	public interface IPersonService
	{
		List<Person> GetPeopleBySallary(Predicate<Person> sallary);
	}
}

