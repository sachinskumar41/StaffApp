using System;
using StaffLib;

namespace SupportLib
{
    public class Support : Staff
    {
        private int Age { get; set; }
        public Support()
        {
            Type = "Support";
        }
        public override void AddStaffDetails()
        {
            int parseInput;
            base.AddStaffDetails();
            Console.WriteLine("Enter the age");
            
            if( Int32.TryParse( Console.ReadLine(), out parseInput ))
            {
                Age = parseInput;
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
        }
        public override void DeleteStaffDetails()
        {
            base.DeleteStaffDetails();
        }
        public override void UpdateStaffDetails()
        {
            int parseInput;
            string checkInput;
            base.UpdateStaffDetails();
            Console.WriteLine("Enter the new age");
            checkInput = Console.ReadLine();

            if( checkInput != "" )
            {
                if( Int32.TryParse( checkInput, out parseInput ))
                {
                    Age = parseInput;
                }
                else
                {
                    Console.WriteLine("Invalid age");
                }
            }
        }
        public override void ViewStaffDetails()
        {
            base.ViewStaffDetails();
            Console.WriteLine("Age: {0}\n", Age);
        }


    }
}