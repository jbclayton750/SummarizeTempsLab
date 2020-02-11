using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName;  //tempts.txt"
            Console.WriteLine("Enter filename");
            fileName = Console.ReadLine();
            
            if (File.Exists(fileName))
            {
                Console.WriteLine("The file exists");
                Console.WriteLine("Enter the threshold temperature");
                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int SumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;
                int tempcount = 0;

                using (StreamReader sr = File.OpenText(fileName)) 
                { 
                    string line = sr.ReadLine();
                    int temp;
                
                    while  (line != null)
                    {
                        temp = int.Parse(line);
                       
                        SumTemps += temp;

                        tempcount += 1;
                        
                        if (temp >= threshold)
                        {
                            numAbove += 1;
                        }
                        else
                        {
                            numBelow += 1;
                        }

                        line = sr.ReadLine();
                    }
                }

                Console.WriteLine("Temperatures above " + numAbove);

                Console.WriteLine("Temperatures below " + numBelow);

                int average = SumTemps / tempcount;

                Console.WriteLine("Average temp = " + average);
                 
            }
            else
            {
                Console.WriteLine("The file does not exist");
            }
        }
    }
}
