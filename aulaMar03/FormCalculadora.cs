using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaMar03
{
	public partial class FormCalculadora : Form
	{
		public FormCalculadora()
		{
			InitializeComponent();
		}

		private void btnAdicao_Click(object sender, EventArgs e)
		{
			double resultado;
			resultado = Soma(Convert.ToDouble(txtNumero1.Text), Convert.ToDouble(txtNumero2.Text));
			txtResultado.Text = resultado.ToString();
		}

		private void btnSubtracao_Click(object sender, EventArgs e)
		{
			double resultado;
			resultado = Subtracao(Convert.ToDouble(txtNumero1.Text), Convert.ToDouble(txtNumero2.Text));
			txtResultado.Text = resultado.ToString();
		}

		private void btnDivisao_Click(object sender, EventArgs e)
		{
			double resultado;
			resultado = Divisao(Convert.ToDouble(txtNumero1.Text), Convert.ToDouble(txtNumero2.Text));
			txtResultado.Text = resultado.ToString();
		}

		private void btnMultiplicacao_Click(object sender, EventArgs e)
		{
			double resultado;
			resultado = Multiplicacao(Convert.ToDouble(txtNumero1.Text), Convert.ToDouble(txtNumero2.Text));
			txtResultado.Text = resultado.ToString();
		}

		private double Soma(double n1, double n2)
		{
			double total;
			total = n1 + n2;
			return total;
		}

		private double Subtracao(double n1, double n2)
		{
			double total;
			total = n1 - n2;
			return total;
		}

		private double Divisao(double n1, double n2)
		{
			double total;
			total = n1 / n2;
			return total;
		}

		private double Multiplicacao(double n1, double n2)
		{
			double total;
			total = n1 * n2;
			return total;
		}
	}
}
