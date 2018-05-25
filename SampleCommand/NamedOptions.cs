namespace SampleCommand
{
    using CommandLine;

    internal class NamedOptions
    {
        [Option('r', "repetitions", Required = true, HelpText = "Number of times the messages should be repeated.")]
        public int Repetitions { get; set; }

        [Option('m', "message", HelpText = "The message text.")]
        public string Message { get; set; }
    }
}