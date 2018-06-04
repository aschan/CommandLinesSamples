namespace SampleCommand.VerbsSample
{
    using CommandLine;

    [Verb("show", HelpText = "Shows the message.")]
    internal class ShowMessageVerb
    {
        [Option('r', "repetitions", Required = true, HelpText = "Number of times the messages should be repeated.")]
        public int Repetitions { get; set; }

        [Option('m', "message", HelpText = "The message text.")]
        public string Message { get; set; }
    }
}
