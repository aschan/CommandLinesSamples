namespace SampleCommand.VerbsSample
{
    using System.Collections.Generic;

    using CommandLine;
    using CommandLine.Text;

    [Verb("replace", HelpText = "Replaces text in the message and shows the result.")]
    internal class ReplaceMessageVerb
    {
        [Option('r', "repetitions", Required = true, HelpText = "Number of times the messages should be repeated.")]
        public int Repetitions { get; set; }

        [Option('m', "message", HelpText = "The message text.")]
        public string Message { get; set; }

        [Option('o', "old", Required = true, HelpText = "The text to find and replace.")]
        public string Old { get; set; }

        [Option('n', "new", HelpText = "The text new text to insert.")]
        public string New { get; set; }

        [Usage(ApplicationAlias = "SampleCommand")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                yield return new Example("Normal usage",
                    new ReplaceMessageVerb
                    {
                        Repetitions = 3,
                        Message = "Replace old with new",
                        Old = "old",
                        New = "new"
                    });
                yield return new Example("Other usage",
                    new ReplaceMessageVerb
                    {
                        Repetitions = 3,
                        Message = "Replace old with nothing",
                        Old = "old",
                        New = null
                    });
            }
        }
    }
}