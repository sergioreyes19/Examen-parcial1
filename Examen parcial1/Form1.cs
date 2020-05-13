using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Examen_parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string line;
            StreamReader file = new StreamReader(@"C:\\Users\\Sergio Reyes\\source\\repos\\Examenparcial\\departamentos.txt");
            while ((line = file.ReadLine()) != null)
            {
                cbxdepartamento.Items.Add(line);
            }

        }
    }
}
