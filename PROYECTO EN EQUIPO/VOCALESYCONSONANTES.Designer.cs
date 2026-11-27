/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 25/11/2026
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROYECTO_EN_EQUIPO
{
	partial class VOCALESYCONSONANTES
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.txtVocales = new System.Windows.Forms.TextBox();
			this.txtConsonantes = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingresa una palabra:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(172, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Vocales:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(158, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Consonantes";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(12, 48);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(112, 20);
			this.txtPalabra.TabIndex = 3;
			// 
			// txtVocales
			// 
			this.txtVocales.Enabled = false;
			this.txtVocales.Location = new System.Drawing.Point(147, 48);
			this.txtVocales.Name = "txtVocales";
			this.txtVocales.Size = new System.Drawing.Size(100, 20);
			this.txtVocales.TabIndex = 4;
			// 
			// txtConsonantes
			// 
			this.txtConsonantes.Enabled = false;
			this.txtConsonantes.Location = new System.Drawing.Point(147, 108);
			this.txtConsonantes.Name = "txtConsonantes";
			this.txtConsonantes.Size = new System.Drawing.Size(100, 20);
			this.txtConsonantes.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 94);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 6;
			this.button1.Text = "Callcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(82, 146);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 34);
			this.button2.TabIndex = 7;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(160, 215);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 34);
			this.button3.TabIndex = 8;
			this.button3.Text = "Regresar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// VOCALESYCONSONANTES
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtConsonantes);
			this.Controls.Add(this.txtVocales);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "VOCALESYCONSONANTES";
			this.Text = "VOCALESYCONSONANTES";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtConsonantes;
		private System.Windows.Forms.TextBox txtVocales;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
