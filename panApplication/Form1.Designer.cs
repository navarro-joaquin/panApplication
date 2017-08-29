namespace panApplication
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnSortear = new System.Windows.Forms.Button();
			this.lblElegido = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(41, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(195, 39);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Comprar pan";
			// 
			// btnSortear
			// 
			this.btnSortear.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSortear.Location = new System.Drawing.Point(95, 123);
			this.btnSortear.Name = "btnSortear";
			this.btnSortear.Size = new System.Drawing.Size(88, 35);
			this.btnSortear.TabIndex = 1;
			this.btnSortear.Text = "Sortear";
			this.btnSortear.UseVisualStyleBackColor = true;
			this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
			// 
			// lblElegido
			// 
			this.lblElegido.AutoSize = true;
			this.lblElegido.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblElegido.Location = new System.Drawing.Point(94, 77);
			this.lblElegido.Name = "lblElegido";
			this.lblElegido.Size = new System.Drawing.Size(89, 28);
			this.lblElegido.TabIndex = 2;
			this.lblElegido.Text = "Elegido:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 193);
			this.Controls.Add(this.lblElegido);
			this.Controls.Add(this.btnSortear);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btnSortear;
		private System.Windows.Forms.Label lblElegido;
	}
}

