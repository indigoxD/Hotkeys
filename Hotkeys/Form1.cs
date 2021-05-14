using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotkeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // here is where you are going to put your hot keys 

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Control A

            if(e.Control == true && e.KeyCode == Keys.A)
            {
                MessageBox.Show("Ctrl A");
            }

            // Control B

            if (e.Control == true && e.KeyCode == Keys.B)
            {
                MessageBox.Show("Ctrl B");
            }

            // Control C

            if (e.Control == true && e.KeyCode == Keys.C)
            {
                MessageBox.Show("Ctrl C");
            }

            // Control D

            if (e.Control == true && e.KeyCode == Keys.D)
            {
                MessageBox.Show("Ctrl D");
            }

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
