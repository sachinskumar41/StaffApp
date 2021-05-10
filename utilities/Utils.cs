using System;
using System.Collections.Generic;
using StaffLib;

namespace UtilsLib
{
    public static class Utils
    {
        public static Staff FindStaff( List<Staff> list )
        {
            Staff findObj = null;
            int findId;
    
            Console.WriteLine("Enter the Id of the staff member");
            if( Int32.TryParse( Console.ReadLine(), out findId ))
            {
                findObj = list.Find( searchObj => searchObj.Id == findId );
            }

            return findObj;
        }
    }
}