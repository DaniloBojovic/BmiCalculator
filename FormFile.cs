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

namespace BMICalculator
{
    public partial class FormFile : Form
    {
        public FormFile()
        {
            InitializeComponent();
        }

        private void FormPDF1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\igor\Desktop\BMIFiles\InfoBMI.txt"))
            {
                rtfInfo.Text = sr.ReadToEnd();
            }
        }
    }
}
