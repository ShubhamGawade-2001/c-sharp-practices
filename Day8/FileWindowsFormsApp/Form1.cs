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

namespace FileWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"F:\try\newdir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Create(@"F:\try\new.txt");
            FileInfo f1 = new FileInfo(@"F:\try\new.txt");
            MessageBox.Show("file with name = "+f1.Name);
        }
    }
}
