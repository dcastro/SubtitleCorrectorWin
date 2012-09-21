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

            if (this.move == MoveAction.Backward)
                this.milliseconds = - this.milliseconds;

            Console.WriteLine(move);
            Console.WriteLine(this.milliseconds);
        }


        public Task correctAsync() {
            return Task.Run( () => {

                List<string> lines = readFile();
                List<string> correctedLines = new List<string>();
                DateTime baseTimestamp = DateTime.ParseExact("00:00:00,000", format, null);
                string start = "", end = "";

                foreach (string line in lines)
                {
                    string correctedLine;

                    if (isTimestamp(line, ref start, ref end))
                    {
                        // correct timestamp
                        DateTime startDate = DateTime.ParseExact(start, format, null);
                        DateTime endDate = DateTime.ParseExact(end, format, null);

                        startDate = startDate.AddMilliseconds(milliseconds);
                        endDate = endDate.AddMilliseconds(milliseconds);

                        if (startDate < baseTimestamp)
                            startDate = baseTimestamp;
                        if (endDate < baseTimestamp)
                            endDate = baseTimestamp;

                        correctedLine = startDate.ToString(format) + " --> " + endDate.ToString(format);

                    }
                    else
                        correctedLine = line;

                    correctedLines.Add(correctedLine);
                }

                saveToFile(correctedLines);

                Console.Write("Done");

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
                using (StreamReader sr = new StreamReader(filename, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();
                        lines.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return lines;
        }

        private void saveToFile(List<string> correctedLines)
        {
            //make a backup
            File.Copy(filename, filename + ".baq");

            try
            {
                using (StreamWriter wr = new StreamWriter(filename))
                {
                    foreach (String correctedLine in correctedLines)
                    {
                        wr.WriteLine(correctedLine);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be written:");
                Console.WriteLine(e.Message);
            }
        }

    }
}
