using System.IO;
using System.Xml.Linq;
using System.Text;


namespace ParsingXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load(@"C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml");

            IEnumerable<XElement> xElements = xmlDoc.Descendants("Member");

            Console.WriteLine("Validating XML documents for missing description\n");

            foreach (XElement element in xElements)
            {
                Console.WriteLine("Member Name: " + element.Attribute("MemberName").Value);

                var summary = element.Descendants("summary");

                foreach (var item in summary)
                {
                    if (item.Value == "For internal use only")
                        Console.WriteLine("Processed successfully.");

                    else if (!String.IsNullOrEmpty(item.Value))
                        Console.WriteLine("This class has summary. Processed successfully.");

                    else
                        Console.WriteLine("This class is missing description.");
                }
            }
            Console.ReadKey();
        }
    }
}
