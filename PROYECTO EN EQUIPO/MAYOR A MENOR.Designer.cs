/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 25/11/2026
 * Time: 07:49 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROYECTO_EN_EQUIPO
{
	partial class MAYOR_A_MENOR
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtArreglo = new System.Windows.Forms.TextBox();
			this.txtMayorAmenor = new System.Windows.Forms.TextBox();
			this.txtMenorAmayor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(98, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingresa un arreglo:";
			// 
			// txtArreglo
			// 
			this.txtArreglo.Location = new System.Drawing.Point(70, 52);
			this.txtArreglo.Name = "txtArreglo";
			this.txtArreglo.Size = new System.Drawing.Size(146, 20);
			this.txtArreglo.TabIndex = 1;
			// 
			// txtMayorAmenor
			// 
			this.txtMayorAmenor.Enabled = false;
			this.txtMayorAmenor.Location = new System.Drawing.Point(70, 103);
			this.txtMayorAmenor.Name = "txtMayorAmenor";
			this.txtMayorAmenor.Size = new System.Drawing.Size(146, 20);
			this.txtMayorAmenor.TabIndex = 2;
			// 
			// txtMenorAmayor
			// 
			this.txtMenorAmayor.Enabled = false;
			this.txtMenorAmayor.Location = new System.Drawing.Point(70, 156);
			this.txtMenorAmayor.Name = "txtMenorAmayor";
			this.txtMenorAmayor.Size = new System.Drawing.Size(146, 20);
			this.txtMenorAmayor.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(70, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mayor a menor:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(70, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Menor a mayor:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 49);
			this.button1.TabIndex = 6;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(212, 227);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 22);
			this.button2.TabIndex = 7;
			this.button2.Text = "Regresar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(115, 200);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(83, 49);
			this.button3.TabIndex = 8;
			this.button3.Text = "Limpiar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MAYOR_A_MENOR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMenorAmayor);
			this.Controls.Add(this.txtMayorAmenor);
			this.Controls.Add(this.txtArreglo);
			this.Controls.Add(this.label1);
			this.Name = "MAYOR_A_MENOR";
			this.Text = "MAYOR_A_MENOR";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMenorAmayor;
		private System.Windows.Forms.TextBox txtMayorAmenor;
		private System.Windows.Forms.TextBox txtArreglo;
		private System.Windows.Forms.Label label1;
	}
}
