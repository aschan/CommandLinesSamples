namespace SampleCommand
{
    using System;

    using CommandLine;

    internal class ValuesSampleCommand : Command
    {
        internal override void Parse(string[] args)
        {
            Parser.Default.ParseArguments<SimpleValues>(args)
                .WithParsed(o => ProcessValues(o))
                .WithNotParsed(e => ProcessErrors(e));
        }

        internal bool ProcessValues(SimpleValues values)
        {
            for (var index = 0; index < values.Repetitions; index++)
            {
                Console.WriteLine(values.Message);
            }

            return true;
        }
    }
}
