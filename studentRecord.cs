using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_experiment
{
    public class studentRecord
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string dept { get; set; }
        public int marks { get; set; }

    }
    public class lambda
    {
        public void sortedList()
        {
            List<studentRecord> students = new List<studentRecord>();
            students.Add(new studentRecord() { id = 1, name = "adam", age = 22, dept = "CSE", marks = 85 });
            students.Add(new studentRecord() { id = 2, name = "thas", age = 19, dept = "ECE", marks = 90 });
            students.Add(new studentRecord() { id = 3, name = "vignesh", age = 17, dept = "CSE", marks = 85 });
            students.Add(new studentRecord() { id = 4, name = "prabu", age = 21, dept = "EEE", marks = 95 });

            foreach(var student in students)
            {
                Console.WriteLine(($"{student.id} Name: {student.name}, Age:{student.age}, Dept:{student.dept}, Score:{student.marks}"));
            }
            Console.WriteLine();
            List<studentRecord> newStudentList = students.FindAll(stud => (stud.age >= 20)).ToList();

            //students.Sort((s1, s2) => s1.age - s2.age);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.name} {student.age}");
            }
            foreach (var student in newStudentList)
            {
                Console.WriteLine(($"{student.id} Name: {student.name},Age:{student.age}, Dept:{student.dept}, Score:{student.marks}"));
            }
        }
    }
}
