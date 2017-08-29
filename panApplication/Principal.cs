using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace panApplication
{
	public partial class Principal : Form
	{
		aleatorio numero;
		public Principal()
		{
			InitializeComponent();
		}

		private void btnSortear_Click(object sender, EventArgs e)
		{
			numero = new aleatorio();
			lblElegido.Text = numero.elegirNombre(numero.generarAleatorio());
		}
	}
}
