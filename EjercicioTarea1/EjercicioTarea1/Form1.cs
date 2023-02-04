using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            //Realizar un ejercicio en C#.Net con Windows Forms en donde el usuario
            //ingrese un valor entero y devuelva si es par o impar, positivo o negativo.

            decimal numero = Convert.ToDecimal(IngreseTextBox.Text);
            MessageBox.Show(Convert.ToString(Calcular(numero)));
            MessageBox.Show(Convert.ToString(Calcular2(numero)));
        
        }
        //Función1
        private decimal Calcular(decimal num)
        {
            
            if (num % 2 == 0)
            {
                MessageBox.Show("El numero ingresado es par: ");
            }
            else
            {
                MessageBox.Show("El numero ingresado es impar: ");
            }

            return num;  
        }
        //Función2
         private decimal Calcular2(decimal numero)
        {
            
            if (numero > 0 )
            {
                MessageBox.Show("El numero es positivo ");
            }
            else if (numero == 0)
            {
                MessageBox.Show("El numero es neutro ");
            }
            else
            {
                MessageBox.Show("El numero es negativo ");
            }
            return numero;
            
        }
    }
}
