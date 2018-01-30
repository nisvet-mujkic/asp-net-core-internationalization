using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Understanding_Internationlization
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            CultureInfo.CurrentCulture = ci;
            DisplayCurrentCulture();
            DateTimeDisplayDemo();
            DateTimeParseDemo();

            CultureInfo.CurrentCulture = new CultureInfo("bs-Latn-BA");
            DisplayCurrentCulture();
            DateTimeDisplayDemo();
            DateTimeParseDemo();


            Console.OutputEncoding = Encoding.UTF8;

            Console.ReadLine();
        }

        static void DisplayCurrentCulture()
        {
            Console.WriteLine("===================================");
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.WriteLine(CultureInfo.CurrentCulture.DisplayName);
            Console.WriteLine("===================================");
        }

        static void DateTimeDisplayDemo()
        {
            Console.WriteLine(DateTime.Now);
        }

        static void DateTimeParseDemo()
        {
            string date = "2.12.2018";
            DateTime dateTime = DateTime.Parse(date);
            Console.WriteLine(dateTime.ToString("D"));
        }

    }
}
