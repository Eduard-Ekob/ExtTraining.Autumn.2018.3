namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var boldText = new BoldText { Text = "boldText" };

            var hyperLink = new Hyperlink { Url = "zelda.com", Text = "Go" };

            var plainText = new PlainText { Text = "plainText" };
            DocumentPart[] parts = { hyperLink, boldText, plainText };
            Document document = new Document(parts);

            System.Console.WriteLine($"To LaTeX: {document.Convert(l => l.ToLaTeX())}");
            System.Console.WriteLine($"To Html: {document.Convert(h => h.ToHtml())}");
            System.Console.WriteLine($"To Plain text: {document.Convert(p => p.ToPlainText())}");


            System.Console.ReadLine();
        }
    }
}
