using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tlumacz.Translation
{
    class Translation
    {
        public List<string> PriperData(string[] csv)
        {
            List<string> PriperDataToChangeChars = new List<string>();
            List<string> otherData = new List<string>();
            foreach(string s in csv)
            {
                if (s == "")
                {
                    PriperDataToChangeChars.Add("\n");
                    otherData.Add("\n");
                }
                else
                {
                    string tmp = "";
                    int tmp1 = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        tmp += s[i];
                        if (s[i] == ';')
                        {
                            tmp1++;
                        }
                        if (tmp1 == 4)
                        {
                            PriperDataToChangeChars.Add(tmp);
                            tmp = "";
                            tmp1++;
                        }
                    }
                    otherData.Add(tmp);
                }
            }
            List<string> Chars=ChangeSymbol(PriperDataToChangeChars);
            return ConektionString(Chars, otherData);
        }
        public List<string>ConektionString(List<string> Chars, List<string> otherData)
        {
            List<string> String = new List<string>();
            for(int i=0;i< otherData.Count;i++)
            {
                if(Chars[i]=="\n")
                {
                    String.Add("\n");
                }
                else
                {
                    String.Add(Chars[i] + otherData[i]);
                }
            }
            return String;
        }
        public List<string>ChangeSymbol(List<string> PriperDataToChangeChars)
        {
            List<string> Symbol = new List<string>();
            Symbol.Add("code;");
            for(int i=1;i< PriperDataToChangeChars.Count;i++)
            {
                string tmp = "";
                int tmp1 = 0;
                int code = 0;
                bool BigLiter=false;
                bool PAlt=false;
                bool NumLock=false;
                foreach (char s in PriperDataToChangeChars[i])
                {
                    
                    if(s==';')
                    {
                        if(tmp1==0)
                        {
                            code = Convert.ToInt32(tmp);
                        }
                        if(tmp1==1)
                        {
                            BigLiter = Convert.ToBoolean(tmp);
                        }
                        if(tmp1==2)
                        {
                            NumLock= Convert.ToBoolean(tmp);
                        }
                        if (tmp1 == 3)
                        {
                            PAlt = Convert.ToBoolean(tmp);
                        }
                        tmp1++;
                        tmp = "";
                    }
                    else
                    {
                        tmp += s;
                    }
                }
                if (PriperDataToChangeChars[i] == "\n")
                {
                    Symbol.Add("\n");
                }
                else
                {
                    string symbol = Char(code, BigLiter, PAlt, NumLock);
                    Symbol.Add(symbol+";");
                }
            }
            return Symbol;
        }
        public string Char(int Numberbutton ,bool Bigliter, bool PAlt,bool NumLock)
        {
            string button = "";
            char chars = '\0';
            Dictionary dictionary = new Dictionary();


            if (Numberbutton >= 1 && Numberbutton <= 4)
            {
                button = dictionary.mause(Numberbutton);
            }
            else if (Numberbutton >= 37 && Numberbutton <= 40)
            {
                button = dictionary.arrow(Numberbutton);
            }
            else if (Numberbutton >= 48 && Numberbutton <= 57)
            {
                if (Bigliter == true)
                {
                    button = dictionary.ShiftNumber(Numberbutton);
                }
                else
                {
                    chars = (char)Numberbutton;
                    button = Convert.ToString(chars);
                }

            }
            else if (Numberbutton >= 65 && Numberbutton <= 90)
            {
                if (Bigliter == true && PAlt == true)
                {
                    button = dictionary.BigAltChar(Numberbutton);
                }
                else if (Bigliter == false && PAlt == true)
                {
                    button = dictionary.SmalAltChar(Numberbutton);
                }
                else if (Bigliter == false && PAlt == false)
                {
                    button = Convert.ToChar(Numberbutton + 32).ToString();
                }
                else
                {
                    button = Convert.ToChar(Numberbutton).ToString();
                }
            }
            else if (NumLock == true && (Numberbutton >= 96 && Numberbutton <= 111))
            {
                button = dictionary.NumLock(Numberbutton);
            }
            else if (Numberbutton >= 112 && Numberbutton <= 123)
            {
                button = dictionary.F(Numberbutton);
            }
            else if (Numberbutton >= 186 && Numberbutton <= 222)
            {
                if (Bigliter == true)
                {
                    button = dictionary.ShiftOtherButon(Numberbutton);
                }
                else
                {
                    button = dictionary.OtherButon(Numberbutton);
                }

            }
            else
            {
                button = dictionary.RareButtons(Numberbutton);
            }
            if (button == null)
            {
                button = dictionary.button(Numberbutton);
            }
            return button;
        }

    }
}
