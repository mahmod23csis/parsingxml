using System;
using System.Globalization;
using System.Xml.Linq;

namespace XmlParser
{

	public class Parser
	{
        private IEnumerable<XElement> xElements;
        private string type;
        public void Parsing(string val)
        {
            // Load XML file to memory
            XDocument xmlDoc = XDocument.Load(val);

            // Iterable object for Member element children to get all MemberName attributes
            xElements = xmlDoc.Descendants("Member");

            type = xmlDoc.Root.Attribute("Name").Value.ToString();
            // Output the type name to console
            Console.WriteLine("Type: " + type + "\n");
        }

        public void Reporting()
        {
            int typeCount = 0;
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

                    // If description says To be added, output a message
                    if (item.Value == "To be added.")
                        Console.WriteLine("Processed successfuly.\n");

                    // If description is not empty, output a message
                    else if (!String.IsNullOrEmpty(item.Value))
                        Console.WriteLine("Type {0} processed...fully documented\n", type);

                    // Otherwise, if description is empty, print out a message
                    else if (String.IsNullOrEmpty(item.Value))
                    {
                        Console.WriteLine("type {0} processed...type description missing\n", type);
                        typeCount++;
                    }
                        
                }
            }
            Console.WriteLine("type {0} processed...{1} member(s) missing description(s)", type, typeCount);
            Console.ReadKey();
        }
    }
}