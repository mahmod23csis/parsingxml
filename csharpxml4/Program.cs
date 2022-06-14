using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text;


namespace XmlParser
{
    class Program
    {
       // private static XDocument xmlDoc;
        static void Main(string[] args)
        {
            Parser parser = new Parser();

            Console.Write("Please type your XML Path/URL: ");
            string MyFile = Console.ReadLine();

            // "C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml"

            // Handle file error
            // If file doesn't exist or wrong format, prompt again

            Console.WriteLine("Reporting missing API descriptions\n");

            parser.Parsing(MyFile);
            parser.Reporting();

            Console.ReadKey();
            }
            
            // Load XML file to memory
            //XDocument xmlDoc = XDocument.Load(@"C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml");
            //OpenFile();
            //XDocument xmlDoc = XDocument.Load(@"C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml");
            // Iterable object for Member element children to get all MemberName attributes
        }
    }
