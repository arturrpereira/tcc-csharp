using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using tcc_csharp.Data;
using tcc_csharp.model.dao;
using tcc_csharp.model.dao.impl;
using tcc_csharp.model.entities;

namespace Projeto_tcc.View
{
    public partial class Modelo : Form
    {
        private readonly IPartidaUsuario _partidaUsuarioRep;
        private PartidaUsuario partidaEncontrada;
        private Usuario _usuario;

        private System.Timers.Timer teste = new System.Timers.Timer(10000);
        public Modelo(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
            _partidaUsuarioRep = new PartidaUsuarioRepository(new Postgre());
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modelo_Load(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new Filaview());
            checarPartida();
            checarPartida();
            teste.Elapsed += testeBusca;
            teste.Enabled = true;
        }

        private void checarPartida()
        {
        }

        private void testeBusca(object sender, ElapsedEventArgs e)
        {
            foreach (PartidaUsuario partida in _partidaUsuarioRep.findByUsuario(_usuario))
            {
                if(partida.votoUsuario == 0)
                {
                    partidaEncontrada = partida;
                }
            }

            if (partidaEncontrada != null)
            {
                teste.Enabled = false;

                this.Invoke((Action)(() =>
                {
                    AbrirNOPrincipal(new Filaview(partidaEncontrada.partida.id_partida));
                }));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AbrirNOPrincipal(object form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form principal = form as Form;
            principal.TopLevel = false;
            principal.FormBorderStyle = FormBorderStyle.None;
            principal.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(principal);
            this.panel1.Tag = principal;
            principal.BringToFront();
            principal.Show();

        }

    }
}
