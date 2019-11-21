using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Custom_Report_Debugger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var installLocation = Directory.GetCurrentDirectory() + "\\Logs";                                                                                       //Creates a Log file - and folder if one doesn't exist
            Directory.CreateDirectory(installLocation);           
            var logFile = installLocation + "\\" + DateTime.Now.ToString("dd-MM-yy HH'.'mm'.'ss") + ".txt";
            var log = File.Create(logFile);
            log.Close();
            
            var (uniqueMergefields, duplicateMergefields) = ExistenceCheck.DefineLegalMergefields(ConfigurationManager.AppSettings.Get("DataDictionary").Split(',')); //Grabs config arguements for the legal mergefields so I don't have to hardcode
            File.AppendAllText(logFile, "The following fields were loaded as legal fields from the config file, if any fields are missing or incorrect, please add them to the config:" + Environment.NewLine);
            foreach (var field in uniqueMergefields)
            {
                File.AppendAllText(logFile, Environment.NewLine + field);
            }

            var exceptionInFileUse = true;                                                                                                                          //Loads the file to be tested
            var mergefieldsInDoc = new List<string>();
            Console.WriteLine("Please enter the file path for the text file you are wanting to test, this text file must be in the following format: \n\n{MERGEFIELD FirmAddress3},\n{MERGEFIELD FirmCounty},\n{MERGEFIELD Firm FcaReference},\n{MERGEFIELD FirmName}\n\nThe filepath must be in the following format: \n\nC:\\Users\\Tom\\Documents\\Tickets\\Custom Reports\\TextFile1.txt\n\n");
            while (exceptionInFileUse == true)
            {
                //var filepath = @"C:\Users\Tom.Tom-PC\Documents\C Sharp Projects\Custom Report Debugger\TextFile1.txt";                                             //hardcoded filepath for testing
                var filepath = Console.ReadLine().Trim(); //Comment out whilst in test mode
                (mergefieldsInDoc, exceptionInFileUse ) = TestingFields.TestData(filepath);
            }
            
            Console.WriteLine("Testing Fields...");
            Console.WriteLine("Removing excluded fields...");
            var mergefieldsToTest = ExistenceCheck.RemoveAdditionalSpacingAndUnneccearyFields(mergefieldsInDoc, logFile);

            Console.WriteLine("...Checking Fields against the mergefield database.");

            var failedMergefields_doNotExist = ExistenceCheck.CheckExistenceOfMergefield(mergefieldsToTest, uniqueMergefields, logFile);                            //Runs the various tests - each has it's own class
            Console.WriteLine("...Checking for missing begin and end groups");
            var (failedMergefields_MissingBegin, failedMergefields_MissingEnd) = BeginAndEndGroups.CheckAllBeginGroupsHaveEndGroups(mergefieldsToTest);
            Console.WriteLine("...Testing hierarchy");
            var failedMergefields_Hierarchy = HierarchyChecker.HierarchyManagement(mergefieldsToTest, logFile);
            var totalErrors = failedMergefields_doNotExist.Count + failedMergefields_Hierarchy.Count + failedMergefields_MissingBegin.Count + failedMergefields_MissingEnd.Count;
            Console.WriteLine("...Testing complete, a total of {0} errors were found.", totalErrors);

            File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "A total of " + totalErrors + " errors were found" + Environment.NewLine);      //Adds all issues to logfile

            if (failedMergefields_doNotExist.Count == 0)
            {
                File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "All tested fields could be found in the databse!" + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "The following fields could not be found within the loaded mergefield database, this could be down to a spelling error, capitalisation issue or spacing:" + Environment.NewLine + Environment.NewLine + "***IMPORTANT*** If any begin groups fail here or in the next steps, it will cause major issues later on, fix Begin and End Group issues and then re-run the program!" + Environment.NewLine);
                foreach (var field in failedMergefields_doNotExist)
                {
                    File.AppendAllText(logFile, Environment.NewLine + " - " + field);
                }
            }

            if (failedMergefields_MissingEnd.Count == 0)
            {
                File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "All tested mergefields had a corresponding end group!" + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "The Following Fields are missing their corresponding End Group: " + Environment.NewLine);
                foreach (var field in failedMergefields_MissingEnd)
                {
                    File.AppendAllText(logFile, Environment.NewLine + " - " + field);
                }
            }
            if (failedMergefields_MissingBegin.Count == 0)
            {
                File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "All tested mergefields had a corresponding begin group!" + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "The Following Fields are missing their corresponding Begin Group: " + Environment.NewLine);
                foreach (var field in failedMergefields_MissingBegin)
                {
                    File.AppendAllText(logFile, Environment.NewLine + " - " + field);
                }
            }
            if (failedMergefields_Hierarchy.Count == 0)
            {
                File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "All tested mergefields appeared to follow the correct hierarchy!" + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(logFile, Environment.NewLine + Environment.NewLine + "The following fields did not match the expected path: " + Environment.NewLine);
                foreach (var field in failedMergefields_Hierarchy)
                {
                    File.AppendAllText(logFile, Environment.NewLine + " - " + field);
                }
            }

            File.AppendAllText(logFile, Environment.NewLine + "\n*** PLEASE NOTE ***" + Environment.NewLine + "This system is a work in progress and is not guaranteed to pick up on issues, it does not currently have the capacity to search through Tables and Page breaks, these are known to break custom reports so are a good place to start should you have issues. Past that, you may need to check manually. In the event that you find an issue that this program did not identify, please report it to Tom, ideally with the file pre-fix so that he can establish why it wasn't picked up and correct the issue/add functionality" + Environment.NewLine + Environment.NewLine + "I hope this solved your problem, I put a lot of time and love in to getting this completed. If it didn't work then... Unluckers");

            Console.WriteLine("\nA file containing details of the last test has been generated and placed here: \n" + logFile);
            Console.WriteLine("\n Please press any key to exit");
            Console.ReadLine();

        }
    }
}
