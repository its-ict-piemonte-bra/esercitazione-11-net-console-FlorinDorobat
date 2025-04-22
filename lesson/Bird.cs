using System.Runtime.Serialization;

namespace lesson
{
    /// <summary>
    /// Represents a doggo in the system.
    /// </summary>
    public class Bird : Animal
    {
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        private string name;
        private string breed;

        private int age;

        public Bird(string name, string breed, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(breed))
            {
                throw new ArgumentException("Breed cannot be null or empty.", nameof(breed));
            }
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
            }

            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        public void MakeSound()
        {
            Console.WriteLine("lanciati sotto il treno");
        }

    }
}