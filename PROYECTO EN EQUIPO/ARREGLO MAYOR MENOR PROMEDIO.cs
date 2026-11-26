/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 25/11/2026
 * Time: 07:50 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_EN_EQUIPO
{
	/// <summary>
	/// Description of ARREGLO_MAYOR_MENOR_PROMEDIO.
	/// </summary>
	public partial class ARREGLO_MAYOR_MENOR_PROMEDIO : Form
	{
		public ARREGLO_MAYOR_MENOR_PROMEDIO()
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
			MENU_PRINCIPAL n=new MENU_PRINCIPAL();
			n.Show();
			this.Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text="";
			textBox2.Text="";
			textBox3.Text="";
		}
	}
}
