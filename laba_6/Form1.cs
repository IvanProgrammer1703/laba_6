using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_6
{
    public partial class Form1 : Form
    {
        public List<int> number = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void variable_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try{

                number.Add(Convert.ToInt32(variable.Text));
                result.Text += variable.Text+" -- ";
                variable.Text = "";
            }
            catch(Exception){
                MessageBox.Show("Вы вввели не число");
                variable.Text = "";
            }
            }

        private void sorts_Click(object sender, EventArgs e)
        {
            number.Sort();
            result.Text = "";
            variable.Text = "";
            foreach (object item in number)
            {
                result.Text += item + " --- ";
            }
        }

        private void array_list_view_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
