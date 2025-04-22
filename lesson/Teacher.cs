using System.Runtime.Serialization;

namespace lesson
{
    /// <summary>
    /// Represents a doggo in the system.
    /// </summary>
    public class Teacher : ClassMember
    {
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
        }

        private string name;
        private string title;

        public Teacher(string name, string title)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            this.name = name;
            this.title = title;
        }
    }
}