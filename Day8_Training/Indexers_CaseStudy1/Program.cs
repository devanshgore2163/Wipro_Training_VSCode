using System;
using System.Collections.Generic;

namespace PropertiesAndIndexersDemo
{
    // ================= EMPLOYEE CASE =================
    class Employee
    {
        // Properties
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }

        // Private collection for attendance
        private Dictionary<string, int> attendance =
            new Dictionary<string, int>();

        // Indexer
        public int this[string month]
        {
            get
            {
                if (attendance.ContainsKey(month))
                    return attendance[month];
                else
                    return 0;
            }
            set
            {
                attendance[month] = value;
            }
        }
    }

    // ================= E-COMMERCE CASE =================
    class Product
    {
        // Properties
        public string ProductName { get; set; }
        public double Price { get; set; }

        // Private list for ratings
        private List<int> ratings = new List<int>();

        // Indexer
        public int this[int index]
        {
            get
            {
                return ratings[index];
            }
            set
            {
                ratings.Insert(index, value);
            }
        }

        public int RatingsCount()
        {
            return ratings.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ========== EMPLOYEE OBJECT ==========
            Employee emp = new Employee();
            emp.EmployeeName = "Dev";
            emp.EmployeeId = 101;

            // Using indexer
            emp["January"] = 22;
            emp["February"] = 20;

            Console.WriteLine("EMPLOYEE CASE");
            Console.WriteLine("Name: " + emp.EmployeeName);
            Console.WriteLine("ID: " + emp.EmployeeId);
            Console.WriteLine("January Attendance: " + emp["January"]);
            Console.WriteLine("February Attendance: " + emp["February"]);

            Console.WriteLine("--------------------------------");

            // ========== PRODUCT OBJECT ==========
            Product product = new Product();
            product.ProductName = "Laptop";
            product.Price = 65000;

            // Using indexer
            product[0] = 5;
            product[1] = 4;
            product[2] = 5;

            Console.WriteLine("E-COMMERCE CASE");
            Console.WriteLine("Product: " + product.ProductName);
            Console.WriteLine("Price: " + product.Price);

            for (int i = 0; i < product.RatingsCount(); i++)
            {
                Console.WriteLine("Customer " + (i + 1) +
                                  " Rating: " + product[i]);
            }
        }
    }
}

