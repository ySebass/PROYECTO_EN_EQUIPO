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
	/// Description of MENU_PRINCIPAL.
	/// </summary>
	public partial class MENU_PRINCIPAL : Form
	{
		public MENU_PRINCIPAL()
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
			MAYOR_A_MENOR M = new MAYOR_A_MENOR();
			M.Show();
			this.Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			ARREGLO_MAYOR_MENOR_PROMEDIO A = new ARREGLO_MAYOR_MENOR_PROMEDIO();
			A.Show();
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			PALABRA_AL_REVEZ P = new PALABRA_AL_REVEZ();
			P.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			VOCALESYCONSONANTES V = new VOCALESYCONSONANTES();
			V.Show();
			this.Hide();
		}
	}
}
