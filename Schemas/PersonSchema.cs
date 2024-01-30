using TestApiForPostgreAndGraphQL.Query;
using HotChocolate.Types;
namespace TestApiForPostgreAndGraphQL.Schemas
{
    public class PersonSchema : Schema
    {
        public static ISchema CreateSchema()
        {
            return SchemaBuilder.New()
                .AddQueryType<PersonsQuery>()
                .Create();
        }


    }
}
