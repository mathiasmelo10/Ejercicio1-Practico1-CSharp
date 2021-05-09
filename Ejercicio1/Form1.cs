using System;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        double primerValor = 0;
        double segundoValor = 0;
        String esMayor = " es mayor a ";
        String esMenor = " es menor a ";
        String esIgual = " es igual a ";
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void EnterosADouble()
        {
            if (txtNum1.Text != null || txtNum2.Text != null)
            {
                primerValor = Convert.ToDouble(txtNum1.Text);
                segundoValor = Convert.ToDouble(txtNum2.Text);
            }
        }

        public void EsVacio()
        {
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("Le falto completar campo en el primer valor ");
            }
            else if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("Le falto completar campo en el segundo valor");
            } 
        }

        public void EsMayor()
        {
            if (primerValor > segundoValor)
            {
                MessageBox.Show(primerValor + esMayor + segundoValor);
            }
            else if (segundoValor > primerValor)
            {
                MessageBox.Show(segundoValor + esMayor + primerValor);
            }
        }

        public void EsIgual()
        {
            if (primerValor == segundoValor)
            {
                MessageBox.Show(primerValor + esIgual + segundoValor);
            }

        }


        public void EsMenor()
        {
            if (primerValor < segundoValor)
            {
                MessageBox.Show(primerValor + esMenor + segundoValor);
            }
            else if (segundoValor < primerValor)
            {
                MessageBox.Show(segundoValor + esMenor + primerValor);
            }
        }

        public void btnComparar_Click(object sender, EventArgs e)
        {
            EnterosADouble();
            EsVacio();
            EsMayor();
            EsIgual();
            EsMenor();
        }
    }
}