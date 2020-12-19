using CSVHelperGeneric.Models;
using CSVHelperGeneric.Services;
using System;

namespace CSVHelperGeneric
{
    class Program
    {
        static void Main()
        {
            #region Read CSV File
            Console.WriteLine("--- Read from CSV file ---");
            IUserService userService = new UserService();
            var path = @"C:\Users\3xP3rT\Desktop\Book1.csv";
            var result = userService.ReadCsvFileToList(path);
            #endregion

            #region Write CSV File
            var user = new User()
            {
                Firstname = "Nakibul Islam",
                Lastname = "Shaki",
                Address = "Moulvibazar, Sylhet",
                City = "Moulvibazar"
            };
            //add object to readlist
            result.Add(user);
            Console.WriteLine("--- Write to CSV file ---");
            userService.WriteCsvFile(@"C:\Users\3xP3rT\Desktop\Book1.csv", result);
            #endregion
        }
    }
}
