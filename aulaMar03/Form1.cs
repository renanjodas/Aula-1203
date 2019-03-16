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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
		}

		private void btnCalculadora_Click(object sender, EventArgs e)
		{
			FormCalculadora formCalc = new FormCalculadora();
			formCalc.Show();
		}

		private void btnAcrescimo_Click(object sender, EventArgs e)
		{
			FormAcrescimo formAcresc = new FormAcrescimo();
			formAcresc.Show();
		}

		private void btnDesconto_Click(object sender, EventArgs e)
		{
			FormDesconto formDesc = new FormDesconto();
			formDesc.Show();
		}
	}
}
