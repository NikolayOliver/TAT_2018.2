using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
namespace Task_6_Json_Xml_parse
{
    class CheckingOnSpecialSymbols
    {
        string path;
        int index1, index2;
        StreamWriter file2 = new StreamWriter(@"c:\Users\User\Source\Repos\TAT_2018.2\Task_6_Json_Xml_parse\Task_6_Json_Xml_parse\XML.xml");
        List<string> inFileElements = new List<string>();
        public CheckingOnSpecialSymbols(string path)
        {
            this.path = path;
        }
        public void Check()
        {
            try
            {
                int count = 0;
                int countCurlyBraces = 0;
                string line;
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.IndexOf('{') != -1)
                        {
                            if (countCurlyBraces == 0)
                            {
                                InsertOpenClose(true, true);
                            }
                            else
                            {
                                InsertOpenClose(false, true);
                            }
                            countCurlyBraces++;
                        }
                        foreach (char c in line)
                        {
                            if (c == ',')
                            {
                                count++;
                            }
                        }
                        for (; count >= 0; count--)
                        {
                            index1 = line.IndexOf('"');
                            if (index1 != -1)
                            {
                                line = line.Remove(index1, 1);

                                index2 = line.IndexOf('"');
                                if (index2 != -1)
                                {
                                    inFileElements.Add(line.Substring(index1, index2 - index1));
                                    line = line.Remove(index2, 1);
                                }
                                index1 = line.IndexOf(':');
                                if (index1 != -1)
                                {
                                    line = line.Remove(index1, 1);
                                }
                                if (count >= 1)
                                {
                                    if (line.IndexOf('"') != -1)
                                    {
                                        inFileElements.Add(line.Substring(index1 + 1, line.IndexOf(',') - 2 - index1));
                                        line = line.Remove(line.IndexOf('"'), 1);
                                        line = line.Remove(line.IndexOf('"'), 1);
                                    }
                                    else
                                    {
                                        inFileElements.Add(line.Substring(index1, line.IndexOf(',') - index1));
                                    }
                                }
                                else
                                {
                                    if (index1 != -1)
                                    {
                                        if (line.IndexOf('}') != -1)
                                        {
                                            inFileElements.Add(line.Substring(index1, line.IndexOf('}') - index1));
                                        }
                                        else
                                        {
                                            inFileElements.Add(line.Substring(index1));
                                        }
                                    }
                                }
                                if (inFileElements.Count() == 2)
                                {
                                    file2.WriteLine("<{0}>{1}</{0}>", inFileElements[0], inFileElements[1]);
                                    inFileElements.RemoveRange(0, 2);
                                }
                                else
                                {
                                    file2.WriteLine(inFileElements[0]);
                                    inFileElements.RemoveRange(0, 1);
                                }
                                

                            }
                            else
                                break;
                        }
                        if (line.IndexOf('}') != -1)
                        {
                            if (countCurlyBraces == 1)
                            {
                                InsertOpenClose(true, false);
                            }
                            else
                            {
                                InsertOpenClose(false, false);
                            }
                            countCurlyBraces++;
                        }
                       
                    }
                }

            }
            finally
            {
                file2.Close();
            }
        }
        public void InsertOpenClose(bool rootORItem, bool openClose)
        {
            if(rootORItem == true && openClose == true)
            {
                file2.WriteLine("<root>");
            }
            if (rootORItem == true && openClose == false)
            {
                file2.WriteLine("</root>");
            }
            if (rootORItem == false && openClose == false)
            {
                file2.WriteLine("</item>");
            }
            if (rootORItem == false && openClose == true)
            {
                file2.WriteLine("<item>");
            }
        }
      
    }
}
