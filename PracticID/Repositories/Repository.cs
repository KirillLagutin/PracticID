using PracticID.Repositories.Interface;
using PracticID.Models;
using PracticID.Data;

namespace PracticID.Repositories
{
	public class Repository : IRepository
	{
		private readonly DbPersonContext _context;

		public Repository(DbPersonContext context)
        {
            _context = context;
        }

        public void AddPerson(Person person)
		{
			_context.Person.Add(person);
			_context.SaveChanges();
		}

		public void DeletePerson(int id)
		{
			var person = _context.Person.Find(id);
			if (person != null)
			{
				_context.Person.Remove(person);
				_context.SaveChanges();
			}
		}

		public List<Person> GetPersons()
		{
			var person = from p in _context.Person select p;
			
			return _context.Person.ToList();
		}

		public void SavePerson()
        {
			using FileStream fs = new FileStream(@"D:\!Desktop\Step\C#\Projects\ASP\PracticID\PracticID\Test\/test.txt", FileMode.Create);

			using StreamWriter sw = new StreamWriter(fs);

			var people = GetPersons();
			foreach (var i in people)
            {
				sw.WriteLine(i.Name + " " + i.SurName + " " + i.BirthDay + " " + i.OtherInfo);
            }
        }
	}
}