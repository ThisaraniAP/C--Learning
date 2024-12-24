using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradigm_examples
{
    internal class Student
    {
        private string name;
        private int age;
        private string gender;
        private int marks;

        public Student(string firstName, string lastName, int age, string gender, int marks)
        {
            this.name = $"{firstName} {lastName}";
            this.age = age;
            this.gender = gender;
            this.marks = marks;
        }

        public void Information()
        {
            Console.WriteLine($"Name: {this.name} \nAge: {this.age}\nGender: {this.gender}" +
                $"\nMarks: {this.marks}");
        }
    }
}

