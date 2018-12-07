using System;

namespace No4.Solution
{
    public class RandomBytesGenerator : RandomFileGeneratorBase
    {
        public override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}