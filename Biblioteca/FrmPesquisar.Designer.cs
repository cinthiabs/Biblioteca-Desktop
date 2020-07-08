namespace Biblioteca
{
    partial class FrmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisar));
            this.cbgenero = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtescolariedade = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEscolariedade = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbgenero
            // 
            this.cbgenero.FormattingEnabled = true;
            this.cbgenero.Items.AddRange(new object[] {
            "FEMININO",
            "MASCULINO"});
            this.cbgenero.Location = new System.Drawing.Point(180, 392);
            this.cbgenero.Name = "cbgenero";
            this.cbgenero.Size = new System.Drawing.Size(245, 21);
            this.cbgenero.TabIndex = 32;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(180, 342);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(437, 20);
            this.txtemail.TabIndex = 31;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(180, 289);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(437, 20);
            this.txtendereco.TabIndex = 30;
            // 
            // txtescolariedade
            // 
            this.txtescolariedade.Location = new System.Drawing.Point(180, 243);
            this.txtescolariedade.Name = "txtescolariedade";
            this.txtescolariedade.Size = new System.Drawing.Size(437, 20);
            this.txtescolariedade.TabIndex = 29;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(211, 192);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(214, 20);
            this.txtdata.TabIndex = 28;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(180, 143);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(437, 20);
            this.txtnome.TabIndex = 27;
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Location = new System.Drawing.Point(74, 400);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(56, 13);
            this.lblgenero.TabIndex = 26;
            this.lblgenero.Text = "GENERO:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(74, 345);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(45, 13);
            this.lblemail.TabIndex = 25;
            this.lblemail.Text = "E-MAIL:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(74, 296);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(70, 13);
            this.lblEndereco.TabIndex = 24;
            this.lblEndereco.Text = "ENDEREÇO:";
            // 
            // lblEscolariedade
            // 
            this.lblEscolariedade.AutoSize = true;
            this.lblEscolariedade.Location = new System.Drawing.Point(74, 250);
            this.lblEscolariedade.Name = "lblEscolariedade";
            this.lblEscolariedade.Size = new System.Drawing.Size(100, 13);
            this.lblEscolariedade.TabIndex = 23;
            this.lblEscolariedade.Text = "ESCOLARIEDADE:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(74, 197);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(131, 13);
            this.lbldata.TabIndex = 22;
            this.lbldata.Text = "DATA DE NASCIMENTO;";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(74, 146);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(42, 13);
            this.lblnome.TabIndex = 21;
            this.lblnome.Text = "NOME:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(146)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(-396, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 39);
            this.panel1.TabIndex = 33;
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(1032, 2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(30, 37);
            this.btnMini.TabIndex = 14;
            this.btnMini.Text = "__";
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1069, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 37);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.btnpesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpesquisar.ForeColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(153, 469);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(118, 40);
            this.btnpesquisar.TabIndex = 22;
            this.btnpesquisar.Text = "PESQUISAR";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(285, 469);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 40);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "ATUALIZAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(416, 469);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(118, 40);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(283, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "CONSULTAR CADASTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "*DIGITE NOME COMPLETO DO USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbgenero);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtescolariedade);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblEscolariedade);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPesquisar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbgenero;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtescolariedade;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEscolariedade;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}