namespace SampleCommand
{
    using CommandLine;

    internal class SimpleValues
    {
        [Value(0, Required = true, HelpText = "Number of times the message should be repeated.")]
        public int Repetitions { get; set; }

        [Value(1, HelpText = "The message text.")]
        public string Message { get; set; }
    }
}
