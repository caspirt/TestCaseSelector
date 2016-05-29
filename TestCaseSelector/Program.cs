using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using System.IO;

namespace TestCaseSelector
{

    // Define a class to receive parsed values
    class Options
    {
        [Option('f', "file", Required = true,
          HelpText = "Input file to be processed.")]
        public string InputFile { get; set; }

        [Option('r', "rows", DefaultValue = 10,
          HelpText = "Number of rows")]
        public int Rows { get; set; }
        
    }

    class Program
    {
        static int Main(string[] args)
        {
            var options = new Options();

            CommandLine.Parser.Default.ParseArguments(args, options);
            // options.InputFile = 1.txt
            // options.Rows = 10

            if (args.Length == 0)
            {
                System.Console.WriteLine("No parameters for run . Please try with path to file and number of row");
                System.Console.WriteLine("Usage: TestCaseSelector 'path' <num>");
                return 1;
            }


            try
            {
                FileStream fs = new FileStream("somefile.txt", FileMode.Open);
                //некоторый код, который выполнится, если файл удалось открыть без ошибок
            }
            catch
            {
                //код, который нужно выполнить, если случилась ошибка в блоке try
            }
            finally
            {
                fs.Close();
                //сюда можно добавить любой код который должен выполнится независимо от того, случилась ли ошибка
            }



            int counter = 0;
            string line;

            // Read the file by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(options.InputFile);
            while (((line = file.ReadLine()) != null ) && (counter < options.Rows))
            {
                System.Console.WriteLine(line);
                counter++;
            }



            return 0;
        }
    }
}
