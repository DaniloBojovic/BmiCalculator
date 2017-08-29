using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        double height;
        double weight;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bmiDBDataSet.tblBMI' table. You can move, or remove it, as needed.
            this.tblBMITableAdapter.Fill(this.bmiDBDataSet.tblBMI);
            btnInfo.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            txtResult.Clear();
            txtHeight.Focus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                height = double.Parse(txtHeight.Text);
                weight = double.Parse(txtWeight.Text);
                result = Math.Round(weight / (height * height), 1);
                txtResult.Text = result.ToString();

                if (result < 18.5)
                {
                    lblMsg.BackColor = Color.Yellow;
                    lblMsg.Text = "You are underweight!";
                }
                else if (result < 25)
                {
                    lblMsg.BackColor = Color.LightGreen;
                    lblMsg.Text = "You are healthy!";
                }
                else if (result < 30)
                {
                    lblMsg.BackColor = Color.Yellow;
                    lblMsg.Text = "You are overweight!";
                }
                else
                {
                    lblMsg.BackColor = Color.Red;
                    lblMsg.Text = "You are obese!";
                }
                btnInfo.Visible = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                txtHeight.Clear();
                txtWeight.Clear();
                txtHeight.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormFile formInfo = new FormFile();
            formInfo.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
