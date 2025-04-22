using System.Runtime.Serialization;

namespace lesson
{
    /// <summary>
    /// Represents a doggo in the system.
    /// </summary>
    public class Class : ClassMember
    {
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public ClassMember[] Persone
        {
            get
            {
                return this.persone;
            }
        }


        private string name;
        private ClassMember[] persone;

        public Class(string name, ClassMember[] persone)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }
            if (persone == null || persone.Length == 0)
            {
                throw new ArgumentException("Name cannot be null");
            }

            this.name = name;
            this.persone = persone;
        }
    }
}