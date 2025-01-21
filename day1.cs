// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {   
        var total = 0;
        var sim = 0;
        var firstNumber = new List<int>();
        var secondNumber = new List<int>();

        string filePath = @"C:\\Users\\User\\advent_of_code\\input.txt";
        if(!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist :{0} ", filePath);
            return;
        }      

        string[] textFromFile = File.ReadAllLines(filePath);
        foreach (string line in textFromFile)
        {
            //Console.WriteLine(line);
            //split each line into 2 lists
            string[] splitLine = line.Split("   ");
            var a  = Int32.Parse(splitLine[0]);
            var b = Int32.Parse(splitLine[1]);
            firstNumber.Add(a);
            secondNumber.Add(b);
        } 
        firstNumber.Sort();
        secondNumber.Sort();
        //firstNumber.ForEach(Console.WriteLine);
        //secondNumber.ForEach(Console.WriteLine);
        for (int i = 0; i < firstNumber.Count; i++)
        {
            // total += Math.Abs(firstNumber[i] - secondNumber[i]);
           for (int j = 0; j < secondNumber.Count; j++)
           {
               if (firstNumber[i] == secondNumber[j])
               {
                   sim += 1;
               }
           }
           total += (firstNumber[i] * sim);
           sim = 0;
        }
        Console.WriteLine(total);
    }
}
