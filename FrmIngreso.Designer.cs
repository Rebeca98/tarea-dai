﻿namespace Préstamos {
  partial class FrmIngreso {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngreso));
      this.label1 = new System.Windows.Forms.Label();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtContra = new System.Windows.Forms.TextBox();
      this.btnIngresar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(142, 99);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Usuario:";
      // 
      // txtUsuario
      // 
      this.txtUsuario.Location = new System.Drawing.Point(287, 99);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(100, 22);
      this.txtUsuario.TabIndex = 1;
      this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(142, 159);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Contraseña:";
      // 
      // txtContra
      // 
      this.txtContra.Location = new System.Drawing.Point(287, 157);
      this.txtContra.Name = "txtContra";
      this.txtContra.PasswordChar = '*';
      this.txtContra.Size = new System.Drawing.Size(100, 22);
      this.txtContra.TabIndex = 3;
      // 
      // btnIngresar
      // 
      this.btnIngresar.Location = new System.Drawing.Point(512, 119);
      this.btnIngresar.Name = "btnIngresar";
      this.btnIngresar.Size = new System.Drawing.Size(116, 37);
      this.btnIngresar.TabIndex = 4;
      this.btnIngresar.Text = "Ingresar";
      this.btnIngresar.UseVisualStyleBackColor = true;
      this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
      // 
      // FrmIngreso
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(748, 514);
      this.Controls.Add(this.btnIngresar);
      this.Controls.Add(this.txtContra);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.label1);
      this.Name = "FrmIngreso";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FrmIngreso";
      this.Load += new System.EventHandler(this.FrmIngreso_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtContra;
    private System.Windows.Forms.Button btnIngresar;
  }
}