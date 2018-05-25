namespace SampleCommand
{
    using System;

    using CommandLine;

    internal class NamedOptionsCommand : Command
    {
        internal override void Parse(string[] args)
        {
            Parser.Default.ParseArguments<NamedOptions>(args)
                .WithParsed(o => ProcessOptions(o))
                .WithNotParsed(e => ProcessErrors(e));
        }

        internal bool ProcessOptions(NamedOptions options)
        {
            for (var index = 0; index < options.Repetitions; index++)
            {
                Console.WriteLine(options.Message);
            }

            return true;
        }
    }
}
