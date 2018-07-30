using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharpDSAlgo
{
    class MonthNames
    {
        string[] months = new string[12];
        
        public void displayMonths()
        {
            for (int i = 1; i <= months.Length; i++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                months[i - 1] = name;
            }

            Console.WriteLine("Months in a year: \n");
            foreach (string month in months)
            {                
                Console.WriteLine($"{month} \n");
            }
        }
        
    }
}
