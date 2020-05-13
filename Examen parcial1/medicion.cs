using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_parcial1
{
    class medicion
    {
        int iddepartamento;
        string date;
        float cantidad;

        public int Iddepartamento
        {
            set => iddepartamento = value;
            get => iddepartamento;
        }
        public string Departamento
        {
            set => date = value;
            get => date;
        }

        public float Cantidad
        {
            set => cantidad = value;
            get => cantidad;
        }
    }
}
