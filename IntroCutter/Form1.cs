using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IntroCutter
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            debugText.AppendText(Environment.NewLine);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pathSelectButton_Click(object sender, EventArgs e)
        {
            inFolderBrowser.ShowDialog();
            pathText.Text = inFolderBrowser.SelectedPath;
            DirectoryInfo dirInfo = new DirectoryInfo(inFolderBrowser.SelectedPath);
            string[] patterns;
            if (patternText.Text.Contains(Char.Parse(",")))
            {
                char[] sep = new char[] { Char.Parse(",") };
                patterns = patternText.Text.Split(sep);
                
            }
            else
            {
                patterns = new string[] { patternText.Text };                
            }
            // Efficient way of trimming each of the detect patterns
            patterns = patterns.Select(pattern => pattern.Trim()).ToArray();
            IntroCutter cutter = new IntroCutter();
            foreach (String pattern in patterns)
            {
                this.log("pattern: " + pattern);
                IEnumerable<FileInfo> fileList = dirInfo.EnumerateFiles(pattern, SearchOption.TopDirectoryOnly);
                this.log("Files in path: ");
                foreach (FileInfo fileInfo in fileList)
                {
                    this.log(fileInfo.FullName);
                }
            }                        
        }

        

        public void log(String message)
        {
            debugText.AppendText(message + Environment.NewLine);

        }
        
    }
}
