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
            Console.WriteLine("Enter 1 Non Academic Staff | Enter 2 for Academic Staff");
            string principalRole = "Principal Role";
            string role = principalRole;

            string key = Console.ReadLine();
            Console.Clear();
            int departmentOption = Convert.ToInt16(key);
            if (departmentOption == 1)
            {
                Console.WriteLine("Non Academic department Enter details............");
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

                //email
                Console.WriteLine("Enter email");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                //password
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                StaffRegister(firstName, lastName, email, password, role);
            }
            else if (departmentOption == 2)
            {
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

                //email
                Console.WriteLine("Enter email");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                //password
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                Console.Clear();

                StaffRegister(firstName, lastName, email, password, role);
            }
            //else{
            //    bool isDepartment;
            //    do
            //    {
            //        isDepartment = int.TryParse(Console.ReadLine(), out departmentOption);
            //        Console.Clear();
            //        if (!isDepartment)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Not a department. Please retry!");
            //            Console.ResetColor();
            //        }
            //    }
            //    while (!isDepartment);
            //}

        }

        public void StaffRegister(string firstName, string lastName, string email, string password, string role)
        {
            List<string> roleList = new List<string>();
            //DepartmentRole = roleList;
            roleList.Add(role);
            //
          
            Console.WriteLine("Enter 1 for Principal || Enter 2 for Teacher || Enter 3 for Exam officer || Enter 4 for Admin");
            string key = Console.ReadLine();
            Console.Clear();
                int AcademicOption = Convert.ToInt16(key);
                switch (AcademicOption)
                {
                    case 1:
                        AddRole(role);
                        Console.WriteLine(role);
                        Console.WriteLine();
                        break;
                    case 2:
                        AddRole(role);
                        Console.WriteLine(role);
                        break;
                    case 3:
                        AddRole(role);
                        Console.WriteLine(role);
                        break;
                    case 4:
                        AddRole(role);
                        Console.WriteLine(role);
                        break;
                    default:
                        Console.WriteLine("Retry");
                        break;
                }
            ////////////////// dataBase class
            List<StaffRecord> staffLists = new List<StaffRecord>();
            staffLists.Add(new StaffRecord());
            staffLists[0].FirstName = firstName;
            staffLists[0].LastName = lastName;
            staffLists[0].Email = email;
            staffLists[0].Password = password;
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("FirstName   |  LastName     | Email    | Password | Role");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine($"{lastName}   | { firstName}   | {email}   | {password}   | {role[0]}");
            Console.WriteLine("-------------------------------------------------------------------------");
        }
        public void AddRole(string role)
        {

           //var roleList = new List<string>();

            //roleList.Add(role);
            //roleList.Add(role);
            //roleList.Add(role);
            //roleList.Add(role);
        }

    }
}
