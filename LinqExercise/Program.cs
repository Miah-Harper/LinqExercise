﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
       

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //TODO: Print the Sum of numbers

            Console.WriteLine("Sum of numbers");

            //var numSum = numbers.Sum();
            Console.WriteLine(numbers.Sum());

            Console.WriteLine();



            //TODO: Print the Average of numbers

            Console.WriteLine("Average numbers");

           
            Console.WriteLine(numbers.Average());

            Console.WriteLine();
            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Ascending Numbers");
            var numAscending = numbers.OrderBy(x => x == 0);


            foreach(var ascending in numAscending)
            {
                Console.WriteLine(ascending);
            }

            Console.WriteLine();


            //TODO: Order numbers in decsending order adn print to the console

            Console.WriteLine("Descending numbers");

            var numDescending = numbers.OrderByDescending(x => x);

            foreach(var descending in numDescending)
            {
                Console.WriteLine(descending);
            }

            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Numbers greater than six");

            var greaterThanSix = numbers.Where(x => x > 6);

            foreach (var six in greaterThanSix)
            {
                Console.WriteLine(six);
           }
            Console.WriteLine();
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Only 4 numbers ascending");

            var ascending2 = numbers.Take(4);                                  

           foreach(var numAscending2 in ascending2)
            {
               Console.WriteLine(numAscending2);
            }
        
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("Index descending with my age added ");

            numbers.Select((x, i) => i == 4 ? 28 : x).OrderByDescending(x => x).ToList().ForEach(Console.WriteLine); 


            //numbers.SetValues(28,4);
            //numbers.OrderByDescending(x => x).ToList().ForEach(Console.WriteLine);
           


            // List of employees ****Do not remove this****

            var employees = CreateEmployees();

            Console.WriteLine();
            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.

            var filteredEmployess = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower()[0] == 's').OrderBy(person => person.FirstName);

            Console.WriteLine("Order by C or S");

            foreach (var person in filteredEmployess)
            {
                Console.WriteLine(person.FullName);
            }


            Console.WriteLine();
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var twentySix = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);

            Console.WriteLine(" > 26");

            foreach(var employee in twentySix)
            {
                Console.WriteLine($"Name: {employee.FullName}, Age: {employee.Age}");
            }

            Console.WriteLine();
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35

            Console.WriteLine("YOE");
            

            var sumAndYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            Console.WriteLine($"Total YOE: {sumAndYOE.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine($"Avg YOE: {sumAndYOE.Average(x => x.YearsOfExperience)}");

            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("New employee added");

            employees = employees.Append(new Employee("Miah", "Harper", 28, 100000)).ToList();

            employees.ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
