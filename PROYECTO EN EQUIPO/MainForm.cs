/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 25/11/2026
 * Time: 07:49 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_EN_EQUIPO
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class LOGIN : Form
	{
		public LOGIN()
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
			string usuario, contraseña;
			usuario="Admin";
			contraseña="1234";
			if(usuario==txtUsuario.Text && contraseña==txtContra.Text)
			{
				MENU_PRINCIPAL M = new MENU_PRINCIPAL();
				M.Show();
				this.Hide();
			}
		}
	}
}
