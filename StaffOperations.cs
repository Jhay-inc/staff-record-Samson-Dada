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
                if (departmentOption == 1)
                {
                    //string testRole = "Non Teaching role";

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
                    //Math.Round(100);
                   //long staffId = Convert.ToInt64(Console.ReadLine());

                StaffRegister(firstName, lastName, email, password);
                    DateTime testDate = DateTime.Now;
                    Console.WriteLine(testDate);
                }
            }
            else if (departmentOption == 2)
            {

                if(departmentOption == 2)
                {
                    Console.WriteLine("Enter 1 for Principal || Enter 2 for Teacher || Enter 3 for Exam officer || Enter 4 for Admin");
                    string testRole = "Principal";
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



                StaffRegister(firstName, lastName, email, password);
                }
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

        public void StaffRegister(string firstName, string lastName, string email, string password)
        {

            string role = "Teacher";
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
            staffLists[0].FirstName = firstName.ToUpper();
            staffLists[0].LastName = lastName.ToUpper();
            staffLists[0].Email = email.ToUpper();
            staffLists[0].Password = password.ToUpper();
            staffLists[0].CreatedTime =  DateTime.Today;
            staffLists[0].ID = 12344;

            //Random rd = new Random();

            Random number = new Random();
            int staffID = number.Next(100, 200);

            Math.Round(0000.33);
            //Random rd = new Random();

            //int rand_num = rd.Next(100, 200);

            Console.WriteLine($"Account Creted on: {CreatedTime}");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"FIRSTNAME | {firstName}");
            Console.WriteLine($"LASTNAME  | {lastName}" );
            Console.WriteLine($"EMAIL     | {email}");
            Console.WriteLine($"PASSWORD  | {password}");
            Console.WriteLine("------------------------");
            Console.WriteLine($"ROLE      | {role}");
            Console.WriteLine($"ID card   | {staffID}");
            Console.WriteLine("------------------------");
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
