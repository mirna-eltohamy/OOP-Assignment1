using System;
using System.ComponentModel;
#region p1q1
//namespace OOPAssignment1
//{
//    //Part 1
//    //class PersonClass
//    //{
//    //    public string Name;
//    //}

//    //struct PersonStruct
//    //{
//    //    public string Name;
//    //}

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //PersonClass p1 = new PersonClass();
//            //p1.Name = "Mirna";

//            //PersonClass p2 = p1;  // copies reference
//            //p2.Name = "Sara";

//            //Console.WriteLine(p1.Name);  //Sara - changed


//            //PersonStruct s1;
//            //s1.Name = "Mirna";

//            //PersonStruct s2 = s1; // copies value
//            //s2.Name = "Sara";

//            //Console.WriteLine(s1.Name);  //Mirna - not changed

//        }
//    }
//}
#endregion

#region p1q2
//namespace OOPAssignment1
//{    class Student
//    {
//        public string Name;      // Accessible everywhere
//        private int Age;         // Accessible only inside this class

//        public void SetAge(int age)
//        {
//            Age = age;           // Allowed (inside class)
//        }

//        public int GetAge()
//        {
//            return Age;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Student s = new Student();

//            s.Name = "Mirna";     // Allowed
//                                  // s.Age = 20;        // ERROR (private)

//            s.SetAge(20);         // Correct way
//            Console.WriteLine(s.GetAge());
//        }
//    }

//}
#endregion

#region p1q3
//Create a new project - Class Library(.NET) - ex: MathLibrary

//Write Code in Library - ex: namespace MathLibrary {public class calculator{ public int addFunction(int a,int b){return a+b;}}}

//build project

//Use the Library in Another Project
//ex:
//using MathLibrary;
//class Program
//{
//    static void Main()
//    {
//        Calculator calc = new Calculator();
//        Console.WriteLine(calc.Add(5, 3));
//    }
//}

#endregion