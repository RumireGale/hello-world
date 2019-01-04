using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Guide
    {
        public Dictionary<string, int> CC = new Dictionary<string, int>();
        public Dictionary<string, int> EW = new Dictionary<string, int>();
        public Dictionary<string, int> NS = new Dictionary<string, int>();
        public Dictionary<string, int> NE = new Dictionary<string, int>();
        public Dictionary<string, int> DT = new Dictionary<string, int>();
        public Dictionary<string, int> CG = new Dictionary<string, int>();
        Lines lines = new Lines();

        public void InitializeLines()
        {
            string[] lines = System.IO.File.ReadAllLines(@"MRT.txt");
            int stnNo;
            for (int i = 0; i < lines.Length; i++)
            {
                // Insert CC Line
                if (lines[i].Contains("CC") && lines[i].Any(char.IsDigit))
                {
                    stnNo = int.Parse(lines[i].Substring(2));
                    CC.Add(lines[i + 1], stnNo);
                }

                // Insert EW Line
                if (lines[i].Contains("EW") && lines[i].Any(char.IsDigit))
                {
                    stnNo = int.Parse(lines[i].Substring(2));
                    EW.Add(lines[i + 1], stnNo);
                }

                // Insert NS Line
                if (lines[i].Contains("NS") && lines[i].Any(char.IsDigit))
                {
                    stnNo = int.Parse(lines[i].Substring(2));
                    NS.Add(lines[i + 1], stnNo);
                }

                // Insert NE Line
                if (lines[i].Contains("NE") && lines[i].Any(char.IsDigit))
                {
                    stnNo = int.Parse(lines[i].Substring(2));
                    NE.Add(lines[i + 1], stnNo);
                }

                // Insert DT Line
                if (lines[i].Contains("DT") && lines[i].Any(char.IsDigit))
                {
                    stnNo = int.Parse(lines[i].Substring(2));
                    DT.Add(lines[i + 1], stnNo);
                }

                // Insert CG Line
                if (lines[i].Contains("CG") && lines[i].Any(char.IsDigit))
                {
                    stnNo = int.Parse(lines[i].Substring(2));
                    CG.Add(lines[i + 1], stnNo);
                }
            }
        }

        // Main method
        public virtual string Guidance(string start, string end)
        {
            InitializeLines();
            lines.Start_Station = start;
            lines.End_Station = end;
            int startLine = FindLine(lines.Start_Station), endLine = FindLine(lines.End_Station);

            if (startLine == 0 || !checkStation(lines.Start_Station))
            {
                return "Error1";
            } else
            {
                if (endLine == 0 || !checkStation(lines.End_Station))
                {
                    return "Error2";
                } else
                {
                    if (lines.Start_Station == lines.End_Station)
                    {
                        return "Error3";
                    }
                }
            }

            string msg = "";
            int counter = 999, counter2 = 999;
            int startnumber = 0, endnumber = 0;
            bool check = false;

            //Checks for every line that the starting station belongs to
            for (int i = 0; i < FindLine(lines.Start_Station).ToString().Length; i++)
            {
                startnumber = startLine % 10;
                startLine /= 10;

                //Checks for every line the ending station belongs to
                for (int j = 0; j < FindLine(lines.End_Station).ToString().Length; j++)
                {
                    endnumber = endLine % 10;
                    endLine /= 10;

                    // If both stations belong to the same line
                    if (startnumber == endnumber)
                    {
                        counter2 = SingleLineCounter(startnumber, lines.Start_Station, lines.End_Station);
                        if (counter > counter2) {
                            msg = SingleLine(startnumber, lines.Start_Station, lines.End_Station);
                            counter = counter2;
                            check = true;
                            break;
                        }
                    }
                    else
                    {
                        msg = "Error4";
                    }
                }

                endLine = FindLine(lines.End_Station);
                if (check)
                {
                    break;
                }
            }
            return msg;
        }

        // Side methods

        // Number for line(s) which station is in
        public int FindLine(string station)
        {
            int belongs = 0;
            foreach (KeyValuePair<string, int> pair in CC)
            {
                if (station == pair.Key)
                {
                    belongs = belongs * 10 + 1;
                }
            }
            foreach (KeyValuePair<string, int> pair in EW)
            {
                if (station == pair.Key)
                {
                    belongs = belongs * 10 + 2;
                }
            }
            foreach (KeyValuePair<string, int> pair in NS)
            {
                if (station == pair.Key)
                {
                    belongs = belongs * 10 + 3;
                }
            }
            foreach (KeyValuePair<string, int> pair in NE)
            {
                if (station == pair.Key)
                {
                    belongs = belongs * 10 + 4;
                }
            }
            foreach (KeyValuePair<string, int> pair in DT)
            {
                if (station == pair.Key)
                {
                    belongs = belongs * 10 + 5;
                }
            }
            foreach (KeyValuePair<string, int> pair in CG)
            {
                if (station == pair.Key)
                {
                    belongs = belongs * 10 + 6;
                }
            }
            return belongs;
        }

        // Checks if station inputted belongs to any lines / Checks if station is real
        public bool checkStation(string input)
        {
            bool check = false;
            foreach (KeyValuePair<string, int> pair in CC)
            {
                if (input == pair.Key)
                {
                    check = true;
                }
            }

            foreach (KeyValuePair<string, int> pair in EW)
            {
                if (input == pair.Key)
                {
                    check = true;
                }
            }

            foreach (KeyValuePair<string, int> pair in NE)
            {
                if (input == pair.Key)
                {
                    check = true;
                }
            }

            foreach (KeyValuePair<string, int> pair in NS)
            {
                if (input == pair.Key)
                {
                    check = true;
                }
            }

            foreach (KeyValuePair<string, int> pair in DT)
            {
                if (input == pair.Key)
                {
                    check = true;
                }
            }

            foreach (KeyValuePair<string, int> pair in CG)
            {
                if (input == pair.Key)
                {
                    check = true;
                }
            }

            return check;
        }

        // If both station belongs to a single line
        public string SingleLine(int number, string start, string end)
        {
            int starter = 0, ender = 0;
            string msg = "";
            switch (number)
            {
                case 1:
                    foreach (KeyValuePair<string, int> pair in CC)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                            msg = "CC" + starter + "\t" + pair.Key;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }

                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in CC)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nCC" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in CC)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nCC" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }

                    break;

                case 2:
                    foreach (KeyValuePair<string, int> pair in EW)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                            msg = "EW" + starter + "\t" + pair.Key;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in EW)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nEW" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in EW)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nEW" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }

                    break;

                case 3:
                    foreach (KeyValuePair<string, int> pair in NS)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                            msg = "NS" + starter + "\t" + pair.Key;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in NS)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nNS" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in NS)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nNS" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }

                    break;

                case 4:
                    foreach (KeyValuePair<string, int> pair in NE)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                            msg = "NE" + starter + "\t" + pair.Key;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in NE)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nNE" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in NE)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nNE" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }

                    break;

                case 5:
                    foreach (KeyValuePair<string, int> pair in DT)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                            msg = "DT" + starter + "\t" + pair.Key;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in DT)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nDT" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in DT)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nDT" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }

                    break;

                case 6:
                    foreach (KeyValuePair<string, int> pair in CG)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                            msg = "CG" + starter + "\t" + pair.Key;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in CG)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nCG" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in CG)
                            {
                                if (i == pair.Value)
                                {
                                    msg = msg + "->\r\nCG" + i + "\t" + pair.Key;
                                }
                            }
                        }
                    }

                    break;
            }
            return msg;
        }
        public int SingleLineCounter(int number, string start, string end)
        {
            int counter = 0;
            int starter = 0;
            int ender = 0;
            switch (number)
            {
                case 1:
                    foreach (KeyValuePair<string, int> pair in CC)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in CC)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in CC)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    break;

                case 2:
                    foreach (KeyValuePair<string, int> pair in EW)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in EW)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in EW)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    break;

                case 3:
                    foreach (KeyValuePair<string, int> pair in NS)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in NS)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in NS)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    break;
                case 4:
                    foreach (KeyValuePair<string, int> pair in NE)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in NE)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in NE)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    break;
                case 5:
                    foreach (KeyValuePair<string, int> pair in DT)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in DT)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in DT)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    break;
                case 6:
                    foreach (KeyValuePair<string, int> pair in CG)
                    {
                        if (start == pair.Key)
                        {
                            starter = pair.Value;
                        }

                        if (end == pair.Key)
                        {
                            ender = pair.Value;
                        }
                    }
                    if (ender > starter)
                    {
                        for (int i = starter + 1; i <= ender; i++)
                        {
                            foreach (KeyValuePair<string, int> pair in CG)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = starter - 1; i >= ender; i--)
                        {
                            foreach (KeyValuePair<string, int> pair in CG)
                            {
                                if (i == pair.Value)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                    break;
            }
            return counter;
        }

        // If requires 1 transfer
        //public string SingleTransfer(int startingLine, int endingLine)
        //{
        //    int startnumber = 0;
        //    int endnumber = 0;
        ////    string msg = "";

        //    // for every line that starting station belongs to
        //    for (int i = 0; i<startingLine.ToString().Length; i++)
        //    {
        //        startnumber = startingLine % 10;
        //        startingLine /= 10;

        //        // for every line that ending station belongs to
        //        for (int j = 0; j<endingLine.ToString().Length; j++)
        //        {
        //            endnumber = endingLine % 10;
        //            endingLine /= 10;

        //            // find a station that belongs to both lines (the transfer station)
        //            string nameofstation = "";
        //            switch (startnumber)
        //            {
        //                case 0:
        //                    return "Error5";
        //                case 1:
        //                    foreach (KeyValuePair<string, int> pair in CC)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station){
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 2:
        //                    foreach (KeyValuePair<string, int> pair in EW)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 3:
        //                    foreach (KeyValuePair<string, int> pair in NS)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 4:
        //                    foreach (KeyValuePair<string, int> pair in NE)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 5:
        //                    foreach (KeyValuePair<string, int> pair in DT)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 6:
        //                    foreach (KeyValuePair<string, int> pair in CG)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //            }
        //            if (lines.Transfer_Station == "No Link")
        //            {
        //                return "Error3";
        //            }
        //            else
        //            {
        //                msg = SingleLine(startnumber, lines.Start_Station, lines.Transfer_Station);
        //                msg += "\r\nTransfer here\r\n";
        //                msg += SingleLine(endnumber, lines.Transfer_Station, lines.End_Station);
        //            }
        //        }
        //    }
        //    return msg;
        //}
        //public int SingleTransferCounter(int startingLine, int endingLine)
        //{
        //    int startnumber = 0, endnumber = 0, counter = 0;

        //    // for every line that starting station belongs to
        //    for (int i = 0; i < startingLine.ToString().Length; i++)
        //    {
        //        startnumber = startingLine % 10;
        //        startingLine /= 10;

        //        // for every line that ending station belongs to
        //        for (int j = 0; j < endingLine.ToString().Length; j++)
        //        {
        //            endnumber = endingLine % 10;
        //            endingLine /= 10;

        //            // find a station that belongs to both lines (the transfer station)
        //            string nameofstation = "";
        //            switch (startnumber)
        //            {
        //                case 0:
        //                    return "Error5";
        //                case 1:
        //                    foreach (KeyValuePair<string, int> pair in CC)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 2:
        //                    foreach (KeyValuePair<string, int> pair in EW)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 3:
        //                    foreach (KeyValuePair<string, int> pair in NS)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 4:
        //                    foreach (KeyValuePair<string, int> pair in NE)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 5:
        //                    foreach (KeyValuePair<string, int> pair in DT)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //                case 6:
        //                    foreach (KeyValuePair<string, int> pair in CG)
        //                    {
        //                        nameofstation = pair.Key;
        //                        lines.Transfer_Station = FindTransfer(endnumber, nameofstation);
        //                        if (nameofstation == lines.Transfer_Station)
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    break;
        //            }
        //            else
        //            {
                        
        //            }
        //        }
        //    }
        //    return counter;
        //}
    }
}

//Key
//CC is numbered 1
//EW is numbered 2
//NS is numbered 3
//NE is numbered 4
//DT is numbered 5
//CG is numbered 6