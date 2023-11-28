using Projeto_tcc.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc_csharp.Data;
using tcc_csharp.model.dao;
using tcc_csharp.model.dao.impl;
using tcc_csharp.model.entities;

namespace Projeto_tcc
{
    public partial class Inicio : Form
    {
        private Usuario _usuario;
        private readonly IPartidaUsuario _partidaUsuario;
        private readonly IUsuario _usuarioRep;
        public Inicio()
        {
            InitializeComponent();
        }
        public Inicio(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            _partidaUsuario = new PartidaUsuarioRepository(new Postgre());
            _usuarioRep = new UsuarioRepository(new Postgre());
            abasteceGrid();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;

        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["resultado"].Index && e.RowIndex >= 0)
            {
                string valor = dataGridView1.Rows[e.RowIndex].Cells["resultado"].Value.ToString();

                if (string.Equals(valor, "DERROTA", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Red;
                }
                else if (string.Equals(valor, "VITÓRIA", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            lbl_riotname.Text = _usuario.username;
            lbl_saldo.Text = Convert.ToString(_usuario.saldo);
            icon_box.Image = Image.FromFile("icons/" + _usuario.perfilRiot.profileIconId + ".png");
        }

        private void abasteceGrid()
        {
            dataGridView1.Rows.Clear();

            foreach (PartidaUsuario partidaUsuario in _partidaUsuario.findByUsuario(_usuario))
            {
                if(partidaUsuario.partida.timeVencedor != 0)
                {
                    string resultado = "";
                    if (partidaUsuario.time != partidaUsuario.partida.timeVencedor)
                    {
                        resultado = "DERROTA";
                    }
                    else
                    {
                        resultado = "VITÓRIA";
                    }
                    dataGridView1.Rows.Add(
                        partidaUsuario.partida.data.ToString("dd/MM/yyyy"),
                        partidaUsuario.role,
                        partidaUsuario.partida.valorApostado,
                        resultado
                        );
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void switchLigar_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Votacao votacao = new Votacao(_usuario);
            votacao.Show();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            Buscar_Partida busca = new Buscar_Partida(_usuario);
            busca.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Movimentacoes movimentacoes = new Movimentacoes(_usuario);
            movimentacoes.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            abasteceGrid();
            _usuario = _usuarioRep.findById(_usuario.id_usuario);
            lbl_saldo.Text = Convert.ToString(_usuario.saldo);
        }
    }
}
