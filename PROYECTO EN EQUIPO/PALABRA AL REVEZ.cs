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
	/// Description of PALABRA_AL_REVEZ.
	/// </summary>
	public partial class PALABRA_AL_REVEZ : Form
	{
		public PALABRA_AL_REVEZ()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		    char[] caracteres = txtIngresar.Text.ToCharArray();
            Array.Reverse(caracteres);
            txtConvertir.Text = new string(caracteres);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			txtIngresar.Text="";
			txtConvertir.Text="";
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			MENU_PRINCIPAL m = new MENU_PRINCIPAL();
			m.Show();
			this.Hide();
		}
	}
}
