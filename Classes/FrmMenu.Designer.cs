namespace SantoAndre
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.btnPix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPix = new System.Windows.Forms.Panel();
            this.btnPixVoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChavePix = new System.Windows.Forms.TextBox();
            this.pnlPix.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.Location = new System.Drawing.Point(34, 32);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(158, 32);
            this.lblBoasVindas.TabIndex = 0;
            this.lblBoasVindas.Text = "Olá Usuario";
            // 
            // btnPix
            // 
            this.btnPix.BackColor = System.Drawing.SystemColors.Window;
            this.btnPix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPix.BackgroundImage")));
            this.btnPix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPix.Location = new System.Drawing.Point(40, 146);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(80, 80);
            this.btnPix.TabIndex = 1;
            this.btnPix.UseVisualStyleBackColor = false;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pix";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(34, 64);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(100, 32);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo  ";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(141, 337);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 80);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sair";
            // 
            // pnlPix
            // 
            this.pnlPix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlPix.Controls.Add(this.txtChavePix);
            this.pnlPix.Controls.Add(this.label3);
            this.pnlPix.Controls.Add(this.btnPixVoltar);
            this.pnlPix.Location = new System.Drawing.Point(0, 0);
            this.pnlPix.Name = "pnlPix";
            this.pnlPix.Size = new System.Drawing.Size(384, 461);
            this.pnlPix.TabIndex = 6;
            this.pnlPix.Visible = false;
            // 
            // btnPixVoltar
            // 
            this.btnPixVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPixVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPixVoltar.BackgroundImage")));
            this.btnPixVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPixVoltar.FlatAppearance.BorderSize = 0;
            this.btnPixVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixVoltar.Location = new System.Drawing.Point(12, 32);
            this.btnPixVoltar.Name = "btnPixVoltar";
            this.btnPixVoltar.Size = new System.Drawing.Size(80, 80);
            this.btnPixVoltar.TabIndex = 0;
            this.btnPixVoltar.UseVisualStyleBackColor = false;
            this.btnPixVoltar.Click += new System.EventHandler(this.btnPixVoltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chave Pix";
            // 
            // txtChavePix
            // 
            this.txtChavePix.Location = new System.Drawing.Point(12, 162);
            this.txtChavePix.Name = "txtChavePix";
            this.txtChavePix.Size = new System.Drawing.Size(329, 20);
            this.txtChavePix.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.lblBoasVindas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlPix.ResumeLayout(false);
            this.pnlPix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Button btnPix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPix;
        private System.Windows.Forms.Button btnPixVoltar;
        private System.Windows.Forms.TextBox txtChavePix;
        private System.Windows.Forms.Label label3;
    }
}