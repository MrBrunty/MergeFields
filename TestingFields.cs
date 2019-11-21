using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Report_Debugger
{
    class TestingFields
    {
        public static (List<string>, bool) TestData(string filepath)
        {
            var testFields = new List<string>();
            bool exceptionThrown;

            try
            {
                var testFieldArray = System.IO.File.ReadAllText(filepath).Split(',');

                foreach (var field in testFieldArray)
                {
                    var noWhiteSpaceField = field.Replace("\n", "").Trim();
                    testFields.Add(noWhiteSpaceField);
                }
                exceptionThrown = false;
                return (testFields, exceptionThrown);
            }

            catch (Exception)
            {
                Console.WriteLine("***An exception was thrown, please try again ***");
                exceptionThrown = true;
                return (testFields, exceptionThrown);
                    
            }



        }
      
    }
}
