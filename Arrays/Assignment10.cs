using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class FileReader
    {
        public static void ReadFile(string filePath)
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader("okikik.txt");
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();  // Ensure the file is closed
                    Console.WriteLine("File closed");
                }
            }
        }
    }
}
