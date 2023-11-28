using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc_csharp.Data;
using tcc_csharp.model.dao;
using tcc_csharp.model.dao.impl;
using tcc_csharp.model.entities;

namespace Projeto_tcc.View
{
    public partial class Votacao : Form
    {
        private Usuario _usuario;
        private readonly IPartidaUsuario _partidaUsuario;
        private List<PartidaUsuario> _partidas;
        public Votacao(Usuario user)
        {
            InitializeComponent();
            dgv_votacao.CellContentClick += dgv_votacao_CellContentClick;
            _usuario = user;
            _partidaUsuario = new PartidaUsuarioRepository(new Postgre());
            _partidas = _partidaUsuario.findByUsuario(_usuario);
            abasteceGrid();
            //dgv_votacao.CellValueChanged += dgv_votacao_CellValueChanged;
        }

        private void dgv_votacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dgv_votacao.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verifica se a célula é uma célula de checkbox
                if (cell is DataGridViewCheckBoxCell)
                {
                    DataGridViewCheckBoxCell clickedCell = (DataGridViewCheckBoxCell)cell;
                    string otherColumnName = (e.ColumnIndex == 5) ? "perdeu" : "ganhou";
                    DataGridViewCheckBoxCell otherCell = dgv_votacao.Rows[e.RowIndex].Cells[otherColumnName] as DataGridViewCheckBoxCell;

                    if (clickedCell.Value != null)
                    {
                        if (otherCell != null)
                        {
                            otherCell.Value = false;
                        }
                    }
                    if (clickedCell.Value == null)
                    {
                        if (otherCell != null)
                        {
                            otherCell.Value = false;
                        }
                    }
                }
            }
        }



        private void abasteceGrid()
        {
            _partidas = _partidaUsuario.findByUsuario(_usuario);

            dgv_votacao.Rows.Clear();
            foreach (PartidaUsuario partidaUsuario in _partidas)
            {
                if (partidaUsuario.votoUsuario == 0)
                {
                    string time = "";
                    if (partidaUsuario.time == 1)
                    {
                        time = "Azul";
                    }

                    if (partidaUsuario.time == 2)
                    {
                        time = "Vermelho";
                    }
                    dgv_votacao.Rows.Add(
                        partidaUsuario.partida.id_partida,
                        partidaUsuario.partida.data.ToString("dd/MM/yyyy"),
                        time,
                        partidaUsuario.partida.valorApostado,
                        partidaUsuario.role
                        );
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool votacao = false;
            foreach (DataGridViewRow row in dgv_votacao.Rows)
            {
                DataGridViewCheckBoxCell checkGanhou = row.Cells["ganhou"] as DataGridViewCheckBoxCell;
                DataGridViewCheckBoxCell checkPerdeu = row.Cells["perdeu"] as DataGridViewCheckBoxCell;

                DataGridViewCell idPartidaCell = row.Cells["idpartida"];
                int idPartida = Convert.ToInt32(idPartidaCell.Value);

                if (checkGanhou!= null && Convert.ToBoolean(checkGanhou.Value))
                {
                    foreach(PartidaUsuario partidauser in _partidaUsuario.findByUsuario(_usuario))
                    {
                        if(partidauser.partida.id_partida == idPartida)
                        {
                            partidauser.votoUsuario = partidauser.time;
                            try
                            {
                                _partidaUsuario.update(partidauser);
                                votacao = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao concluir votação: " + ex.Message);
                            }
                        }
                    }
                }
                if (checkPerdeu!= null && Convert.ToBoolean(checkPerdeu.Value))
                {
                    foreach (PartidaUsuario partidauser in _partidaUsuario.findByUsuario(_usuario))
                    {
                        if (partidauser.partida.id_partida == idPartida)
                        {
                            if(partidauser.time == 1)
                            {
                                partidauser.votoUsuario = 2;
                                try
                                {
                                    _partidaUsuario.update(partidauser);
                                    votacao = true;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro ao concluir votação: " + ex.Message);
                                }

                            }
                            if (partidauser.time == 2)
                            {
                                partidauser.votoUsuario = 1;
                                try
                                {
                                    _partidaUsuario.update(partidauser);
                                    votacao = true;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro ao concluir votação: " + ex.Message);
                                }
                            }
                        }
                    }
                }
            }
            if(votacao)
            {
                MessageBox.Show("Votação efetuada com sucesso!");
            }
            abasteceGrid();
        }

        private void lbl_votacao_pendente_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
