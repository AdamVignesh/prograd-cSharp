using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_play_exp
{
    internal class Aggregation
    {

    }
    public class Marks
    {
        public int totalMarks;
        public int noOfSubjects;
        public Marks(int totalMarks,int noOfSubjects)
        {
            this.totalMarks = totalMarks;
            this.noOfSubjects = noOfSubjects;
        }
        public float percentage;
        public void percentageCal()
        {
            percentage = (totalMarks / noOfSubjects);
            Console.WriteLine(percentage);
        }
    }
    public class Student
    {
        string name;
        int age;
        int rollNo;
        int dept_id;
        Marks M;
        public Student(string name, int age, int rollno, int dept_id, Marks M)
        {
            this.name = name;
            this.age = age;
            this.rollNo = rollno;
            this.dept_id = dept_id;
            this.M = M;
        }
        public void display()
        {
            Console.WriteLine($"Name : {name},age : {age} ,rollno: {rollNo}, dept_id : {dept_id},Total marks : {M.totalMarks}");
            M.percentageCal();
            Console.WriteLine($"Your percentage is : {M.percentage}");
        }
    }
}
