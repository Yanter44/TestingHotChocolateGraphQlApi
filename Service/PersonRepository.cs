using Microsoft.EntityFrameworkCore;
using TestApiForPostgreAndGraphQL.Entityes;
using TestApiForPostgreAndGraphQL.Interface_s;

namespace TestApiForPostgreAndGraphQL.Service
{
    public class PersonRepository(ApplicationDb context) : IPersonRepository
    {
        public ApplicationDb _context = context;


        public List<Person>? GetAllPersons()
        {
            return _context.Persons?.ToList();
        }

        public async Task<Person> AddPerson(string firstname,string lastname, string description) //я знаю что тут пока калл, но мне похуй, потом исправлю
        {
            var existPerson = await _context.Persons.FirstOrDefaultAsync(x => x.FirstName == firstname &&
                                                                        x.LastName == lastname &&
                                                                        x.Description == description);
            if(existPerson != null)
            {
                return null;
            }
            var personAdd = new Person
            {
               
                FirstName = firstname,
                LastName = lastname,
                Description = description
            };
            var newpersona = _context.Persons.Add(personAdd);
            await _context.SaveChangesAsync();
            return newpersona.Entity;
            
        }
    }
}
