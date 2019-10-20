using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Configuration;

namespace Custom_Report_Debugger
{
    public class ExistenceCheck
    {
        public static List<string> CheckExistenceOfMergefield(List<string> mergefieldsToTest, List<string> legalMergefields)
        {
            var failedMergefields_doNotExist = new List<string>();

            foreach (var field in mergefieldsToTest)
            {                
                if (legalMergefields.Contains(field))
                {                    
                    //Console.WriteLine("{0} has passed test 1", field);  //Remove once 
                }                                                       
                else                                                    
                {                                                       
                    failedMergefields_doNotExist.Add(field);           
                    //Console.WriteLine("{0} has failed test 1", field);  //program is stable
                }
            }

            return failedMergefields_doNotExist;              
        }

        public static (List<string>, List<string>) DefineLegalMergefields(string[] configMergefields) //Need to convert to Lists as .contains is heavenly
        {
            var listOfFields_NoWhiteSpace = new List<string>();
            var uniqueMergefields = new List<string>();
            var duplicateMergefields = new List<string>();


            foreach (var field in configMergefields)
            {
                listOfFields_NoWhiteSpace.Add(field.Replace("\n","").Trim());
            }           

            foreach (var field in listOfFields_NoWhiteSpace)
            {                
                if (uniqueMergefields.Contains(field))
                {
                    if (duplicateMergefields.Contains(field))
                    {
                        continue;
                    }
                    else
                    {
                        duplicateMergefields.Add(field);
                    }                    
                }
                else
                {
                    uniqueMergefields.Add(field);
                }                    
            }                
            return (uniqueMergefields, duplicateMergefields);
        }

    }
}
