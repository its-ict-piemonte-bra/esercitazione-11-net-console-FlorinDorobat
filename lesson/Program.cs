using System.Runtime.InteropServices;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {

            Console.WriteLine("Gestione classi");

            Student s = new Student("Mario");
            Student s2 = new Student("Luigi");

            Teacher t = new Teacher("Alessandro Sanino");

            ClassMember[] members = new ClassMember[] { s, s2, t };

            Class classe = new Class("ITS-DotNet", members);

            foreach (ClassMember member in members)
            {
                Console.WriteLine($"{member.Name}");
            }
        }
    }
}
