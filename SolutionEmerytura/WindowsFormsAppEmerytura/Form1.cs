using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEmerytura
{
    public partial class Form1 : Form
    {
        const int wiekEmerytalny = 65;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            int wiek = int.Parse(textBoxWiek.Text);
            if (wiek < wiekEmerytalny)
                labelWynik.Text = $"Został Ci do emerytury {wiekEmerytalny - wiek} lat";
            else
                labelWynik.Text = "Jesteś emerytem";
        }
    }
}
