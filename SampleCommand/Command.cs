namespace SampleCommand
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CommandLine;

    internal abstract class Command
    {
        internal abstract void Parse(string[] args);

        protected void ProcessErrors(IEnumerable<Error> errors)
        {
            var foregroundColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (var error in errors)
                {
                    var nameInfo = (NameInfo)error.GetType().GetProperties()?.FirstOrDefault(p => p.PropertyType == typeof(NameInfo))?.GetValue(error);
                    Console.WriteLine($"ERROR: {error.Tag} {nameInfo?.NameText}");
                }
            }
            finally
            {
                Console.ForegroundColor = foregroundColor;
            }
        }
    }
}
