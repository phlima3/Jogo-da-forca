﻿namespace prjJogoForca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnLetra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.pnPalavra = new System.Windows.Forms.Panel();
            this.pnLetra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLetra
            // 
            this.pnLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLetra.Controls.Add(this.btnJogar);
            this.pnLetra.Controls.Add(this.txtLetra);
            this.pnLetra.Controls.Add(this.label1);
            this.pnLetra.Location = new System.Drawing.Point(12, 12);
            this.pnLetra.Name = "pnLetra";
            this.pnLetra.Size = new System.Drawing.Size(280, 212);
            this.pnLetra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(77)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE LETRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetra
            // 
            this.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(11, 65);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(255, 45);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.Text = "A";
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          
            // 
            // btnJogar
            // 
            this.btnJogar.FlatAppearance.BorderSize = 3;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Location = new System.Drawing.Point(11, 116);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(255, 84);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            // 
            // pnPalavra
            // 
            this.pnPalavra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPalavra.Location = new System.Drawing.Point(326, 13);
            this.pnPalavra.Name = "pnPalavra";
            this.pnPalavra.Size = new System.Drawing.Size(779, 211);
            this.pnPalavra.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(92)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1111, 243);
            this.Controls.Add(this.pnPalavra);
            this.Controls.Add(this.pnLetra);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLetra.ResumeLayout(false);
            this.pnLetra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Panel pnPalavra;
    }
}
