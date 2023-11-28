using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc_csharp.model.entities;

namespace Projeto_tcc.View
{
    public partial class Times : Form
    {
        public Times()
        {
            InitializeComponent();
        }

        public Times(List<PartidaUsuario> partidas)
        {
            InitializeComponent();
            abasteceLabels(partidas);
        }

        private void abasteceLabels(List<PartidaUsuario> partidas)
        {
            foreach(PartidaUsuario partida in partidas)
            {
                if (partida.role == "Topo")
                {
                    if (partida.time == 1)
                    {
                        lbl_topo_azul.Text = partida.usuario.username;
                    }
                    if (partida.time == 2)
                    {
                        lbl_topo_vermelho.Text = partida.usuario.username;
                    }
                }
                if (partida.role == "Selva")
                {
                    if (partida.time == 1)
                    {
                        lbl_selva_azul.Text = partida.usuario.username;
                    }
                    if (partida.time == 2)
                    {
                        lbl_selva_vermelho.Text = partida.usuario.username;
                    }
                }
                if (partida.role == "Meio")
                {
                    if (partida.time == 1)
                    {
                        lbl_meio_azul.Text = partida.usuario.username;
                    }
                    if (partida.time == 2)
                    {
                        lbl_meio_vermelho.Text = partida.usuario.username;
                    }
                }
                if (partida.role == "Atirador")
                {
                    if (partida.time == 1)
                    {
                        lbl_atirador_azul.Text = partida.usuario.username;
                    }
                    if (partida.time == 2)
                    {
                        lbl_atirador_vermelho.Text = partida.usuario.username;
                    }
                }
                if (partida.role == "Suporte")
                {
                    if (partida.time == 1)
                    {
                        lbl_suporte_azul.Text = partida.usuario.username;
                    }
                    if (partida.time == 2)
                    {
                        lbl_suporte_vermelho.Text = partida.usuario.username;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Times_Load(object sender, EventArgs e)
        {

        }

        private void lbl_top_vermelho_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_atirador_vermelho_Click(object sender, EventArgs e)
        {

        }

        private void lbl_meio_vermelho_Click(object sender, EventArgs e)
        {

        }

        private void lbl_selva_vermelho_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_suporte_vermelho_Click(object sender, EventArgs e)
        {

        }
    }
}
