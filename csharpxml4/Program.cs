using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text;


namespace ParsingXml
{
    class Program
    {
       // private static XDocument xmlDoc;
        static void Main(string[] args)
        {
            XmlFile f = new XmlFile();

            Console.Write("Please type your XML Path/URL: ");
            string MyFile = Console.ReadLine();

            // "C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml"

            // Handle file error
            // If file doesn't exist or wrong format, prompt again
            f.ParseFile(MyFile);

            Console.ReadKey();
            }
            
            // Load XML file to memory
            //XDocument xmlDoc = XDocument.Load(@"C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml");
            //OpenFile();
            //XDocument xmlDoc = XDocument.Load(@"C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml");
            // Iterable object for Member element children to get all MemberName attributes
        }
    }
