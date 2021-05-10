using System;
using StaffLib;

namespace AdminLib
{
    public class Admin : Staff
    {
        private string Department { get; set; }
        public Admin()
        {
            Type = "Administrative";
        }
        public override void AddStaffDetails()
        {
            base.AddStaffDetails();
            Console.WriteLine("Enter the department");
            Department = Console.ReadLine();
        }
        public override void DeleteStaffDetails()
        {
            base.DeleteStaffDetails();
        }
        public override void UpdateStaffDetails()
        {
            string checkInput;
            base.UpdateStaffDetails();
            Console.WriteLine("Enter the new department");
            checkInput = Console.ReadLine();
            if( checkInput != "" )
            {
                Department = checkInput;
            }
        }
        public override void ViewStaffDetails()
        {
            base.ViewStaffDetails();
            Console.WriteLine("Department: {0}\n", Department);
        }


    }
}