using System;

namespace JournalDeClasse.Domain
{
    public class School
    {
        private School()
        { }

        public static School Create(string name, 
            string street, 
            string city, 
            string codePostal, 
            string country) => new School
        {
            Id = Guid.NewGuid(),
            Name = name,
            Street = street,
            City = city,
            CodePostal = codePostal,
            Country = country
        };

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Street { get; private set; }

        public string City { get; private set; }

        public string CodePostal { get; private set; }

        public string Country { get; private set; }
    }
}
