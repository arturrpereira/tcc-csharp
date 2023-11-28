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
    public partial class Movimentacoes : Form
    {
        private Usuario _usuario;
        private readonly IMovimentacoes _movRep;
        private readonly List<Movimentacao> _movimentacoes;
        public Movimentacoes(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
            _movRep = new MovimentacoesRepository(new Postgre());
            _movimentacoes = _movRep.findByUser(_usuario);
            abasteceGrid();
        }

        private void abasteceGrid()
        {
            foreach (Movimentacao mov in _movimentacoes)
            {
                string operacao = "";
                if(mov.tipooperacao == 1)
                {
                    operacao = "Entrada";
                }

                if(mov.tipooperacao == 2)
                {
                    operacao = "Saída";
                }

                dgv_movimentacoes.Rows.Add(
                    mov.Partida.data,
                    operacao,
                    "R$ " + mov.valor
                    );
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_movimentacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
