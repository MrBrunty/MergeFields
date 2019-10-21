using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Report_Debugger
{
    class TestingFields
    {
        public static List<string> TestData(string filepath)
        {        
            var testFieldArray = System.IO.File.ReadAllText(filepath).Split(',');
            var testFields = new List<string>();

            foreach (var field in testFieldArray)
            {
                var noWhiteSpaceField = field.Replace("\n","").Trim();
                testFields.Add(noWhiteSpaceField);
            }            
            return testFields;
        }
      
    }
}
