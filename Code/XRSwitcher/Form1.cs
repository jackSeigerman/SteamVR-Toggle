using System.CodeDom;
using System;
using System.IO;
using System.Diagnostics;

namespace XRSwitcher
{
    public partial class Form1 : Form
    {
        //temp
        public string var = "HelloWorld";

        // Paths to the SteamVR folder and its renamed version
        private static string sourcePath = @"C:\Program Files (x86)\Steam\steamapps\common\SteamVR";
        private static string destinationPath = @"C:\Program Files (x86)\Steam\steamapps\common\SteamVR_";

        public Form1()
        {
            InitializeComponent();
            this.Text = "SteamVR Toggle";
            if (Directory.Exists(sourcePath))
            {

                label6.Text = "VR Mode";
            }
            else
            {
                label6.Text = "Desktop Mode";
            }
        }

        //upon hitting Button1 (the button labeled "desktop mode")
        private void button1_Click(object sender, EventArgs e)
        {
            //check if it will error out, as to not crash the program
            try
            {
                //if it wont error, change the name of the folder to "steamvr_"
                Directory.Move(sourcePath, destinationPath);
                label6.Text = "Desktop Mode";
            }
            //if it does error do nothing
            catch (Exception ex)
            {

            }

        }
        //upon hitting Button2 (the button labeled "vr mode")
        private void button2_Click(object sender, EventArgs e)
        {
            //check if it will error out, as to not crash the program
            try
            {
                //if it wont error, change the name of the folder to "steamvr"
                Directory.Move(destinationPath, sourcePath);
                label6.Text = "VR Mode";
            }
            //if it does error do nothing
            catch (Exception ex)
            {

            }

        }
        //dont worry about these yet
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            string steamPath = @"C:\Program Files (x86)\Steam\steamapps\common\SteamVR\bin\win64\vrstartup.exe";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = steamPath,
                UseShellExecute = true,
            };

            try
            {
                Process.Start(startInfo);
                Console.WriteLine("SteamVR launched successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to launch SteamVR: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
