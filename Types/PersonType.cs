using GraphQL.Types;
using TestApiForPostgreAndGraphQL.Entityes;

namespace TestApiForPostgreAndGraphQL.Types
{
    public class PersonType : ObjectType<Person>
    {
        protected override void Configure(IObjectTypeDescriptor<Person> descriptor)
        {
            descriptor.Field(x => x.Id);
            descriptor.Field(x => x.FirstName);
            descriptor.Field(x => x.LastName);
            descriptor.Field(x => x.Description);
        }
    }
}
