namespace Projeto_tcc
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txbSenha = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txblogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(3)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(284, 348);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(118, 50);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.AllowPromptAsInput = true;
            this.txbSenha.AnimateReadOnly = false;
            this.txbSenha.AsciiOnly = false;
            this.txbSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbSenha.BeepOnError = false;
            this.txbSenha.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txbSenha.Depth = 0;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbSenha.HidePromptOnLeave = false;
            this.txbSenha.HideSelection = true;
            this.txbSenha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txbSenha.LeadingIcon = null;
            this.txbSenha.Location = new System.Drawing.Point(234, 257);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSenha.Mask = "";
            this.txbSenha.MaxLength = 32767;
            this.txbSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.PrefixSuffixText = null;
            this.txbSenha.PromptChar = '_';
            this.txbSenha.ReadOnly = false;
            this.txbSenha.RejectInputOnFirstFailure = false;
            this.txbSenha.ResetOnPrompt = true;
            this.txbSenha.ResetOnSpace = true;
            this.txbSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbSenha.SelectedText = "";
            this.txbSenha.SelectionLength = 0;
            this.txbSenha.SelectionStart = 0;
            this.txbSenha.ShortcutsEnabled = true;
            this.txbSenha.Size = new System.Drawing.Size(223, 36);
            this.txbSenha.SkipLiterals = true;
            this.txbSenha.TabIndex = 2;
            this.txbSenha.TabStop = false;
            this.txbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSenha.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txbSenha.TrailingIcon = null;
            this.txbSenha.UseAccent = false;
            this.txbSenha.UseSystemPasswordChar = false;
            this.txbSenha.UseTallSize = false;
            this.txbSenha.ValidatingType = null;
            this.txbSenha.Click += new System.EventHandler(this.materialMaskedTextBox1_Click);
            // 
            // txblogin
            // 
            this.txblogin.AnimateReadOnly = false;
            this.txblogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txblogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txblogin.Depth = 0;
            this.txblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txblogin.HideSelection = true;
            this.txblogin.LeadingIcon = null;
            this.txblogin.Location = new System.Drawing.Point(234, 185);
            this.txblogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txblogin.MaxLength = 32767;
            this.txblogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txblogin.Name = "txblogin";
            this.txblogin.PasswordChar = '\0';
            this.txblogin.PrefixSuffixText = null;
            this.txblogin.ReadOnly = false;
            this.txblogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txblogin.SelectedText = "";
            this.txblogin.SelectionLength = 0;
            this.txblogin.SelectionStart = 0;
            this.txblogin.ShortcutsEnabled = true;
            this.txblogin.Size = new System.Drawing.Size(223, 36);
            this.txblogin.TabIndex = 1;
            this.txblogin.TabStop = false;
            this.txblogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txblogin.TrailingIcon = null;
            this.txblogin.UseAccent = false;
            this.txblogin.UseSystemPasswordChar = false;
            this.txblogin.UseTallSize = false;
            this.txblogin.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(231, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastre-se gratuitamente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-266, -148);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(510, 599);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(504, -148);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 676);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(647, 11);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(22, 24);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 18;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 428);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txblogin);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntrar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txbSenha;
        private MaterialSkin.Controls.MaterialTextBox2 txblogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Fechar;
    }
}

