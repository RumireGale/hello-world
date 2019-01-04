using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Transfer : Guide
    {
        public string Transfer_Station
        {
            get;
            set;
        }

        Lines lines = new Lines();
        public override string Guidance(string start, string end)
        {
            InitializeLines();
            lines.Start_Station = start;
            lines.End_Station = end;
            int startLine = FindLine(lines.Start_Station), endLine = FindLine(lines.End_Station);
            bool changicheck = CheckChangi(startLine, endLine), changicheck2 = CheckChangi2(startLine, endLine);
            int counter = 999;
            int startnumber = 0, endnumber = 0;
            string msg = "";
            if (changicheck || changicheck2)
            {
                startLine = FindLine(lines.Start_Station);
                endLine = FindLine(lines.End_Station);
            }

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

                    // If both stations are connected by 1 transfer
                    string nameofstation = "";
                    switch (startnumber)
                    {
                        case 1:
                            foreach (KeyValuePair<string, int> pair in CC)
                            {
                                nameofstation = pair.Key;
                                FindTransfer(startnumber, endnumber, nameofstation, counter);
                            }
                            break;

                        case 2:
                            foreach (KeyValuePair<string, int> pair in EW)
                            {
                                nameofstation = pair.Key;
                                FindTransfer(startnumber, endnumber, nameofstation, counter);
                            }
                            break;

                        case 3:
                            foreach (KeyValuePair<string, int> pair in NS)
                            {
                                nameofstation = pair.Key;
                                FindTransfer(startnumber, endnumber, nameofstation, counter);
                            }
                            break;

                        case 4:
                            foreach (KeyValuePair<string, int> pair in NE)
                            {
                                nameofstation = pair.Key;
                                FindTransfer(startnumber, endnumber, nameofstation, counter);
                            }
                            break;

                        case 5:
                            foreach (KeyValuePair<string, int> pair in DT)
                            {
                                nameofstation = pair.Key;
                                FindTransfer(startnumber, endnumber, nameofstation, counter);
                            }
                            break;

                        case 6:
                            foreach (KeyValuePair<string, int> pair in CG)
                            {
                                nameofstation = pair.Key;
                                FindTransfer(startnumber, endnumber, nameofstation, counter);
                            }
                            break;
                    }
                    if (Transfer_Station != lines.End_Station || Transfer_Station != lines.Start_Station)
                    {
                        if (changicheck == false || !changicheck2 == false)
                        {
                            msg = SingleLine(startnumber, lines.Start_Station, Transfer_Station);
                            msg += "\r\n---------------------\r\nTransfer here\r\n---------------------\r\n";
                            msg += SingleLine(endnumber, Transfer_Station, lines.End_Station);
                        }
                        else
                        {
                            if (endnumber != 5)
                            {
                                if (start.Equals("Changi Airport"))
                                {
                                    msg = StartChangi();
                                    msg += SingleLine(startnumber, lines.Start_Station, Transfer_Station);
                                    msg += "\r\n---------------------\r\nTransfer here\r\n---------------------\r\n";
                                    msg += SingleLine(endnumber, Transfer_Station, lines.End_Station);
                                }
                                else
                                {
                                    msg = SingleLine(startnumber, lines.Start_Station, Transfer_Station);
                                    msg += "\r\n---------------------\r\nTransfer here\r\n---------------------\r\n";
                                    msg += SingleLine(endnumber, Transfer_Station, lines.End_Station);
                                    msg += EndChangi();
                                }
                            } else
                            {
                                if (start.Equals("Changi Airport"))
                                {
                                    msg = StartChangi();
                                    msg += SingleLine(startnumber, lines.Start_Station, lines.End_Station);
                                }
                                else
                                {
                                    msg = SingleLine(startnumber, lines.Start_Station, lines.End_Station);
                                    msg += EndChangi();
                                }
                            }
                        }
                    }
                    endLine = FindLine(lines.End_Station);
                }
            }
            return msg;
        } 

        // Find Transfer station
        public void FindTransfer(int start, int end, string name, int counter)
        {
            int counter2 = 0;
            string transfer = "";
            switch (end)
            {
                case 1:
                    foreach (KeyValuePair<string, int> pair in CC)
                    {
                        if (name == pair.Key)
                        {
                            transfer = pair.Key;
                            counter2 = SingleLineCounter(start, lines.Start_Station, transfer);
                            counter2 += SingleLineCounter(end, transfer, lines.End_Station);
                            if (counter > counter2)
                                Transfer_Station = transfer;
                        }
                    }
                    break;

                case 2:
                    foreach (KeyValuePair<string, int> pair in EW)
                    {
                        if (name == pair.Key)
                        {
                            transfer = pair.Key;
                            counter2 = SingleLineCounter(start, lines.Start_Station, transfer);
                            counter2 += SingleLineCounter(end, transfer, lines.End_Station);
                            if (counter > counter2)
                                Transfer_Station = transfer;
                        }
                    }
                    break;

                case 3:
                    foreach (KeyValuePair<string, int> pair in NS)
                    {
                        if (name == pair.Key)
                        {
                            transfer = pair.Key;
                            counter2 = SingleLineCounter(start, lines.Start_Station, transfer);
                            counter2 += SingleLineCounter(end, transfer, lines.End_Station);
                            if (counter > counter2)
                                Transfer_Station = transfer;
                        }
                    }
                    break;

                case 4:
                    foreach (KeyValuePair<string, int> pair in NE)
                    {
                        if (name == pair.Key)
                        {
                            transfer = pair.Key;
                            counter2 = SingleLineCounter(start, lines.Start_Station, transfer);
                            counter2 += SingleLineCounter(end, transfer, lines.End_Station);
                            if (counter > counter2)
                                Transfer_Station = transfer;
                        }
                    }
                    break;

                case 5:
                    foreach (KeyValuePair<string, int> pair in DT)
                    {
                        if (name == pair.Key)
                        {
                            transfer = pair.Key;
                            counter2 = SingleLineCounter(start, lines.Start_Station, transfer);
                            counter2 += SingleLineCounter(end, transfer, lines.End_Station);
                            if (counter > counter2)
                                Transfer_Station = transfer;
                        }
                    }
                    break;

                case 6:
                    foreach (KeyValuePair<string, int> pair in CG)
                    {
                        if (name == pair.Key)
                        {
                            transfer = pair.Key;
                            counter2 = SingleLineCounter(start, lines.Start_Station, transfer);
                            counter2 += SingleLineCounter(end, transfer, lines.End_Station);
                            if (counter > counter2)
                                Transfer_Station = transfer;
                        }
                    }
                    break;
            }
        }

        // If starting or ending station belongs to Changi Airport
        public bool CheckChangi(int start, int end)
        {
            if (lines.Start_Station == "Changi Airport" && !start.ToString().Contains("5"))
            {
                lines.Start_Station = "Expo";
                return true;
            }
            return false;
        }
        public bool CheckChangi2(int start, int end)
        {
            if (lines.End_Station == "Changi Airport" && !end.ToString().Contains("5"))
            {
                lines.End_Station = "Expo";
                return true;
            }
            return false;
        }
        public string StartChangi()
        {
            return "CG2\tChangi Airport->\r\nCG1\tExpo\r\n---------------------\r\nTransfer here\r\n---------------------\r\n";
        }
        public string EndChangi()
        {
            return "\r\n---------------------\r\nTransfer here\r\n---------------------\r\nCG1\tExpo->\r\nCG2\tChangi Airport";
        }
    }
}


//Key
//CC is numbered 1
//EW is numbered 2
//NS is numbered 3
//NE is numbered 4
//DT is numbered 5
//CG is numbered 6