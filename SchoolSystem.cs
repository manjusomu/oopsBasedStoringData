using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasedStoringData
{
    public  class SchoolSystem
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public void FillWithData()
        {
            // Filling students with dummy data
            Students.Add(new Student { Name = "John Doe", ClassAndSection = "Class A" });
            Students.Add(new Student { Name = "Raj", ClassAndSection = "Class B" });

            // Filling subjects with dummy data
            Teacher teacher1 = new Teacher { Name = "Mr. Smith" };
            Teacher teacher2 = new Teacher { Name = "Miss. Harini" };

            Subjects.Add(new Subject { Name = "Maths", SubjectCode = "MATH101", Teacher = teacher1 });
            Subjects.Add(new Subject { Name = "English", SubjectCode = "EN1054", Teacher = teacher2 });
        }

        public void DisplayStudentsInClass(string className)
        {
            Console.WriteLine($"Students in {className}:");
            var filteredStudents = Students.Where(student => student.ClassAndSection.Equals(className, StringComparison.OrdinalIgnoreCase));

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }

        public void DisplaySubjectsByTeacher(string teacherName)
        {
            Console.WriteLine($"Subjects taught by {teacherName}:");
            var filteredSubjects = Subjects.Where(subject => subject.Teacher.Name.Equals(teacherName, StringComparison.OrdinalIgnoreCase));

            foreach (var subject in filteredSubjects)
            {
                Console.WriteLine($"- {subject.Name} (Code: {subject.SubjectCode})");
            }
        }
        static void Main(string[] args)
        {
            SchoolSystem ss = new SchoolSystem();
            ss.FillWithData();
           ss.DisplayStudentsInClass("Class C");
            ss.DisplaySubjectsByTeacher("Pooja");

        }
    }
}

