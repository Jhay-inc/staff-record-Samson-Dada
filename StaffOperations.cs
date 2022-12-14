using System;
using System.Collections.Generic;
using System.Threading;
using System.Security;

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
                        Console.WriteLine("Enter Passowrd Min 5 Max 11):: ");
                        password = Console.ReadLine();
                        isValidPassword = Validate.ValidatePassoword(password);
                        SecureString pass =   Validate.PassowrdEncrypt();
                        password = new System.Net.NetworkCredential(string.Empty, pass).Password;
                        if (!isValidPassword)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Passoword must be valid. Please retry!");
                            Console.ResetColor();
                        }
                    }
                    while (!isValidPassword);
                    StaffRegister(firstName, lastName, email,  password);
                }
            }
            else if (departmentOption == 2)
            {
            Console.WriteLine("bugs");

                if(departmentOption == 2)
                {
                Console.WriteLine("Academic department Enter details");
                     
                    //firstname
                Console.WriteLine("Enter firstname");
                string firstName = Console.ReadLine();
                Thread.Sleep(400);
                Console.Clear();
                Validate.ValidateUserName(firstName);
                    
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
                        Console.WriteLine("Enter Passowrd(Min 5 Max 11): ");
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
            Console.WriteLine("Enter A for Principal || Enter B for Teacher || Enter C for Exam officer || Enter D for Admin");
            var optionKey = Console.ReadKey().Key;
            Console.Clear();
            switch (optionKey)
            {
                case ConsoleKey.A:
                    var p = StaffRoles.pincipalRole;
                    Console.WriteLine(p);
                    Console.WriteLine();
                    break;
                case ConsoleKey.B:
                    var t = StaffRoles.teacherRole;
                    Console.WriteLine(t);
                    break;
                case ConsoleKey.C:
                    var e= StaffRoles.pincipalRole;
                    Console.WriteLine(e);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ResetColor();
                    break;
            }

            string staffRole = "";
            Random number = new Random();
            int staffID = number.Next(1000, 2000);
            ////////////////// dataBase class
            List<string> roles = new List<string>();
            roles.Add(StaffRoles.pincipalRole);
            roles.Add(StaffRoles.teacherRole);
            roles.Add(StaffRoles.examOfficerRole);
            roles.Add(StaffRoles.adminRole);

            foreach (var role in roles)
            {
                staffRole = role.ToString();
            }
            List<StaffRecord> staffLists = new List<StaffRecord>();
            staffLists.Add(new StaffRecord());

            foreach (StaffRecord staff in staffLists)
            {
                staff.FirstName = firstName;
                staff.LastName = lastName;
                staff.Email = email;
                staff.Password = password;
                staff.CreatedTime = DateTime.Today;
                staff.DepartmentRole = staffRole;
                staff.ID = staffID;
            }
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                return;
            }
            else
            {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" User Input");
            Console.WriteLine($"FIRSTNAME | {firstName}");
            Console.WriteLine($"LASTNAME  | {lastName}" );
            Console.WriteLine($"EMAIL     | {email}");
            Console.WriteLine($"PASSWORD  | {password}");
            Console.WriteLine($"ROLE      | {staffRole}");
            Console.WriteLine("------------------------");
            Console.WriteLine("*******ID CARD******");
                IdCard = new List<string>();
                IdCard.Add(firstName);
                IdCard.Add(lastName);
                IdCard.Add(email);
                IdCard.Add(staffID.ToString());
                foreach(StaffRecord DisplayIdCard in staffLists)
                {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------");
            Console.WriteLine($"FULLNAME  | {DisplayIdCard.FirstName} {DisplayIdCard.LastName}");
            Console.WriteLine($"ROLE      | {DisplayIdCard.DepartmentRole}");
            Console.WriteLine($"EMAIL     | {DisplayIdCard.Email}");
            Console.WriteLine($"ID NUMBER | {DisplayIdCard.ID}");
            Console.WriteLine("------------------------");
            Console.ResetColor();
                }
            }
        }
    }
}
