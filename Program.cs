using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace Custom_Report_Debugger
{
    public class Program
    {
        public static void Main(string[] args)
        {             
            var (uniqueMergefields, duplicateMergefields) = ExistenceCheck.DefineLegalMergefields(ConfigurationManager.AppSettings.Get("DataDictionary").Split(',')); //Grabs config arguements for the legal mergefields so I don't have to hardcode

            var filepath = @"C:\Users\Tom.Tom-PC\Documents\C Sharp Projects\Custom Report Debugger\TextFile1.txt"; //hardcoded filepath for testing
            Console.WriteLine("Please enter the file path for the text file you are wanting to test, this text file must be in the following format: \n\n{MERGEFIELD FirmAddress3},\n{MERGEFIELD FirmCounty},\n{MERGEFIELD Firm FcaReference},\n{MERGEFIELD FirmName}\n\nThe filepath must be in the following format: \n\nC:\\Users\\Tom\\Documents\\Tickets\\Custom Reports\\TextFile1.txt\n\n");
            //filepath = Console.ReadLine().Trim(); Commented out whilst in test mode

            var mergefieldsToTest = TestingFields.TestData(filepath);  
            var failedMergefields_doNotExist = ExistenceCheck.CheckExistenceOfMergefield(mergefieldsToTest, uniqueMergefields);
            var (failedMergefields_MissingBegin, failedMergefields_MissingEnd) = BeginAndEndGroups.CheckAllBeginGroupsHaveEndGroups(mergefieldsToTest);
            var failedMergefields_Hierarchy = HierarchyChecker.HierarchyManagement(mergefieldsToTest);


            Console.WriteLine("\nThe following fields could not be found within the existing mergefield database, this means that there is a spelling error, capitalisation issue or an additional space that is causing it to not match, please note that mergefields that fail here will not get tested for hierarchy so you will need to correct these before retesting:\n");
            foreach (var field in failedMergefields_doNotExist)
            {
                Console.WriteLine("- " + field);
            }

            Console.WriteLine("\n-----------------------------------------------------");

            Console.WriteLine("The Following Fields are missing an End Group\n");
            foreach (var field in failedMergefields_MissingEnd)
            {
                Console.WriteLine("- " + field);
            }

            Console.WriteLine("\n-----------------------------------------------------");

            Console.WriteLine("The Following Fields are missing a Begin Group\n");
            foreach (var field in failedMergefields_MissingBegin)
            {
                Console.WriteLine("- " + field);
            }

            Console.WriteLine("\n-----------------------------------------------------");

            Console.WriteLine("\n The following fields did not match the expected path: ");

            foreach (var field in failedMergefields_Hierarchy)
            {
                Console.WriteLine("- " + field);
            }
        }
    }
}
