using SE4FormApplication.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE4FormApplication
{
    public partial class Form1 : Form
    {
        ArrayList shapes = new ArrayList();
        String var;
        private bool button1WasClicked = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   

        }
        public void checkSyntax()
        {
            var = textBox1.Text;

       
        }

        public String GetTextFromTextBox()
        {
           
            var = textBox1.Text;
            MessageBox.Show(var);
            
            return var;
         
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           GetTextFromTextBox();
            button1WasClicked = true;
        }
        public void sendCommand()
        {
            if(button1WasClicked)
            {
              
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            shapes.Add(new Circle(Color.Purple, 10, 100, 100));

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
