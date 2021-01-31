
namespace _2._1._13_UDatentypen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lblOrt = new System.Windows.Forms.Label();
			this.lblStraße = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblGehalt = new System.Windows.Forms.Label();
			this.lblAlter = new System.Windows.Forms.Label();
			this.cmdAnzeigen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adresse:";
			// 
			// lblOrt
			// 
			this.lblOrt.AutoSize = true;
			this.lblOrt.Location = new System.Drawing.Point(12, 54);
			this.lblOrt.Name = "lblOrt";
			this.lblOrt.Size = new System.Drawing.Size(54, 15);
			this.lblOrt.TabIndex = 1;
			this.lblOrt.Text = "Adresse:";
			// 
			// lblStraße
			// 
			this.lblStraße.AutoSize = true;
			this.lblStraße.Location = new System.Drawing.Point(12, 39);
			this.lblStraße.Name = "lblStraße";
			this.lblStraße.Size = new System.Drawing.Size(54, 15);
			this.lblStraße.TabIndex = 2;
			this.lblStraße.Text = "Adresse:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 24);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(54, 15);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Adresse:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Gehalt:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Alter:";
			// 
			// lblGehalt
			// 
			this.lblGehalt.AutoSize = true;
			this.lblGehalt.Location = new System.Drawing.Point(101, 104);
			this.lblGehalt.Name = "lblGehalt";
			this.lblGehalt.Size = new System.Drawing.Size(54, 15);
			this.lblGehalt.TabIndex = 6;
			this.lblGehalt.Text = "Adresse:";
			// 
			// lblAlter
			// 
			this.lblAlter.AutoSize = true;
			this.lblAlter.Location = new System.Drawing.Point(101, 89);
			this.lblAlter.Name = "lblAlter";
			this.lblAlter.Size = new System.Drawing.Size(54, 15);
			this.lblAlter.TabIndex = 7;
			this.lblAlter.Text = "Adresse:";
			// 
			// cmdAnzeigen
			// 
			this.cmdAnzeigen.Location = new System.Drawing.Point(149, 9);
			this.cmdAnzeigen.Name = "cmdAnzeigen";
			this.cmdAnzeigen.Size = new System.Drawing.Size(75, 23);
			this.cmdAnzeigen.TabIndex = 8;
			this.cmdAnzeigen.Text = "Anzeigen";
			this.cmdAnzeigen.UseVisualStyleBackColor = true;
			this.cmdAnzeigen.Click += new System.EventHandler(this.cmdAnzeigen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 127);
			this.Controls.Add(this.cmdAnzeigen);
			this.Controls.Add(this.lblAlter);
			this.Controls.Add(this.lblGehalt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblStraße);
			this.Controls.Add(this.lblOrt);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Datentypen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblOrt;
		private System.Windows.Forms.Label lblStraße;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblGehalt;
		private System.Windows.Forms.Label lblAlter;
		private System.Windows.Forms.Button cmdAnzeigen;
	}
}

