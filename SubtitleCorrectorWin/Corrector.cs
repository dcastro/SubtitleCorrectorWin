using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SubtitleCorrectorWin
{
    class Corrector
    {
        int milliseconds;
        string filename;
        const string format = "HH:mm:ss,fff";
        MoveAction move;

        public Corrector(int seconds, int milliseconds, string filename, MoveAction move)
        {
            this.milliseconds = milliseconds + (seconds * 1000);
            this.filename = filename;
            this.move = move;
        }


        public Task correctAsync() {
            return Task.Run( () => {

                List<string> lines = readFile();
                string start = "", end = "";

                foreach (string line in lines)
                {
                    if (isTimestamp(line, ref start, ref end))
                    {
                        DateTime startDate = DateTime.ParseExact(start, format, null);
                        DateTime endDate = DateTime.ParseExact(end, format, null);

                        //Console.WriteLine("date: " + startDate + " " + endDate + " " + move);
                    }
                }

            });
        }

        private bool isTimestamp(string line, ref string start, ref string end)
        {
            string pattern = @"^(\d{2}:\d{2}:\d{2},\d{3}) --> (\d{2}:\d{2}:\d{2},\d{3})";

            Regex r = new Regex(pattern);
            Match match = r.Match(line);

            if (match.Success)
            {
                //start
                Group group = match.Groups[1];
                CaptureCollection cc = group.Captures;

                foreach (Capture capture in cc)
                {
                    start = capture.ToString();
                }

                //end
                group = match.Groups[2];
                cc = group.Captures;

                foreach (Capture capture in cc)
                {
                    end = capture.ToString();
                }

                return true;
            }
            
            return false;
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
