namespace Session_02.ExtensionMethods
{
    internal class ExtensionSample
    {
        public ExtensionSample()
        {
            string word = "C Sharp Advanced Masters";
            int count = word.WordCount();

            Console.WriteLine(count);
        }
    }
}