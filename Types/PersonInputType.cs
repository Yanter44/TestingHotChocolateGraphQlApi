using Npgsql.Internal.Postgres;
using TestApiForPostgreAndGraphQL.Entityes;

namespace TestApiForPostgreAndGraphQL.Types
{
    public class PersonInputType : InputObjectType<Person>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Person> descriptor)
        {
            descriptor.Field(t => t.FirstName);
            descriptor.Field(t => t.LastName);
            descriptor.Field(t => t.Description);
        }
    }
}
