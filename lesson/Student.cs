using System.Runtime.Serialization;

namespace lesson
{
    /// <summary>
    /// Represents a doggo in the system.
    /// </summary>
    public class Student : ClassMember
    {
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        private string name;

        public Student(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            this.name = name;
        }
    }
}