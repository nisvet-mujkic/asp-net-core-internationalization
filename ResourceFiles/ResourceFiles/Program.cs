﻿using ResourceFiles.Resources;
using System;
using System.Globalization;

namespace ResourceFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gender.Unspecified.ToString());
            CultureInfo.CurrentUICulture = new CultureInfo("de-DE");

            Console.WriteLine(Gender.Unspecified.ToLocalizedString());

            Console.ReadLine();
        }
    }
}
