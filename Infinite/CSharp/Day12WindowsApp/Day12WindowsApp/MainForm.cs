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
using System.Threading;

namespace Day12WindowsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello and Welcome to Windows Programming");
        }

        // the below event/method works synchronously

        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    // lblMessage.Text = txtName.Text;
        //    // label1.Visible = true;
        //    // txtName.Enabled = false;
        //    int z = CountCharacters();
        //    lblMessage.Text = "Processing file, Please wait.....";
        //    lblMessage.Text = z.ToString();
        //}

        //the below works asynchronously
        private async void btn1_Click(object sender, EventArgs e)
        {
            // lblMessage.Text = txtName.Text;
            // label1.Visible = true;
            // txtName.Enabled = false;
            Task<int> mytask = new Task<int>(CountCharacters);
            mytask.Start();
            lblMessage.Text = "Processing file, Please wait.....";
            txtName.Text = "Waiting for some work..";
            int z = await mytask;
            lblMessage.Text = z.ToString() +  " "+ "Characters Found in the File";
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            SecondForm sf = new SecondForm();
            sf.Show();
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader= new StreamReader("DataFile.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
    }
}
