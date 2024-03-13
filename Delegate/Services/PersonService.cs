using System.Linq;
using Delegate.Datas;
using Delegate.Models;

namespace Delegate.Services
{
	public class PersonService :IPersonService
	{
        public List<Person> GetPeopleBySallary(Predicate<Person> sallary)
        {
            return PersonDbContext.persons.FindAll(sallary);
        }
    }
}

