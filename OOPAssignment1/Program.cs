using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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

#region p1q4
//A Class Library is a project that contains reusable classes, methods,
//and logic that can be used by other applications.
//Used for Code Reusability, Better Organization, Separation of Concerns, Easier Maintenance.
#endregion

#region p2

//namespace MovieTicketBookingSystem
//{
//    public enum TicketType
//    {
//        Standard = 0,
//        VIP = 1,
//        IMAX = 2
//    }

//    public struct Seat
//    {
//        public char Row;
//        public int Number;

//        public Seat(char row, int number)
//        {
//            Row = row;
//            Number = number;
//        }

//        public override string ToString()
//        {
//            return $"{Row}{Number}";
//        }
//    }

//    public class Ticket
//    {
//        public string MovieName;
//        public TicketType Type;
//        public Seat Seat;
//        private double Price;

//        public Ticket(string movieName, TicketType type, Seat seat, double price)
//        {
//            MovieName = movieName;
//            Type = type;
//            Seat = seat;
//            Price = price;
//        }

//        public Ticket(string movieName)
//            : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
//        {
//        }

//        public double CalcTotal(double taxPercent)
//        {
//            return Price + (Price * taxPercent / 100);
//        }
//        public void ApplyDiscount(ref double discountAmount)
//        {
//            if (discountAmount > 0 && discountAmount <= Price)
//            {
//                Price -= discountAmount;
//                discountAmount = 0;
//            }
//        }

//        public void PrintTicket()
//        {
//            Console.WriteLine($"Movie    : {MovieName}");
//            Console.WriteLine($"Type     : {Type}");
//            Console.WriteLine($"Seat     : {Seat}");
//            Console.WriteLine($"Price    : {Price:F2}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter Movie Name: ");
//            string movieName = Console.ReadLine();

//            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
//            TicketType type = (TicketType)int.Parse(Console.ReadLine());

//            Console.Write("Enter Seat Row (A, B, C...): ");
//            char row = char.Parse(Console.ReadLine());

//            Console.Write("Enter Seat Number: ");
//            int number = int.Parse(Console.ReadLine());

//            Console.Write("Enter Price: ");
//            double price = double.Parse(Console.ReadLine());

//            Console.Write("Enter Discount Amount: ");
//            double discount = double.Parse(Console.ReadLine());

//            Seat seat = new Seat(row, number);
//            Ticket ticket = new Ticket(movieName, type, seat, price);

//            Console.WriteLine("\n===== Ticket Info =====");
//            ticket.PrintTicket();
//            Console.WriteLine($"Total (14% tax) : {ticket.CalcTotal(14):F2}");

//            Console.WriteLine("\n===== After Discount =====");
//            Console.WriteLine($"Discount Before : {discount:F2}");

//            ticket.ApplyDiscount(ref discount);

//            Console.WriteLine($"Discount After  : {discount:F2}");
//            ticket.PrintTicket();
//        }
//    }
//}
#endregion
