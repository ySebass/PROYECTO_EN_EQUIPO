/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 25/11/2026
 * Time: 07:50 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROYECTO_EN_EQUIPO
{
	partial class PALABRA_AL_REVEZ
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
			this.txtIngresar = new System.Windows.Forms.TextBox();
			this.txtConvertir = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingresa palabra:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(163, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Palabra al reves:";
			// 
			// txtIngresar
			// 
			this.txtIngresar.Location = new System.Drawing.Point(21, 49);
			this.txtIngresar.Name = "txtIngresar";
			this.txtIngresar.Size = new System.Drawing.Size(109, 20);
			this.txtIngresar.TabIndex = 2;
			// 
			// txtConvertir
			// 
			this.txtConvertir.Enabled = false;
			this.txtConvertir.Location = new System.Drawing.Point(154, 49);
			this.txtConvertir.Name = "txtConvertir";
			this.txtConvertir.Size = new System.Drawing.Size(109, 20);
			this.txtConvertir.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(21, 121);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 39);
			this.button1.TabIndex = 4;
			this.button1.Text = "Convertir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(163, 121);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 39);
			this.button2.TabIndex = 5;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(87, 192);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 39);
			this.button3.TabIndex = 6;
			this.button3.Text = "Regresar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// PALABRA_AL_REVEZ
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtConvertir);
			this.Controls.Add(this.txtIngresar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PALABRA_AL_REVEZ";
			this.Text = "PALABRA_AL_REVEZ";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtConvertir;
		private System.Windows.Forms.TextBox txtIngresar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
