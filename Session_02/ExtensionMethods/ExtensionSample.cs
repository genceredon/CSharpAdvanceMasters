namespace Session_02.ExtensionMethods
{
    internal class ExtensionSample
    {
        public ExtensionSample()
        {
            //string word = "C Sharp Advanced Masters";
            //string word2 = "C Sharp Advanced Masters";
            //int count = word.WordCount();
            //int count2 = word2.WordCount();
            //Console.WriteLine(count);

            int num = 10;
            Console.WriteLine(num.IsIntegerLessThanZeroExt());
            Console.WriteLine(Helper.IsIntegerLessThanZero(num));
            Console.WriteLine(Helper.IsIntegerLessThanZeroExt(num));
        }
    }
}