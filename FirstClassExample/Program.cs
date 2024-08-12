using FirstClassExample;
using System;
namespace FirstClass
{
    public class Program
    {
        static void Main()
        {
            Person student1 = new Person();
            student1.name = "Bengü";
            student1.surname = "Aşık";
            student1.dateofbirth = "01.01.1990";
            Person student2 = new Person();
            student2.name = "Polina";
            student2.surname = "Red";
            student2.dateofbirth = "01.01.1990";
            

            Person teacher1 = new Person();
            teacher1.name = "Yıldız";
            teacher1.surname = "Gök";
            teacher1.dateofbirth = "01.01.1990";
            Person teacher2 = new Person();
            teacher2.name = "Ayçil";
            teacher2.surname = "Akşin";
            teacher2.dateofbirth = "01.01.1990";


            //see information

            Console.WriteLine("Student information");
            student1.PrintInformation();
            student2.PrintInformation();

            Console.WriteLine("Teacher information");
            teacher1.PrintInformation();
            teacher2.PrintInformation();
        }

    }
}