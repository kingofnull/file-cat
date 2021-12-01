using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCat
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {


            string dirPath = Environment.ExpandEnvironmentVariables("%userprofile%\\Desktop");
            DirectoryInfo dinfo = new DirectoryInfo(dirPath);
            FileInfo[] files = dinfo.GetFiles("*");
            resultLst.Items.Clear();
            List<String> list = new List<string>();


            foreach (FileInfo file in files)
            {

                if (new Regex("^@").IsMatch(file.Name))
                {
                    continue;
                }


                if (file.Extension == ".lnk")
                {
                    continue;
                }

                if (file.Name=="desktop.ini") {
                    continue;
                }

                if (file.FullName == System.Reflection.Assembly.GetEntryAssembly().Location)
                {
                    continue;
                }


                String tagrgetDir;

                if (file.Extension == "")
                {
                    tagrgetDir = dirPath + "\\Folders\\Others";
                }
                else
                {
                    tagrgetDir = dirPath + "\\Folders\\" + file.Extension.Substring(1);
                }

                if (!Directory.Exists(tagrgetDir))
                {
                    Directory.CreateDirectory(tagrgetDir);
                }

                String targetFile = tagrgetDir + "\\" + file.Name;

                if (File.Exists(targetFile))
                {
                    targetFile = tagrgetDir + "\\" +Path.GetFileNameWithoutExtension(targetFile) + "_" + new Random().Next(1000) + file.Extension;
                    //MessageBox.Show(targetFile);
                    //return;
                }

                try
                {
                    File.Move(file.FullName, targetFile);
                }
                catch (IOException ioe)
                {
                    MessageBox.Show($"`{file.Name}` {ioe.Message}");
                }


                //MessageBox.Show(file.FullName);

                resultLst.Items.Add(file.Name);
                list.Add(file.Name);
            }
        }
    }
}
