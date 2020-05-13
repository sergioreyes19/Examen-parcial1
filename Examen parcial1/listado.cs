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

    public partial class listado : Form
    {
        List<medicion> mediciones = new List<medicion>();

        public listado()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listado_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream(@"C:\\Users\\Sergio Reyes\\source\\repos\\Examenparcial\\listado.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            while (reader.Peek() > -1)
            {
                medicion mediciontemp = new medicion();

                //guardamos los datos leidos del archivo en un empleado temporal
                mediciontemp.Iddepartamento = Convert.ToInt32(reader.ReadLine());
                mediciontemp.Cantidad  = Convert.ToInt32(reader.ReadLine());
                mediciontemp.Date = reader.ReadLine();

                //insertamos el empleado temporal a la lista para que ya queden cargados sus datos a la lista
                mediciones.Add(mediciontemp);
            }

            reader.Close();

          

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mediciones;
            dataGridView1.Refresh();

           
            //cargamos los empleados al combobox
            //como cada empleado tiene varios datos, le tenemos que especificar al combobox
            //que dato queremos que muestre, y que dato queremos que seleccione al dar clic sobre el

            //aquí le decimos que nos muestre los nombres de los empleados

          
        }
    }
}
