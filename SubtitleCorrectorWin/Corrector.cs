using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitleCorrectorWin
{
    class Corrector
    {
        int seconds, milliseconds;
        String filename;

        public Corrector(int seconds, int milliseconds, String filename)
        {
            this.seconds = seconds;
            this.milliseconds = milliseconds;
            this.filename = filename;
        }


        public Task correctAsync() {
            return Task.Run( () => {

                List<string> lines = readFile();


            });

        }

        public List<string> readFile()
        {
            List<String> lines = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();
                        lines.Add(line);
                    }
                }
                Console.Write("# lines" + lines.Count());
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return lines;
        }

    }
}
