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
        List<departamento> departamentos = new List<departamento>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream(@"C:\\Users\\Sergio Reyes\\source\\repos\\Examenparcial\\departamentos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);


            while (reader.Peek() > -1)
            {
                //cbxdepartamento.Items.Add(line);

                departamento departa = new departamento();

                //guardamos los datos leidos del archivo en un empleado temporal
                departa.Iddepartamento = Convert.ToInt32(reader.ReadLine());
                departa.Departamento = reader.ReadLine();

                //insertamos el empleado temporal a la lista para que ya queden cargados sus datos a la lista
                departamentos.Add(departa);
            }
            reader.Close();

            cbxdepartamento.DisplayMember = "Departamento";
            //y aquí le decimos que al dar clic sobre un nombre nos selecciones su código
            cbxdepartamento.ValueMember = "Iddepartamento";
            //ahora lo enlazamos con nuestra lista de la misma forma que los otros controles
            cbxdepartamento.DataSource = departamentos;
            cbxdepartamento.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un tipo date
            //obtenemos la fecha actual
            //convertimos la fecha a un formato ingles
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            string strDate = Convert.ToDateTime(dateTime).ToString("yy-MM-dd");

            string iddepartamento = cbxdepartamento.SelectedValue.ToString();
            string path = (@"C:\\Users\\Sergio Reyes\\source\\repos\\Examenparcial\\listado.txt");
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            writer.WriteLine(iddepartamento);
            writer.WriteLine(textBox1.Text);
            writer.Write(strDate);

            //Cerrar el archivo
            writer.Close();


        }
    }
}
