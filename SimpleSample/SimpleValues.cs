namespace SimpleSample
{
    using CommandLine;

    internal class SimpleValues
    {
        [Value(0)]
        public int Repetitions { get; set; }

        [Value(1)]
        public string Message { get; set; }
    }
}