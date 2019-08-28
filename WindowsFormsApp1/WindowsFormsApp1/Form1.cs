using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + "0";
        }

        private void BttnPunto_Click(object sender, EventArgs e)
        {
            TxtPantalla.Text = TxtPantalla.Text + ".";
        }

        private void BttnSuma_Click(object sender, EventArgs e)
        {
            operador =  "+";
            primero = double.Parse(TxtPantalla.Text);
            TxtPantalla.Clear();
        }

        private void BttnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(TxtPantalla.Text);
            TxtPantalla.Clear();
        }

        private void BttnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(TxtPantalla.Text);
            TxtPantalla.Clear();
        }

        private void BttnDiision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(TxtPantalla.Text);
            TxtPantalla.Clear();
        }

        private void BttnPorcentaje_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(TxtPantalla.Text);
            TxtPantalla.Clear();
        }

        private void BttnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BttnBorrarPantalla_Click(object sender, EventArgs e)
        {
            TxtPantalla.Clear();
        }

        private void BttnBorrarNumero_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text.Length == 1)
                TxtPantalla.Text = "";
            else
                TxtPantalla.Text = TxtPantalla.Text.Substring(0, TxtPantalla.Text.Length - 1);
        }

        private void BttnIgual_Click(object sender, EventArgs e)
        {

        }
    }
}
