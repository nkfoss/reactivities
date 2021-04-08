using API.GraphQL.Types;
using API.Repositories;
using GraphQL.Types;

namespace API.GraphQL
{
    public class ReactivitiesQuery : ObjectGraphType
    {
        public ReactivitiesQuery(ActivityRepository activityRepository)
        {
            // Denotes that this field must return a list of ActivityType objects.
            Field<ListGraphType<ActivityType>>(
                "activities",
                resolve: context => activityRepository.GetAll()
            );
        }
    }
}