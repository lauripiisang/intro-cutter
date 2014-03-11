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
using System.Diagnostics;

namespace IntroCutter
{
    
    public partial class Form1 : Form
    {
        private Process ffmpeg;
        private bool ffmpeg_initialized = false;
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

        private void selectSourceVideo_Click(object sender, EventArgs e)
        {
            sourceVideoDialog.ShowDialog();
            string sourceVideoFileName = sourceVideoDialog.FileName;            
            string safeFileName = sourceVideoDialog.SafeFileName;
            sourceVideoName.Text = sourceVideoFileName;

            Process ffmpeg = this.getFFmpeg();
            string standardArguments = ffmpeg.StartInfo.Arguments;
            string dynamicArguments = "-i {0} " + standardArguments + " -r {1} {2}";
            
            string sourceVideoFrameRate = "3";
            string ourTempDirectory = Path.GetTempPath() + "introcutter\\" + safeFileName + "\\";
            string sourceBitmapOutput = ourTempDirectory + "src-%03d.bmp";

            if (!Directory.Exists(ourTempDirectory))
                Directory.CreateDirectory(ourTempDirectory);

            ffmpeg.StartInfo.Arguments =  String.Format(dynamicArguments, 
                sourceVideoFileName, 
                sourceVideoFrameRate,
                sourceBitmapOutput
                );
            ffmpeg.Start();
            ffmpeg.WaitForExit();
            

            //ffmpeg logs everything to stderr, really weird like that. ExitCode checking still works, though.
            string errors = ffmpeg.StandardError.ReadToEnd();


            if (ffmpeg.ExitCode != 0)
            {
                this.log("FFMPEG ran into an ERROR, look for it here: " + errors);
            }
            else
            {
                this.log("FFMPEG chopped source successfully. Command ran: " + ffmpeg.StartInfo.Arguments);
            }

            ffmpeg.StartInfo.Arguments = standardArguments;

             
        }
        
        private Process getFFmpeg()
        {
            if (this.ffmpeg_initialized)
                return this.ffmpeg;

            Process ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = Application.StartupPath + "\\vendor\\ffmpeg\\bin\\ffmpeg.exe";
            ffmpeg.StartInfo.CreateNoWindow = false;
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.RedirectStandardError = true;
            ffmpeg.StartInfo.RedirectStandardOutput = true;
            ffmpeg.StartInfo.Arguments = "-s 100x100 -ss 00:00:00 -to 00:00:50 -f image2";

            this.ffmpeg_initialized = true;
            this.ffmpeg = ffmpeg;
            return ffmpeg;
        }
    }
}
