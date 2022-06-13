using System;
using System.Globalization;
using System.Xml.Linq;

namespace ParsingXml
{

	public class XmlFile
	{

        public static string MyFile;

        public void ParseFile(string val)
        {
            XDocument xmlDoc = XDocument.Load(val);

            IEnumerable<XElement> xElements = xmlDoc.Descendants("Member");

            Console.WriteLine("Validating XML documents for missing description\n");

            // Output the type name to console
            Console.WriteLine("Type: " + xmlDoc.Root.Attribute("Name").Value.ToString() + "\n");

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