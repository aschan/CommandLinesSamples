namespace SimpleSample
{
    using System;
    using System.Collections.Generic;

    using CommandLine;

    internal static class Program
    {
        internal static void Main(string[] args)
        {
            #region  Using default parser with separate mapping/processing of result
            //var result = Parser.Default.ParseArguments<SimpleValues>(args);
            //if (result.Tag == ParserResultType.Parsed)
            //{
            //    result.MapResult(ProcessSimplevalues, ProcessErrors);
            //}
            #endregion

            #region Using default parser with immediate mapping/processing
            //var result = Parser.Default.ParseArguments<SimpleValues>(args)
            //    .WithParsed(o => ProcessSimplevalues(o))
            //    .WithNotParsed(e => ProcessErrors(e));
            #endregion
        }

        internal static bool ProcessSimplevalues(SimpleValues values)
        {
            for (var index = 0; index < values.Repetitions; index++)
            {
                Console.WriteLine(values.Message);
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
