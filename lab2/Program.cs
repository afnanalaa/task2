using System;

namespace lab2
{
    class student
    {
        string name;
        int age;
        int ssn;
        string phone;
        public void getdata(string n, int i, int a, string ph)
        {
            string name = n;
            int age = a;
            int ssn = i;
            string phone = ph;

            Console.WriteLine($"your name is : {name} and your age is : {age} and your ssn is : {ssn} and your phone is :  {phone} ");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            Console.WriteLine(" enter the number : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($" {num} * {i} = {num * i}");
            }
            #endregion

            #region problem2
            Console.WriteLine(" enter your age : ");
            int age = int.Parse(Console.ReadLine());

            while (age > 0)
            {
                Console.WriteLine(" enter your name : ");
                string name = Console.ReadLine();
                Console.WriteLine(" enter your ID : ");
                int ID = int.Parse(Console.ReadLine());

                Console.WriteLine($" your name is :{name} and your ID :{ID} and your age: {age} ");
            }
            Console.WriteLine(" invalid age try again ");

            #endregion

            #region problem3
            student stud1 = new student();
            stud1.getdata("afnan", 21, 231, "01295466");
            #endregion



        }
    }
}
