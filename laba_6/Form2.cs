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

namespace laba_6
{
    public partial class Form2 : Form
    {
        public ArrayList numberlist = new ArrayList();

        public Form2()
        {
            InitializeComponent();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            numberlist.Sort();
            
                result.Text = "";
                one.Clear();
                foreach (object item in numberlist)
                {
                    result.Text += item + " -- ";
                }
            
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try {
                numberlist.Add(Convert.ToInt32(one.Text));
                result.Text += one.Text + " - ";
                one.Clear();

            }
            catch (Exception) {
                MessageBox.Show("ERROR EPT");
            }
        }
        
        private void one_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
