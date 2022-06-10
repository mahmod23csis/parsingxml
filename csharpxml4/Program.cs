using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text;



namespace ParsingXml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load XML file to memory
            XDocument xmlDoc = XDocument.Load(@"C:\Users\v-mahahmad.NORTHAMERICA\source\repos\csharpxml4\AddSolutionComponentRequest.xml");
            
            // Iterable object for Member element children to get all MemberName attributes
            IEnumerable<XElement> xElements = xmlDoc.Descendants("Member");

            Console.WriteLine("Validating XML documents for missing description\n");

            // Output the type name to console
            Console.WriteLine(xmlDoc.Root.Attribute("Name").Value.ToString());

            // For loop to iterate through each MemberName attribute
            foreach (XElement element in xElements)
            {
                // Output MemberName values to console
                Console.WriteLine("Member Name: " + element.Attribute("MemberName").Value);

                // summary variable to store elements under summary
                var summary = element.Descendants("summary");

                // For loop to iterate through each element in summary 
                foreach (var item in summary)
                {
                    // If description says For internal use only, do nothing
                    if (item.Value == "For internal use only")
                        Console.WriteLine("Processed successfully.\n");

                    // If description is not empty, output a message
                    else if (!String.IsNullOrEmpty(item.Value))
                        Console.WriteLine("This class has summary. Processed successfully.\n");

                    // Otherwise, if description is empty, print out a message
                    else
                        Console.WriteLine("This class is missing description.\n");
                }
            }
            Console.ReadKey();
        }
    }
}
