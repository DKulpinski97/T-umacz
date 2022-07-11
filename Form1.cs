using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tlumacz.Button;

namespace tlumacz
{
    public partial class Form1 : Form
    {
        FunctionButton functionButton = new FunctionButton();
        public Form1()
        {
            InitializeComponent();
        }

        private void FilePath_Click(object sender, EventArgs e)
        {
            var path = new OpenFileDialog();
            functionButton.TakePathRead(path, PathToRead);

        }

        private void SavePath_Click(object sender, EventArgs e)
        {
            var path=new FolderBrowserDialog();
            functionButton.TakePathSave(path, PathToSave);

        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            if (PathToRead.Text != "" && PathToSave.Text != "")
            {
                string savePath1 = PathToSave.Text;
                //Scierzka odczytanego pliku
                string path = PathToRead.Text;
                //Tworzenie nowej scierzki
                string tmp = "";
                int lenghData = 0;
                for (int i = path.Length - 1; i > 0; i--)
                {
                    if (path[i] == '\\')
                    {
                        break;
                    }
                    lenghData++;

                }
                for (int i = path.Length - lenghData; i < path.Length - 4; i++)
                {
                    tmp += path[i];
                }
                string newName = "\\" + tmp + " T.csv";

                savePath1 += newName;
                functionButton.Translation(path, savePath1);
            }
            else
            {
                MessageBox.Show("Nie wybrano miejsca zapisu lub scierzki do pliku");
                return;
            }
        }
    }
}
