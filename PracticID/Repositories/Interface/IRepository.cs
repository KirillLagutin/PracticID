using PracticID.Models;

namespace PracticID.Repositories.Interface
{
	public interface IRepository
	{
		List<Person> GetPersons();

		void AddPerson(Person person);
		void DeletePerson(int id);
		void SavePerson();
	}
}
