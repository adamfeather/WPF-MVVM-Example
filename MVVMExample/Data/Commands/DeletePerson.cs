using MVVMExample.Models;

namespace MVVMExample.Data.Commands
{
    public class DeletePerson
    {
        private readonly InMemoryData _inMemoryData;

        public DeletePerson(InMemoryData inMemoryData)
        {
            _inMemoryData = inMemoryData;
        }

        public void Execute(Person person)
        {
            _inMemoryData.People.Remove(person);
        }
    }
}
