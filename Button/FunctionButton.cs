using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tlumacz.Translation;
using tlumacz.File;

namespace tlumacz.Button
{
    public class FunctionButton
    {
        public string TakePathRead(OpenFileDialog Path,TextBox PathToRead)
        {
            string tmp = null;
            if (Path.ShowDialog() == DialogResult.OK)
            {
                //Wyświetlanie plikow w folderze
                Path.Filter = "Text files(*.tex)|*.text|All files(*.*)|*.*";
                PathToRead.Text = Path.FileName;
                tmp = Path.FileName;
            }
            return tmp;
        }
        public string TakePathSave(FolderBrowserDialog Path, TextBox PathToSave)
        {
            string tmp = null;
            DialogResult result = Path.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(Path.SelectedPath))
            {
                PathToSave.Text = Path.SelectedPath;
            }
            return Path.SelectedPath;
        }
        public void Translation(string RedPath, string SavePath)
        {
            
            File.File file = new File.File();
            Checked check = new Checked();
            if (file.PriperFile(RedPath, SavePath) == true)
            {
                string[] csv = file.Read(RedPath);
                if (csv == null)
                {
                    return;
                }
                string getNameFile;
                List<string> PriperNewDocument = new List<string>();
                getNameFile = check.CheckName(RedPath);
                tlumacz.Translation.Translation translation = new Translation.Translation();
                PriperNewDocument=translation.PriperData(csv);
                
                    file.ApendText(SavePath, PriperNewDocument);
                
                MessageBox.Show("Plik został przetworzony i zapisany w wskazanym miejscu z dodaną literą T");
            }

        }
    }
}
