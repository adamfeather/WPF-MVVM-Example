using System.Collections.Generic;
using System.Linq;
using MVVMExample.Models;

namespace MVVMExample.Data.Queries
{
    public class GetCheeses
    {
        private readonly InMemoryData _inMemoryData;

        public GetCheeses(InMemoryData inMemoryData)
        {
            _inMemoryData = inMemoryData;
        }

        public IEnumerable<Cheese> Execute()
        {
            return _inMemoryData.Cheeses.ToList();
        }
    }
}
