using PracticID.Repositories.Interface;
using PracticID.Models;
using PracticID.Data;

namespace PracticID.Repositories
{
	public class Repository : IRepository
	{
		private readonly DbPersonContext _context;

		public void AddPerson(Person person)
		{
			_context.Person.Add(person);
			_context.SaveChanges();
		}

		public void DeletePerson(Person person)
		{
			_context.Person.Remove(person);
			_context.SaveChanges();
		}

		public List<Person> GetPersons()
		{
			//TODO
			return _context.Person.ToList();
		}
	}
}
