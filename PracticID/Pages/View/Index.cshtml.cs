using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticID.Models;
using PracticID.Repositories.Interface;

namespace PracticID.Pages.View
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public IndexModel(IRepository repository)
		{
			_repository = repository;
		}

		public List<Person> person { get; set; }

        public void OnGet()
        {
            _repository.GetPersons();
        }
    }
}
