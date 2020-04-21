using System.Collections.Generic;
using System.Linq;
using MVVMExample.Models;

namespace MVVMExample.Data.Queries
{
    public class GetPeople
    {
        private readonly InMemoryData _inMemoryData;

        public GetPeople(InMemoryData inMemoryData)
        {
            _inMemoryData = inMemoryData;
        }

        public IEnumerable<Person> Execute()
        {
            return _inMemoryData.People.ToList();
        }
    }
}
