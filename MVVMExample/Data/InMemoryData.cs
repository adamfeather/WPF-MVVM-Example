using MVVMExample.Models;
using System;
using System.Collections.Generic;

namespace MVVMExample.Data
{
    public class InMemoryData
    {
        public IList<Person> People { get; private set; }

        public IList<Cheese> Cheeses { get; private set; }

        public InMemoryData()
        {
            InitializePeople();

            InitializeCheeses();
        }

        private void InitializeCheeses()
        {
            Cheeses = new List<Cheese>
            {
                new Cheese {Id = 1, Name = "Cheddar", Sharpness = 5},
                new Cheese {Id = 2, Name = "Manchego", Sharpness = 2},
                new Cheese {Id = 3, Name = "Brie", Sharpness = 1}
            };
        }

        private void InitializePeople()
        {
            People = new List<Person>()
            {
                new Person
                {
                    Id = 1,
                    Forename = "Alice",
                    Surname = "Example",
                    Birthday = new DateTime(1990, 01, 01),
                    FavouriteCheese = new Cheese {Id = 1, Name = "Cheddar", Sharpness = 5}
                },
                new Person
                {
                    Id = 2,
                    Forename = "Bob",
                    Surname = "Example",
                    Birthday = new DateTime(1980, 01, 01),
                    FavouriteCheese = new Cheese {Id = 2, Name = "Manchego", Sharpness = 5}
                },
                new Person
                {
                    Id = 3,
                    Forename = "Chuck",
                    Surname = "Example",
                    Birthday = new DateTime(1970, 01, 01),
                    FavouriteCheese = new Cheese {Id = 3, Name = "Brie", Sharpness = 5}
                }
            };
        }
    }
}
