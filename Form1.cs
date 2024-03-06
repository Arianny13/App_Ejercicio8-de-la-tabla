using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ejercicio_de_la_tabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {      

            if (int.TryParse(txt_Numero.Text, out int numero))
            {               
                for (int i = 1; i <= 12; i++)
                {
                    int resultado = numero * i;
                    lst_Tabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Numero.Clear();
            lst_Tabla.Items.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}
