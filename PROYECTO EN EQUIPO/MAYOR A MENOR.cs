/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 25/11/2026
 * Time: 07:49 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_EN_EQUIPO
{
	/// <summary>
	/// Description of MAYOR_A_MENOR.
	/// </summary>
	public partial class MAYOR_A_MENOR : Form
	{
		public MAYOR_A_MENOR()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MENU_PRINCIPAL  M = new MENU_PRINCIPAL();
			M.Show();
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int[] numeros = Array.ConvertAll(txtArreglo.Text.Split(','), int.Parse);
		    Array.Sort(numeros);
			txtMenorAmayor.Text = string.Join(", ", numeros);
		    Array.Reverse(numeros);
		    txtMayorAmenor.Text = string.Join(", ", numeros);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			txtArreglo.Text="";
			txtMayorAmenor.Text="";
			txtMenorAmayor.Text="";
		}
	}
}
