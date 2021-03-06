using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text;


namespace XmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string File_Name;

            Parser parser = new Parser();

            while (true)
            {
                Console.Write("Please type your XML document name: ");
                // Example: AddSolutionComponentRequest.xml
                File_Name = Console.ReadLine();
                FileInfo fi = new FileInfo(File_Name);
                string extn = fi.Extension;
                try
                {
                    if (extn != ".xml")
                    {
                        Console.WriteLine("Please choose XML documents only");
                    }
                    else if (File.Exists(File_Name))
                    {
                        Console.WriteLine("\nFile Name: " + File_Name);
                        Console.WriteLine("\n*** Reporting missing API descriptions ***\n");
                        parser.Parsing(File_Name);
                        parser.Reporting();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(File_Name + " file does not exist in the current directory.");
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (DirectoryNotFoundException ex) 
                { 
                    Console.WriteLine(ex);
                }

            }
        }
    }
}
