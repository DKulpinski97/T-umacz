using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tlumacz.Translation
{
    public class Checked
    {
        public bool CheckPath(string Readpath,string SavePath)
        {
            if(Readpath!=null && SavePath!=null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Nie wybrano przynajmniej jednej z ścieżek proszę o wybranie");
                return false;
            }
        }
        public bool CheckExtension(string Readpath)
        {
            
            string extension = null;
            for(int i= Readpath.Length-1; i>0;i--)
            {
                if(Readpath[i]=='.')
                {
                    break;
                }
                else
                {
                    extension += Readpath[i];
                }
            }
            //Odwracanie strniga
            extension = ReviersArryCharToString(extension);
            if(extension=="csv")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Odczytywany plik nie ma rozszerzenia csv");
                return false;
            }
        }
         string ReviersArryCharToString(string str)
        {

            
            char[] charExtension = str.ToCharArray();
            Array.Reverse(charExtension);
            return new string(charExtension);
           
        }
        public string CheckName(string Readpath)
        {

            string name = null;
            for (int i = Readpath.Length - 1; i > 0; i--)
            {
                if (Readpath[i] == '\\')
                {
                    break;
                }
                else
                {
                    name += Readpath[i];
                }
            }
            name += '\\';
            return ReviersArryCharToString(name);
            
        }
    }
}
