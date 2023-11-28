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
    public partial class Filaview : Form
    {
        private IPartidaUsuario _partidaUsuarioRep;
        public Filaview()
        {
            InitializeComponent();
        }
        public Filaview(int idPartida)
        {
            InitializeComponent();
            _partidaUsuarioRep = new PartidaUsuarioRepository(new Postgre());
            this.label2.Text = "Partida encontrada!";
            AbrirNOPrincipal(new Times(_partidaUsuarioRep.findByPartida(idPartida)));
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fila_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
