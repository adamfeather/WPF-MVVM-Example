using System;

namespace MVVMExample.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public DateTime? Birthday { get; set; }

        public Cheese FavouriteCheese { get; set; }

        public bool IsValid =>
            !string.IsNullOrWhiteSpace(Forename) &&
            !string.IsNullOrWhiteSpace(Surname) &&
            Birthday != null &&
            FavouriteCheese != null;
    }
}
