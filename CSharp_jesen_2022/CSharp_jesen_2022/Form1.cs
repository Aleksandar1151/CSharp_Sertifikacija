using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_jesen_2022
{
    public partial class Form1 : Form
    {
        public const string FILEPATH = "C:\\Users\\Kliker11\\OneDrive\\Desktop\\C# Projekti za odbranu\\";
        public Form1()
        {
            InitializeComponent();
           
        }


        private void dugme1Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FILEPATH + "p_danilo");
        }

        private void dugme2Klik(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FILEPATH + "p_dejan");
        }

        private void dugme3Klik(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FILEPATH + "p_luka");
        }

        private void dugme4Klik(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FILEPATH + "p_vanja");
        }

        private void dugme5Klik(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FILEPATH + "p_andrej");
        }
    }
}
