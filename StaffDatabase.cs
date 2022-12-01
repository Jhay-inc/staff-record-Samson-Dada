using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecord
{
    public class StaffDatabase : StaffRecord
    {
        

        static StaffDatabase()
        {
            List<StaffRecord> StaffLists = new List<StaffRecord>();
            StaffLists.Add(new StaffRecord());
            StaffLists[0].FirstName = "Carlos";
            StaffLists[0].LastName = "Beans";
            StaffLists[0].Email = "sam@gmail.com";
            StaffLists[0].Password = "*****";
            StaffLists[0].CreatedTime = DateTime.Today;
        }
    }

    // continue here....StaffRegister(string firstName, string lastName, string email, string password);
    // var staff = record.StaffRegister();
    //List<StaffRecord> StaffLists = new List<StaffRecord>();
    //StaffLists.Add(new StaffRecord());
    //StaffLists[0].FirstName = "Carlos";
    //StaffLists[0].LastName = "Beans";
    //StaffLists[0].Email = "sam@gmail.com";
    //StaffLists[0].Password = "*****";

    /*
      public void StaffRegister(string firstName, string lastName, string email, string password)
    {

        List<StaffRecord> StaffLists = new List<StaffRecord>();
        StaffLists.Add(new StaffRecord());
        StaffLists[0].FirstName = firstName;
        StaffLists[0].LastName = lastName;
        StaffLists[0].Email = email;
        StaffLists[0].Password = password;


        Console.WriteLine("Welcome to staff record portal your detalis is | {0} {1} {2} {3}", firstName, lastName, email, password);
        var listOfColor = new List<string>() 

        { "yellow", "Green", "Blue"};
        Color(listOfColor);

        foreach (var item in listOfColor)
        {
            var s = item.ElementAt(0);
            //Console.WriteLine(s);
        }
    }

     */

    //StaffLists = new List<StaffRecord>();
    // StaffLists.Add(new StaffRecord());
    // StaffLists[1].FirstName = "Carlos";
    // StaffLists[2].LastName = "Dada";
    // StaffLists[3].Email = "sam@gmail.com";
    // StaffLists[4].Password = "*****";
    // StaffLists[0].DepartmentRole =  new StaffRoles().pincipalRole;

    // FirstName = firstName.Trim();
    // LastName = lastName.Trim();
    // Password = password.Trim();
    // Email = email;
   

}
