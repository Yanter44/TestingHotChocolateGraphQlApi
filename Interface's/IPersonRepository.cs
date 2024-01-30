using TestApiForPostgreAndGraphQL.Entityes;
using TestApiForPostgreAndGraphQL.Types;

namespace TestApiForPostgreAndGraphQL.Interface_s
{
    public interface IPersonRepository
    {
     public List<Person>? GetAllPersons();
     public Task<Person> AddPerson(string FirstName, string LastName, string Description); // бля боже чел иди нахуй и не угарай с этой сигнатуры
     
    }
}
