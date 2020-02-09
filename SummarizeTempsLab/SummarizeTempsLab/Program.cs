using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // temperature data is in temps.txt
            string filePath = "temps.txt";
            
            if (File.Exists(filePath))
            {

                using (StreamReader sr = File.OpenText(filePath)) 
                { string line = "enter temperature threshold";
                
                while  ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("The file does not exist");
                Console.ReadLine();
            }
                //under if
                // ask the user to enter the temperature threshold                                                       
                // open the file and create StreamReader
                // read a line into a string variable
                // while the line is not null
                    // convert (parse) into an integer variable
                    // add the temperature to my summing variable
                    // if the current temperature value >= threshold
                        // increment "above" counter by 1
                    // else temperature is below
                        // increment "below" counter by 1
        }
    }
}
