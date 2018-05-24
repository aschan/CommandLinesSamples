namespace NamedOptions
{
    using System;
    using System.Collections.Generic;

    using CommandLine;

    internal static class Program
    {
        internal static void Main(string[] args)
        {
            Parser.Default.ParseArguments<NamedOptions>(args)
                .WithParsed(o => ProcessSimplevalues(o))
                .WithNotParsed(e => ProcessErrors(e));
        }

        internal static bool ProcessSimplevalues(NamedOptions options)
        {
            for (var index = 0; index < options.Repetitions; index++)
            {
                Console.WriteLine(options.Message);
            }

            return true;
        }

        internal static bool ProcessErrors(IEnumerable<Error> errors)
        {
            var foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var error in errors)
            {
                Console.WriteLine($"ERROR: {error.Tag}");
            }

            Console.ForegroundColor = foregroundColor;
            return false;
        }
    }
}