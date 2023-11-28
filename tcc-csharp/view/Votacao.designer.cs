namespace Projeto_tcc.View
{
    partial class Votacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Votacao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_votacao = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_votacao_pendente = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.idpartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorApostado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganhou = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perdeu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_votacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_votacao
            // 
            this.dgv_votacao.AllowUserToAddRows = false;
            this.dgv_votacao.AllowUserToResizeColumns = false;
            this.dgv_votacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_votacao.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_votacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_votacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_votacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpartida,
            this.data,
            this.time,
            this.valorApostado,
            this.role,
            this.ganhou,
            this.perdeu});
            this.dgv_votacao.Location = new System.Drawing.Point(0, 137);
            this.dgv_votacao.Name = "dgv_votacao";
            this.dgv_votacao.RowHeadersVisible = false;
            this.dgv_votacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_votacao.Size = new System.Drawing.Size(806, 351);
            this.dgv_votacao.TabIndex = 0;
            this.dgv_votacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_votacao_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tcc_csharp.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 140);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_votacao_pendente
            // 
            this.lbl_votacao_pendente.AutoSize = true;
            this.lbl_votacao_pendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.lbl_votacao_pendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_votacao_pendente.ForeColor = System.Drawing.Color.White;
            this.lbl_votacao_pendente.Location = new System.Drawing.Point(12, 42);
            this.lbl_votacao_pendente.Name = "lbl_votacao_pendente";
            this.lbl_votacao_pendente.Size = new System.Drawing.Size(283, 31);
            this.lbl_votacao_pendente.TabIndex = 17;
            this.lbl_votacao_pendente.Text = "Votações Pendentes";
            this.lbl_votacao_pendente.Click += new System.EventHandler(this.lbl_votacao_pendente_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(772, 9);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 24);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 18;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(150)))), ((int)(((byte)(97)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(667, 84);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(127, 37);
            this.btnEntrar.TabIndex = 19;
            this.btnEntrar.Text = "Votar";
            this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // idpartida
            // 
            this.idpartida.HeaderText = "idpartida";
            this.idpartida.Name = "idpartida";
            this.idpartida.Visible = false;
            // 
            // data
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.HeaderText = "Data da Partida";
            this.data.Name = "data";
            this.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // time
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.time.DefaultCellStyle = dataGridViewCellStyle3;
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // valorApostado
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.valorApostado.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorApostado.HeaderText = "Valor da Aposta";
            this.valorApostado.Name = "valorApostado";
            this.valorApostado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // role
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.role.DefaultCellStyle = dataGridViewCellStyle5;
            this.role.HeaderText = "Posição";
            this.role.Name = "role";
            this.role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ganhou
            // 
            this.ganhou.HeaderText = "Ganhou?";
            this.ganhou.Name = "ganhou";
            // 
            // perdeu
            // 
            this.perdeu.HeaderText = "Perdeu?";
            this.perdeu.Name = "perdeu";
            // 
            // Votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 488);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lbl_votacao_pendente);
            this.Controls.Add(this.dgv_votacao);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Votacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_votacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_votacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_votacao_pendente;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorApostado;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ganhou;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdeu;
    }
}