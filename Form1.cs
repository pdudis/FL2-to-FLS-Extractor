using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL2_to_FLS
{

    public partial class Form1 : Form

    {

        public Form1()

        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIsClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = Properties.Resources.Intro;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            MyGlobals.userTempFolder = Path.GetTempPath();
            MyGlobals.extractTempFolder = MyGlobals.userTempFolder + @"fl2tofls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get FL2 file
                MyGlobals.filePath = openFileDialog1.FileName;

                string zExecPath = "7za.exe";
                try
                {
                    ProcessStartInfo pro = new ProcessStartInfo();
                    pro.WindowStyle = ProcessWindowStyle.Hidden;
                    pro.FileName = zExecPath;
                    pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", MyGlobals.filePath, MyGlobals.extractTempFolder);
                    Process x = Process.Start(pro);
                    x.WaitForExit();
                }
                catch (System.Exception Ex)
                {
                    //handle error
                    MessageBox.Show("Oh no! Something went wrong!");
                }
            }
            else
            {
                webBrowser1.DocumentText = Properties.Resources.Intro;
                return;
            }

            string showReleaseNotesFolder = MyGlobals.extractTempFolder + @"\ContentDescriptions";
            string[] getReleaseNotesHTML = Directory.GetFiles(showReleaseNotesFolder, "*.html");

            webBrowser1.Navigate(getReleaseNotesHTML[0]);
                       
            string dataImageFolder = MyGlobals.extractTempFolder + @"\DataImages";
            string[] getFLSFile = Directory.GetFiles(dataImageFolder);
            string destFLSPathAndName = Path.GetDirectoryName(MyGlobals.filePath) + @"\" + Path.GetFileName(getFLSFile[0]);

            try
            {
                File.Copy(getFLSFile[0], destFLSPathAndName, true);
            }
            catch (System.Exception Ex)
            {
                //handle error
                MessageBox.Show("Oh no! Something went wrong!");
                return;
            }

            MessageBox.Show("FLS file extracted successfully in folder" + Environment.NewLine + Path.GetDirectoryName(MyGlobals.filePath));

        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(MyGlobals.extractTempFolder))
            {
                Directory.Delete(MyGlobals.extractTempFolder, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            var myAboutBox = new AboutBox1();
            myAboutBox.Show();

        }

        private void donateBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.buymeacoffee.com/ADYsLjqfi");
        }
    }

    public static class MyGlobals
    {
        public static string filePath;
        public static string userTempFolder;
        public static string extractTempFolder;
    }



}
