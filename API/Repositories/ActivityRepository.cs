using System.Collections.Generic;
using Domain;
using Persistence;

namespace API.Repositories
{
    public class ActivityRepository
    {
        private readonly DataContext _dataContext;

        public ActivityRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Activity> GetAll()
        {
            return _dataContext.Activities;
        }
    }
}