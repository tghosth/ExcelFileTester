using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFileTester
{
    class Program
    {

        public static string FilePath = @"Z:\host\Users\joshg\Documents\Clients\Ministry of Health\IAM Project\ExcelTest";

        static void Main(string[] args)
        {

            // This doesnt actually work, it just goes on file extension!?!?!?!?!

            foreach (string path in Directory.GetFiles(FilePath))
            {
                Console.WriteLine(string.Format("\"{0}\":", path));
                Console.WriteLine("File type is: {0}", MimeTypes.GetContentType(path));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
