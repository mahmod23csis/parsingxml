using System.IO;
using System.Xml.Linq;
using System.Text;


namespace ParsingXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load(@"C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml");
            IEnumerable<XElement> xElements = doc.Descendants("Member");
            foreach (XElement element in xElements)
            {
                Console.WriteLine("Member Name: " + element.Attribute("MemberName").Value);
                var summ = element.Descendants("summary");
                foreach (var item in summ)
                {
                    
                    Console.WriteLine("Description: " + item.Value);
                }
            }
            Console.ReadKey();
        }
    }
}
