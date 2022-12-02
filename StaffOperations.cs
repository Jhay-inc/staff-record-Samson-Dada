using System;
using System.Collections.Generic;
using System.Threading;

namespace StaffRecord
{
    public class StaffOperations : StaffRecord
    {
        public StaffOperations()
        { 
            Console.WriteLine("......Welcome to staff portal!!!........");
            Console.WriteLine("Enter 1 Non Academic Staff | Enter 2 for Academic Staff | Enter 3 to Login");

            string key = Console.ReadLine();
            Console.Clear();
            int departmentOption = Convert.ToInt16(key);
            if (departmentOption == 1)
            {
                if (departmentOption == 1)
                {
                    //string testRole = "Non Teaching role";
                    Console.WriteLine("Enter 1 for Exam officer");
                    Console.WriteLine("Non Academic department Enter details............");
                //firstname
                Console.WriteLine("Enter firstname");
                string firstName = Console.ReadLine();
                Thread.Sleep(400);
                Console.Clear();

                //second name
                Console.WriteLine("Enter lastname: ");
                string lastName = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                    //email
                    string email;
                    bool isValidEmail;
                    do
                    {
                        Console.Write("Enter Email: ");
                        email = Console.ReadLine();
                        isValidEmail = Validate.ValidateEmail(email);

                        if (!isValidEmail)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Email address must be valid. Please retry!");
                            Console.ResetColor();
                        }
                    }
                    while (!isValidEmail);

                    //password
                    bool isValidPassword;
                    string password;
                    do
                    {
                        Console.WriteLine("Enter Passowrd: ");
                        password = Console.ReadLine();
                        isValidPassword = Validate.ValidatePassoword(password);

                        if (!isValidPassword)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Passoword must be valid. Please retry!");
                            Console.ResetColor();
                        }
                    }
                    while (!isValidPassword);
                    StaffRegister(firstName, lastName, email, password);
                   // DateTime testDate = DateTime.Now;
                    //Console.WriteLine(testDate);
                }
            }
            else if (departmentOption == 2)
            {

                if(departmentOption == 2)
                {
                    Console.WriteLine("Enter A for Principal || Enter B for Teacher || Enter C for Exam officer || Enter D for Admin");
                Console.WriteLine("Academic department Enter details");
                //firstname
                Console.WriteLine("Enter firstname");
                string firstName = Console.ReadLine();
                Thread.Sleep(400);
                Console.Clear();

                //second name
                Console.WriteLine("Enter lastname");
                string lastName = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                Console.WriteLine();
                Console.Clear();
                    string email;
                    bool isValidEmail;
                    do
                    {
                        Console.WriteLine("Enter Email: ");
                        email = Console.ReadLine();
                        isValidEmail = Validate.ValidateEmail(email);

                        if (!isValidEmail)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Email address must be valid. Please retry!");
                            Console.ResetColor();
                        }
                    }
                    while (!isValidEmail);

                    //password
                    bool isValidPassword;
                    string password;
                    do
                    {
                        Console.WriteLine("Enter Passowrd: ");
                        password = Console.ReadLine();
                        isValidPassword = Validate.ValidatePassoword(password);

                        if (!isValidPassword)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Passoword must be valid. Please retry!");
                            Console.ResetColor();
                        }
                    }
                    while (!isValidPassword);
                    Console.Clear();
                StaffRegister(firstName, lastName, email, password);
                }
            }
            else if(departmentOption == 3)
            {
                Console.Write("Enter Your Email: ");
                string email = Console.ReadLine();
                Thread.Sleep(400);
                Console.Clear();

                //second name
                Console.Write("Enter lastname: ");
                string password = Console.ReadLine();
                Thread.Sleep(400);
                Console.Clear();

            }

            else
            {
                bool isDepartment;
                do
                {
                    isDepartment = int.TryParse(Console.ReadLine(), out departmentOption);
                    //Console.Clear();
                    if (!isDepartment)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not a department. Please retry!");
                        Console.ResetColor();
                    }
                }
                while (!isDepartment);
            }

        }

        public void StaffRegister(string firstName, string lastName, string email, string password)
        {

            string role="pincipal";
            Console.WriteLine("Select Role | Enter A for Princiapl | Enter B for Teacher | Enter C for Admin");

            var optionKey = Console.ReadKey().Key;
            Console.Clear();
                switch (optionKey)
                {
                case ConsoleKey.A:

                    AddRole(role);
                        Console.WriteLine($"Register as a: {role}");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.B:
                        AddRole("Teacher");
                        Console.WriteLine(role);
                        break;
                    case ConsoleKey.C:
                        AddRole("Admin");
                    Console.WriteLine(role);
                        break;
                    default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR! Retry");
                    Console.ResetColor();

                    break;
                }
            ////////////////// dataBase class
            List<StaffRecord> staffLists = new List<StaffRecord>();
            staffLists.Add(new StaffRecord());
            staffLists[0].FirstName = firstName.ToUpper();
            staffLists[0].LastName = lastName.ToUpper();
            staffLists[0].Email = email.ToUpper();
            staffLists[0].Password = password.ToUpper();
            staffLists[0].CreatedTime =  DateTime.Today;
            staffLists[0].ID = 0;
            Random number = new Random();
            int staffID = number.Next(1000, 2000);
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                return;
            }
            else
            {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"FIRSTNAME | {firstName}");
            Console.WriteLine($"LASTNAME  | {lastName}" );
            Console.WriteLine($"EMAIL     | {email}");
            Console.WriteLine($"PASSWORD  | {password}");
            Console.WriteLine($"ROLE      | {role}");
            Console.WriteLine("------------------------");
            Console.WriteLine("*******ID CARD******");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------");
            Console.WriteLine($"FULLNAME  | {firstName} {lastName}");
            Console.WriteLine($"ROLE      | {role}");
            Console.WriteLine($"ID NUMBER | {staffID}");
            Console.WriteLine("------------------------");
            Console.ResetColor();
            }
        }
        public void AddRole(string role)
        {
           var roleList = new List<string>();
            DepartmentRole = roleList;

            roleList.Add(role);
            roleList.Add(role);
            roleList.Add(role);
            roleList.Add(role);
          
        }

    }
}
