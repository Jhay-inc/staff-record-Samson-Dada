using System;
using System.Collections.Generic;

namespace StaffRecord
{
    public class StaffRecord
    {
      
    
        /*
         Principal’s ID card is grey in color
·        Teachers ID card is blue in color
·        Non-academic staff’s ID card is brown in color
         
         */
        //public void IdCardColor()
        //{
        //    int color = 0;
        //    //List<string> setColor = new List<string>();
        //    //setColor.Add("Grey");
        //    //setColor.Add("Blue");
        //    //setColor.Add("Brown");

        //    //if (setColor.Contains("Grey"))
        //    //{
        //    //    Console.WriteLine($"Color: {color}");
        //    //}
        //  IdColor = new List<string>();
        //    IdColor.Add("Me");
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
       public string Email { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }
        public DateTime CreatedTime { get; set; }
        public List<string> ColorList { get; set; }
       public string DepartmentRole { get; set; }
        public List<string> IdCard { get; set; }

    }
}
