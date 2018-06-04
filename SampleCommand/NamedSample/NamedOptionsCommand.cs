namespace SampleCommand.NamedSample
{
    using System;

    using CommandLine;

    internal class NamedOptionsCommand : Command
    {
        internal override void Parse(string[] args)
        {
            Parser.Default.ParseArguments<NamedOptions>(args)
                          .WithParsed(ProcessOptions)
                          .WithNotParsed(ProcessErrors);
        }

        private void ProcessOptions(NamedOptions options)
        {
            for (var index = 0; index < options.Repetitions; index++)
            {
                Console.WriteLine(options.Message);
            }
        }
    }
}
