

using System.Data;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace Student
{
    internal class Group
    {
        public Group (DateTime startDate, DateTime endDate, Student student)
        {
            students = new Student[0];
            StartDate = startDate;
            EndDate = endDate;
            AddStudent(student);

        }
        public string GroupN { get; }

        public DateTime StartDate { get; }
         public DateTime EndDate { get; }
         
        public int Limit { get; set; } = 10;
        private Student[] students;

        public Student[] Students { get; } 
     

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, Students.Length + 1);
                if (Limit > Students.Length)
            {
                students[students.Length-1] = student;
            }
            else
            {
                Console.WriteLine("Group-da yer yoxdur");
            }
        }

        public void GetStudents ()
        {
            if (students is not null)
            {
                foreach (Student st in students)
                {
                    Console.WriteLine($"{st.Name} {st.Surname}");
                }
            }
        }

        public void RemoveStudent (Student student)
        {
            var index = Array.IndexOf(students, student);
            if (index !=-1)
            {
                for (int i = index+1; i < students.Length; i++)
                {
                    students[i-1] = students[i];
                }
                students[students.Length - 1] = null;
            }
            else
            {
                Console.WriteLine("Bu qrupda yoxdur");
            }
        }
    }
}
