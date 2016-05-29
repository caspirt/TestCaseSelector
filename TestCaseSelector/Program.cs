using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

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
