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
            List<StaffRecord> staffLists = new List<StaffRecord>();
            staffLists.Add(new StaffRecord());
           staffLists.Add(new StaffRecord());
            //StaffLists[0].CreatedTime = DateTime.Today;

            staffLists.Add(new StaffRecord());

            foreach (StaffRecord staff in staffLists)
            {
                staff.CreatedTime = DateTime.Today;
                Console.WriteLine($"Staff record lIst{staff}");
            }
        }
    }

}
