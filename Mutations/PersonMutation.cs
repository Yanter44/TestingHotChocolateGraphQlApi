using TestApiForPostgreAndGraphQL.Entityes;
using TestApiForPostgreAndGraphQL.Interface_s;
using TestApiForPostgreAndGraphQL.Types;

namespace TestApiForPostgreAndGraphQL.Mutations
{
    public class PersonMutation
    {
        private readonly IPersonRepository _personReposit;
        public PersonMutation(IPersonRepository personReposit)
        {
            _personReposit = personReposit;
        }
        [UseMutationConvention]
        public async  Task<Person> AddPerson(string firstName, string LastName,string Description) // тут тоже калл ебейший боже ХАХАХАХАХ СУКА КАК ЖЕ МНЕ ПОХУЙ я ебал ваши Инпуты
        {
            var newpersona = await _personReposit.AddPerson(firstName,LastName,Description);
            return newpersona;
        }
      
        
    }
}
