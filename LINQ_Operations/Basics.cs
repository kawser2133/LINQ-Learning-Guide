using LINQ_Learning_Guide.Models;

namespace LINQ_Learning_Guide.LINQ_Operations
{
    public class Basics
    {
        public void BasicOperations()
        {
            List<Student> students = new List<Student>();

            // ====================================
            // LEVEL 1: BASIC OPERATIONS
            // ====================================
            Console.WriteLine("LEVEL 1: Basic Operations");
            Console.WriteLine("-------------------------");

            // 1.1 Where - Filtering
            Console.WriteLine("1.1 Filter students older than 20:");
            var olderStudents = students.Where(s => s.Age > 20);
            foreach (var student in olderStudents)
                Console.WriteLine($"   {student.Name} (Age: {student.Age})");

            // 1.2 Select - Projection 
            Console.WriteLine("\n1.2 Get only student names:");
            var names = students.Select(s => s.Name);
            Console.WriteLine($"   {string.Join(", ", names)}");

            // 1.3 OrderBy - Sorting
            Console.WriteLine("\n1.3 Students sorted by age:");
            var sortedByAge = students.OrderBy(s => s.Age);
            foreach (var student in sortedByAge)
                Console.WriteLine($"   {student.Name} (Age: {student.Age})");

        }
    }
}
