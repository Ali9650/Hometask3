using Students;

namespace Student
{
    internal class Group
    {
        public Group(string groupN, DateTime startDate, DateTime endDate, Student student, Teacher teacher, Topic topic)
        {
            GroupN = groupN;
            students = new Student[0];
            teachers= new Teacher[0];
            topics=new Topic[0];
            StartDate = startDate;
            EndDate = endDate;
            AddStudent(student);
            AddTeacher(teacher);
            AddTopic(topic);
            RemoveStudent(student);
            RemoveTeacher(teacher);
            RemoveTopic(topic);
           
            
          

        }

        public string GroupN { get;}

        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public int Limit { get; set; } = 10;
        private Student[] students;

        public Student[] Students { get; }

        private Teacher[] teachers;

        public Teacher[] Teachers { get; }

        private Topic[] topics;

        public Topic[] Topics { get; }
        

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            if (Limit >=students.Length)
            {
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Group-da yer yoxdur");
            }
        }

        public void GetStudents()
        {
            if (students is not null)
            {
                foreach (Student st in students)
                {
                    Console.WriteLine($"{st.Name} {st.Surname}");
                }
            }
        }

        public void RemoveStudent(Student student)
        {
            var index = Array.IndexOf(students, student);
            if (index != -1)
            {
                for (int i = index + 1; i < students.Length; i++)
                {
                    students[i - 1] = students[i];
                }
                students[students.Length - 1] = null;
                Array.Resize(ref students, students.Length - 1);
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"{GroupN} {StartDate} {EndDate} {Limit}");
        }
       
        
        public void AddTeacher(Teacher teacher)
        {
            Array.Resize(ref teachers, teachers.Length + 1);
            if (Limit >=teachers.Length)
            {
                teachers[teachers.Length-1] = teacher;
            }
        }

        public void GetTeachers()
        {
            if (teachers is not null)
            {
                foreach (Teacher th in teachers)
                {
                    Console.WriteLine($"{th.Name} {th.Surname}");
                }
            }
        }
        public void RemoveTeacher(Teacher teacher)
        {
            var index = Array.IndexOf(teachers, teacher);
            if (index != -1)
            {
                for (int i = index + 1; i < teachers.Length; i++)
                {
                    teachers[i - 1] = teachers[i];
                }
                teachers[teachers.Length - 1] = null;
                Array.Resize(ref teachers, teachers.Length - 1);
            }
        }

        public void AddTopic(Topic topic)
        {
            Array.Resize(ref topics, topics.Length + 1);
            if (Limit >=topics.Length)
            {
                topics[topics.Length - 1] = topic;
            }
        }

        public void GetTopics()
        {
            if (topics is not null)
            {
                foreach (Topic tc in topics)
                {
                    Console.WriteLine($"{tc.Name} {tc.Number}");
                }
            }
        }
        public void RemoveTopic(Topic topic)
        {
            var index = Array.IndexOf(topics, topic);
            if (index != -1)
            {
                for (int i = index + 1; i < topics.Length; i++)
                {
                    topics[i - 1] = topics[i];
                }
                topics[topics.Length - 1] = null;
                Array.Resize(ref topics, topics.Length - 1);
            }

        }
    }
}