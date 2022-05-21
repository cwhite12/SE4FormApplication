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
using System.ComponentModel.DataAnnotations;

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
            // GetTextFromTextBox();
            //   button1WasClicked = true;
            userCommandBindingSource.EndEdit();
            UserCommand userCommand = userCommandBindingSource.Current as UserCommand;
            userCommandBindingSource.AddNew();

            if (userCommand != null)

            {
                if (userCommand.isValid)
                {

                }


                //ValidationContext context = new ValidationContext(userCommand, null, null);
                //IList<ValidationResult> errors = new List<ValidationResult>();
                //if (!Validator.TryValidateObject(userCommand, context, errors, true))
                //{
                //    foreach (ValidationResult result in errors)
                //    {
                //        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
            }
        }


        public void sendCommand()
        {
            if (button1WasClicked)
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
            validateSyntax();
        }
        public bool validateSyntax()
        {
            String[] allowedValues = { "drawTo", "rect" };
          
            String textFromTextBox = textBox1.Text;
            bool doesItContainValidSyntax = ContainsAny(textFromTextBox, allowedValues);
            if (doesItContainValidSyntax)
            {
             errorProvider.SetError(textBox1, "");  
            }
            else
            errorProvider.SetError(textBox1, "please enter valid syntax");
            
     
            return doesItContainValidSyntax;
  
        }
        public static bool ContainsAny(string textBoxText, params string[] allowedValues)
        {
            foreach (string allowed in allowedValues)
            {
                if (textBoxText.Contains(allowed))
                    return true;
            }

            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
