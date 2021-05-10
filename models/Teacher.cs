using System;
using StaffLib;

namespace TeacherLib
{
    public class Teacher : Staff
    {
        private string Subject { get; set; }
        public Teacher()
        {
            Type = "Teacher";
        }
        public override void AddStaffDetails()
        {
            base.AddStaffDetails();
            Console.WriteLine("Enter the subject");
            Subject = Console.ReadLine();
        }
        public override void UpdateStaffDetails()
        {
            string checkInput;
            base.UpdateStaffDetails();
            Console.WriteLine("Enter the new subject");
            checkInput = Console.ReadLine();
            if( checkInput != "" )
            {
                Subject = checkInput;
            }
        }
        public override void ViewStaffDetails()
        {
            base.ViewStaffDetails();
            Console.WriteLine("Subject: {0}\n", Subject);
        }
    }
}