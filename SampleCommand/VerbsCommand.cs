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
                .WithParsed<ShowMessageVerb>(o => ProcessShowVerb(o))
                .WithParsed<ReverseMessageVerb>(o => ProcessReverseVerb(o))
                .WithParsed<ReplaceMessageVerb>(o => ProcessReplaceVerb(o))
                .WithNotParsed(e => ProcessErrors(e));
        }

        internal bool ProcessShowVerb(ShowMessageVerb values)
        {
            for (var index = 0; index < values.Repetitions; index++)
            {
                Console.WriteLine(values.Message);
            }

            return true;
        }
        
        internal bool ProcessReverseVerb(ReverseMessageVerb values)
        {
            for (var index = 0; index < values.Repetitions; index++)
            {
                Console.WriteLine(values.Message.ToCharArray().Reverse().Aggregate(string.Empty, (x, y) => $"{x}{y}"));
            }

            return true;
        }
        
        internal bool ProcessReplaceVerb(ReplaceMessageVerb values)
        {
            for (var index = 0; index < values.Repetitions; index++)
            {
                Console.WriteLine(values.Message.Replace(values.Old, values.New));
            }

            return true;
        }
    }
}
