using GraphQL.Types;
using TestApiForPostgreAndGraphQL.Entityes;
using TestApiForPostgreAndGraphQL.Interface_s;
using TestApiForPostgreAndGraphQL.Types;

namespace TestApiForPostgreAndGraphQL.Query
{
    public class PersonsQuery : ObjectType
    {
        private readonly IPersonRepository _personRepository;

        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Query");

            descriptor.Field("persons")
                .Type<ListType<PersonType>>()
                .Resolve(context =>
                {
                    var personRepository = context.Service<IPersonRepository>();
                    return personRepository.GetAllPersons();
                });
        }
    }
}
