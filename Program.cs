using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];

            //Read the numbers from Text file
            string inputPath = "C:\\Users\\VETRI VIJAY PANDIAN\\source\\repos\\ConsoleApp1\\ConsoleApp1\\InputFile.txt";
            StreamReader sr = new StreamReader(inputPath);
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();

          
            //Sorting the array - Bubble Sort
            bool flag = true;
            int count = 0;
            for (int i = 1; (i <= (intArray.Length - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (intArray.Length - 1); j++)
                {
                    count = count + 1;
                    if (intArray[j + 1] > intArray[j])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                        flag = true;
                    }
                }
            }                  
           
            //Write the sorted numbers
            string outputPath = "C:\\Users\\VETRI VIJAY PANDIAN\\source\\repos\\ConsoleApp1\\ConsoleApp1\\OutputFile.txt";
            StreamWriter sw = new StreamWriter(outputPath);

            for (int counter = 0; counter < intArray.Length; counter++)
            {
                sw.WriteLine(intArray[counter]);
            }
            sw.Close();

        }
    }
}

