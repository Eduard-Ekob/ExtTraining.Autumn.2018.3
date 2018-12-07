namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomCharsGenerator = new RandomCharsGenerator();
            var randomBytesGenerator = new RandomBytesGenerator();

            randomCharsGenerator.GenerateFiles(1, 20);
            randomBytesGenerator.GenerateFiles(2, 50);
        }
    }
}
