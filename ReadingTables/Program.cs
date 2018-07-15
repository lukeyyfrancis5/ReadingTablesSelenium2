using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace ReadingTables
{
    class Program : Base 
    {
        static void Main(string[] args)
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("file:///C:/TablePages/ComplexTable.html");

            TablePage page = new TablePage();

            // Read table   
            Utilities.ReadTable(page.table);

            Console.WriteLine("-----------------------------------");

            // Get the cell value from the table
            Console.WriteLine("The Name {0} with Email {1} and Phone {2}",
                Utilities.ReadCell("Name", 2), Utilities.ReadCell("Email", 2), Utilities.ReadCell("Phone", 2));

            Console.WriteLine("-----------------------------------");

            // Delete Name
            Utilities.PerformActionOnCell("5", "Name", "Luke", "Delete");

            Console.Read();
        }
    }
}
