using System;
using System.IO;

namespace task2
{
    internal class Program
    {
        private static void SplitText(string Name0, int k, string Name1, string Name2, string Name3)
        {
            using (StreamReader streamReader = new StreamReader(Name0))
            using (StreamWriter streamWriter1 = new StreamWriter(Name1))
            using (StreamWriter streamWriter2 = new StreamWriter(Name2))
            using(StreamWriter streamWriter3 = new StreamWriter(Name3))
            {
                string s1 = "";
                string rows = "";
                for (int i = 0; i < k; i++)
                {
                    s1 = streamReader.ReadLine();
                    
                    streamWriter1.WriteLine(s1);
                    streamWriter3.WriteLine(s1);
                }
                
                while (!streamReader.EndOfStream)
                {
                    rows =  streamReader.ReadLine();
                    
                    streamWriter2.WriteLine(rows); 
                    streamWriter3.WriteLine(rows); 
                }
            }
        }
        
        private static void Main(String[] args)
        {
            SplitText("Name0.txt", 3, "Name1.txt","Name2.txt","Name3.txt");
        }
    }
}