using System.Data;

namespace Student
{
    internal class Program
    {
        static void Main()
        {
            Student newStudent = new Student ("Ali", "Cahangirov");
            Student newStudent1 = new Student("Cabbar", "Kerimov");
            Student newStudent2 = new Student("Ismayil", "Cavadzade");
            DateTime startDate = new DateTime (30,03,2024);
            DateTime endDate = new DateTime (12,02,2025);
        }
    }
}
