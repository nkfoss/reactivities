using Domain;
using GraphQL.Types;

namespace API.GraphQL.Types
{

    public class ActivityType : ObjectGraphType<Activity>  // Denotes that we are exposing metadata of the Activity type.
    {
        public ActivityType()
        {
            Field(t => t.Id);   // From our generic type, GraphQL can infer that t.Id is of type Guid.
            Field(t => t.Title);  // Same for all the rest...
            Field(t => t.Date);
            Field(t => t.Description);
            Field(t => t.Category);
            Field(t => t.City);
            Field(t => t.Venue);
        }
    }
}