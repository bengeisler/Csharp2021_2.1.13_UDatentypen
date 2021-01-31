using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1._13_UDatentypen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmdAnzeigen_Click(object sender, EventArgs e)
		{
			int alter = 30;
			float gehalt = 2000;

			string name = "Benedikt Geisler";
			string straße = "Mozartstraße 4";
			string ort = "93049 Regensburg";

			lblAlter.Text = alter.ToString();
			lblGehalt.Text = gehalt.ToString();

			lblName.Text = name.ToString();
			lblStraße.Text = straße.ToString();
			lblOrt.Text = ort.ToString();

		}
	}
}
