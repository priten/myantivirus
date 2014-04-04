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
using System.IO.MemoryMappedFiles;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

public class streamreader { }

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int virus;
        //here i have defined the variable "virus" as an integer 
        string[] viruslist = new string[] { "30abd218790605c5882fcacf2fac1861", "f49eb02f70e6c17f72551b5c287f9889", "9e1c2f8106b932896bd4970520a884e6" };
       //the viruslist hase been delcared as a string and within it are md5 hashes which should be picked up by the program.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblfolderpath.Text = folderBrowserDialog1.SelectedPath;
            //this section of code allows the user to click the button and select file path
            //once it is selected it will then be shown in the lable below
            virus = 0;
            lblvirus.Text = virus.ToString();
            prgsbar.Value = (0);
            //sets the values of the progress bar to "0" 
            lstbox.Items.Clear();
            //this section indicates that there is no information in the list box



        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> search = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.*").ToList();
            //this line of code basically searched the directory within the system and goes through the selected path and goes through every character
            prgsbar.Maximum = search.Count;
            //the progress bar has been set to maximum and adds the count within the bar

            foreach (string item in search)
                //defining each strin item that have been put into the search.
            {
                MessageBox.Show(hashFile(item));
                //the message box opens showing the hash of the folder path
            }
        }

        private string hashFile(string loc)
            //function that returns the file as a md5 hash 
        {
            using (var md5 = MD5.Create())
            //get instance of md5
            {
                using (var stream = File.OpenRead(loc))
                //open file to md5
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-","").ToLower();
                    //returns the md5
                    //http://stackoverflow.com/questions/10520048/calculate-md5-checksum-for-a-file
                    //https://www.youtube.com/watch?v=jjN2VNY5w8g
                }
            }
        }
    }
}
