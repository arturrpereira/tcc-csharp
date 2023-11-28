namespace Projeto_tcc.View
{
    partial class Buscar_Partida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_Partida));
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_valoraposta = new System.Windows.Forms.Label();
            this.txbvaloraposta = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_buscar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.BackColor = System.Drawing.Color.Transparent;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(91)))), ((int)(((byte)(21)))));
            this.lbl_role.Location = new System.Drawing.Point(134, 50);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(87, 22);
            this.lbl_role.TabIndex = 9;
            this.lbl_role.Text = "Posição:";
            // 
            // lbl_valoraposta
            // 
            this.lbl_valoraposta.AutoSize = true;
            this.lbl_valoraposta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valoraposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_valoraposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(91)))), ((int)(((byte)(21)))));
            this.lbl_valoraposta.Location = new System.Drawing.Point(96, 101);
            this.lbl_valoraposta.Name = "lbl_valoraposta";
            this.lbl_valoraposta.Size = new System.Drawing.Size(125, 22);
            this.lbl_valoraposta.TabIndex = 11;
            this.lbl_valoraposta.Text = "Valor Aposta";
            this.lbl_valoraposta.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbvaloraposta
            // 
            this.txbvaloraposta.AnimateReadOnly = false;
            this.txbvaloraposta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbvaloraposta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbvaloraposta.Depth = 0;
            this.txbvaloraposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txbvaloraposta.HideSelection = true;
            this.txbvaloraposta.LeadingIcon = null;
            this.txbvaloraposta.Location = new System.Drawing.Point(253, 101);
            this.txbvaloraposta.Margin = new System.Windows.Forms.Padding(2);
            this.txbvaloraposta.MaxLength = 32767;
            this.txbvaloraposta.MouseState = MaterialSkin.MouseState.OUT;
            this.txbvaloraposta.Name = "txbvaloraposta";
            this.txbvaloraposta.PasswordChar = '\0';
            this.txbvaloraposta.PrefixSuffixText = null;
            this.txbvaloraposta.ReadOnly = false;
            this.txbvaloraposta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbvaloraposta.SelectedText = "";
            this.txbvaloraposta.SelectionLength = 0;
            this.txbvaloraposta.SelectionStart = 0;
            this.txbvaloraposta.ShortcutsEnabled = true;
            this.txbvaloraposta.Size = new System.Drawing.Size(106, 36);
            this.txbvaloraposta.TabIndex = 16;
            this.txbvaloraposta.TabStop = false;
            this.txbvaloraposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbvaloraposta.TrailingIcon = null;
            this.txbvaloraposta.UseAccent = false;
            this.txbvaloraposta.UseSystemPasswordChar = false;
            this.txbvaloraposta.UseTallSize = false;
            this.txbvaloraposta.Click += new System.EventHandler(this.txbvaloraposta_Click);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Topo",
            "Selva",
            "Meio",
            "Atirador",
            "Suporte"});
            this.materialComboBox1.Location = new System.Drawing.Point(253, 34);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(106, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 15;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Image = global::tcc_csharp.Properties.Resources.game_mode__3_;
            this.btn_buscar.Location = new System.Drawing.Point(187, 176);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(127, 37);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(319, -68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 457);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-120, -244);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Buscar_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 225);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.txbvaloraposta);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_valoraposta);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscar_Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo1";
            this.Load += new System.EventHandler(this.Modelo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_valoraposta;
        private System.Windows.Forms.PictureBox btn_buscar;
        private MaterialSkin.Controls.MaterialTextBox2 txbvaloraposta;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}