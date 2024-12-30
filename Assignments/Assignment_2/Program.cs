using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public struct Student
    {
        //string _Name;
        //bool _Gender;
        //int _Age;
        //int _Std;
        //char _Div;
        //double _Marks;

        private string _Name;
        private bool _Gender;
        private int _Age;
        private int _Std;
        private char _Div;
        private double _Marks;

        public double Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }


        public char Div
        {
            get { return _Div; }
            set { _Div = value; }
        }

        public int Std
        {
            get { return _Std; }
            set { _Std = value; }
        }


        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        // default ctor supproted V10 onwards
        //public Student()
        //{
        //    _Name = "";
        //    _Gender = true;
        //    _Age = 0;
        //    _Std = 0;
        //    _Div = 'X';
        //    _Marks = 0;
        //}

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            _Name = name;
            _Gender = gender;
            _Age = age;
            _Std = std;
            _Div = div;
            _Marks = marks;
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter the Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the Gender (1 for male and 0 for female) : ");
            Gender = Convert.ToInt32(Console.ReadLine()) == 1;

            Console.WriteLine("Enter the age : ");
            this.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Standard : ");
            this.Std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Division : ");
            this.Div = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the Marks : ");
            this.Marks = Convert.ToDouble(Console.ReadLine());

        }


        public void PrintDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Gender : " + (Gender ? "Male" : "Female"));
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Std : " + Std);
            Console.WriteLine("Div : " + Div);
            Console.WriteLine("Marks : " + Marks);
            //return Name + " " + Gender + " " + Age + " " + Std + " " + Div + " " + Marks;
            //Console.WriteLine(Name + " " + Gender + " " + Age + " " + Std + " " + Div + " " + Marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.PrintDetails();

            Student student1 = new Student("kartik", true, 22, 12, 'A', 100);
            student1.PrintDetails();

            student.AcceptDetails();
            student.PrintDetails();
        }
    }

}
