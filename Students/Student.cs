namespace Student
{
    internal class Student
    {

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}