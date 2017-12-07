using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homepractice
{
    class Program
    {

        static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "Hello World");
        }

        static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }

        

        static List<Array> ReadInParameters()
        {
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";
            List<string> parameterList = new List<string>();

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    parameterList.Add(line);
                }

            }
            myReader.Close();

            parameterList.Remove("Amplitude Frequency[Hz]");

            float[] frequencyArray = new float[parameterList.Count];
            float[] amplitudeArray = new float[parameterList.Count];
            float[] nullArray = new float[parameterList.Count];
            int i = 0;
            foreach (var parameter in parameterList)
            {
                float amplitude;
                float frequency;

                Char delimiter = ' ';
                string[] stringSplitterArray = parameter.Split(delimiter);

                float.TryParse(stringSplitterArray[0], out amplitude);
                float.TryParse(stringSplitterArray[1], out frequency);

                amplitudeArray[i] = amplitude;
                frequencyArray[i] = frequency;

                i++;
            }
            
            List<Array> returnList = new List<Array>();
            returnList.Add(amplitudeArray);
            returnList.Add(frequencyArray);
            returnList.Add(nullArray);
            returnList.Add(nullArray);
            returnList.Add(nullArray);

            int amplitude = returnList;

            return returnList;
        }

        public void CircleDrawer(List<Array> parameterList, int angleResolution)
        {
            int amplitude = parameterList[0][0];
            
            
                

            while (angleResolution < 360)
            {

            }
        }

        static void Main(string[] args)
        {
            string Filename = @"D:\Greenfox Academy tananyag\repos\greenfox\TamasKerdo\week-03\day01\homepractice\MyFirstFileWrite.txt";
            WriteFile(Filename);
            ReadFile(Filename);
            Console.ReadLine();

            var parameterList = ReadInParameters();
            int angleResolution = 1;

            CircleDrawer(parameterList, angleResolution);

            
            Console.ReadLine();
        }
    }
}
