using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using StaffLib;
using TeacherLib;
using AdminLib;
using SupportLib;
using UtilsLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> staffList = new List<Staff>();
            char continueChoice;
            bool isChar;
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            string schoolName = configuration.GetSection("SchoolDetails:Name").Value;

            Console.WriteLine("\nWelcome to {0} staff menu !", schoolName);
            Console.WriteLine("----------------------------------------------");

            do
            {   
                int menuChoice;
                Console.WriteLine("\nEnter your choice:\n");
                Console.WriteLine("\t1 - Add");
                Console.WriteLine("\t2 - View");
                Console.WriteLine("\t3 - View all");
                Console.WriteLine("\t4 - Update");
                Console.WriteLine("\t5 - Delete");

                if( Int32.TryParse( Console.ReadLine(), out menuChoice ))
                {
                    switch( menuChoice )
                    {   
                        case 1:
                            char staffChoice;
                            Console.WriteLine("Enter staff type\n");
                            Console.WriteLine("\ta - Teacher");
                            Console.WriteLine("\tb - Administrative");
                            Console.WriteLine("\tc - Support");

                           if( Char.TryParse( Console.ReadLine(), out staffChoice ))
                            {
                                Staff addObj = null;

                                switch( staffChoice )
                                {
                                    case 'a':
                                        addObj = new Teacher();
                                        break;
                                    case 'b':
                                        addObj = new Admin();
                                        break;
                                    case 'c':
                                        addObj = new Support();;
                                        break;
                                    default:
                                        break;
                                }
                                if( addObj != null )
                                {   
                                    addObj.AddStaffDetails();
                                    staffList.Add(addObj);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice");
                            }
                            break;
                        case 2:
                            Staff viewObj = Utils.FindStaff( staffList );

                            if( viewObj != null )
                            {
                                viewObj.ViewStaffDetails();
                            }
                            else
                            {
                                Console.WriteLine("Not found");
                            }
                            break;
                        case 3:
                            foreach ( Staff staffObj in staffList )
                            {
                                staffObj.ViewStaffDetails();
                            }
                            break;
                        case 4:
                            Staff updateObj = Utils.FindStaff( staffList );

                            if( updateObj != null )
                            {
                                updateObj.UpdateStaffDetails();
                            }
                            else
                            {
                                Console.WriteLine("Not found");
                            }
                            break;
                        case 5:
                            Staff deleteObj = Utils.FindStaff( staffList );

                            if( deleteObj != null )
                            {
                                staffList.Remove( deleteObj );
                            }
                            else
                            {
                                Console.WriteLine("Not found");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

                Console.WriteLine("\nPress Y to continue...");
                isChar = Char.TryParse( Console.ReadLine().ToLower(), out continueChoice );
            }while( isChar == true && continueChoice == 'y' );
        }
    }
}

