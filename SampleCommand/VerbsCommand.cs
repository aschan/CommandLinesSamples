namespace SampleCommand
{
    using System;
    using System.Linq;

    using CommandLine;

    internal class VerbsCommand : Command
    {
        internal override void Parse(string[] args)
        {
            Parser.Default.ParseArguments<ShowMessageVerb, ReverseMessageVerb, ReplaceMessageVerb>(args)
                          .WithParsed<ShowMessageVerb>(ProcessShowVerb)
                          .WithParsed<ReverseMessageVerb>(ProcessReverseVerb)
                          .WithParsed<ReplaceMessageVerb>(ProcessReplaceVerb)
                          .WithNotParsed(ProcessErrors);
        }

        private void ProcessShowVerb(ShowMessageVerb values)
        {
            for (var index = 0; index < values.Repetitions; index++)
            {
                Console.WriteLine(values.Message);
            }
        }
        
        private void ProcessReverseVerb(ReverseMessageVerb values)
        {
            for (var index = 0; index < values.Repetitions; index++)
            {
                Console.WriteLine(values.Message.ToCharArray().Reverse().Aggregate(string.Empty, (x, y) => $"{x}{y}"));
            }
        }
        
        private void ProcessReplaceVerb(ReplaceMessageVerb values)
        {
            for (var index = 0; index < values.Repetitions; index++)
            {
                Console.WriteLine(values.Message.Replace(values.Old, values.New));
            }
        }
    }
}
