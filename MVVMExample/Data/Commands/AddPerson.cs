using MVVMExample.Models;

namespace MVVMExample.Data.Commands
{
    public class AddPerson
    {
        private readonly InMemoryData _inMemoryData;

        public AddPerson(InMemoryData inMemoryData)
        {
            _inMemoryData = inMemoryData;
        }

        public void Execute(Person person)
        {
            person.Id = _inMemoryData.People.Count + 1;

            _inMemoryData.People.Add(person);
        }
    }
}
