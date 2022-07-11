using System.IO;
using tlumacz.Translation;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace tlumacz.File
{
    class File
    {
        void CreataFile(string path)
        {
            if (System.IO.File.Exists(path))
            {
                try
                {
                    System.IO.File.Delete(path);
                }
                catch
                {
                    MessageBox.Show("Należy zamknąć plik nie można obsłużyć");
                    return;
                }
                
            }
            StreamWriter sw;
            try
            {
                sw = System.IO.File.CreateText(path);
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Nie udało się utworzyć pliku");
            }
        }
        public bool PriperFile(string RedPath,string SavePath)
        {
            string getNameFile = null;
            Checked check = new Checked();
            if (check.CheckPath(RedPath, SavePath) == true)
            {
                if (check.CheckExtension(RedPath) == true)
                {
                    CreataFile(SavePath);
                    return true;

                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public string [] Read(string path)
        {
            try
            {
                return System.IO.File.ReadAllLines(path);
            }
            catch
            {
                MessageBox.Show("Wskazany plik jest otwarty lub nie istnieje");
            }
            return null;
        }
        public void ApendText(string path, List<string> PriperNewDocument)
        {
            foreach(string s in PriperNewDocument)
            {
                try
                {
                    System.IO.File.AppendAllText(path, s);
                    System.IO.File.AppendAllText(path, "\n");
                }
                catch
                {
                    return;
                }
            }

        }
    }
}
