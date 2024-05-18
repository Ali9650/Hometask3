using Students;

namespace Student
{
    internal class Program
    {
        private static readonly string pb401;
        private static string groupN;

        static void Main()
        {
            Student newStudent = new Student("Ali", "Cahangirov");
            Student newStudent1 = new Student("Cabbar", "Kerimov");
            Student newStudent2 = new Student("Ismayil", "Cavadzade");
            DateTime startDate = new DateTime(2024,03,30);
            DateTime endDate = new DateTime(2025,02,12);
            Teacher newTeacher = new Teacher("Kamran", "Axundov");
            Teacher newTeacher1 = new Teacher("Ali", "Axundov");
            Topic newTopic = new Topic("Introduction", 1);
            Group group = new Group ("PB401", startDate, endDate, newStudent, newTeacher, newTopic);
            group.AddStudent(newStudent);
            group.AddStudent(newStudent1);
            group.AddStudent(newStudent2);
            group.AddTeacher(newTeacher);
            group.AddTeacher(newTeacher1);
            group.AddTopic(newTopic);

           

            group.RemoveStudent(newStudent1);
            group.RemoveTeacher(newTeacher);
            group.RemoveTopic(newTopic);
          

            group.GetStudents();
            group.GetTeachers();
            group.GetTopics();

            group.GetDetails();

        }
    }
}
