/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 25/11/2026
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_EN_EQUIPO
{
	/// <summary>
	/// Description of VOCALESYCONSONANTES.
	/// </summary>
	public partial class VOCALESYCONSONANTES : Form
	{
		public VOCALESYCONSONANTES()
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
			string palabra = txtPalabra.Text.ToLower();
		    int vocales = 0;
		    int consonantes = 0;
		    string listaVocales = "aeiouáéíóúü";
		
		    foreach (char letra in palabra)
		    {
		        if (char.IsLetter(letra))
		        {
		            if  (listaVocales.Contains(letra.ToString()))
		                vocales++;
		            else
		                consonantes++;
		        }
		    }
		    txtVocales.Text = vocales.ToString();
   		    txtConsonantes.Text = consonantes.ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			txtPalabra.Text="";
			txtVocales.Text="";
			txtConsonantes.Text="";
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			MENU_PRINCIPAL m = new MENU_PRINCIPAL();
			m.Show();
			this.Hide();
		}
	}
}
