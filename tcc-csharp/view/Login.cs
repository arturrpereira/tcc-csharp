using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Projeto_tcc.View;
using tcc_csharp.model.dao.impl;
using tcc_csharp.model.dao;
using tcc_csharp.model.entities;
using tcc_csharp.validators;
using tcc_csharp.Data;

namespace Projeto_tcc
{
    public partial class Login : Form
    {
        private Usuario _usuario;
        private readonly IUsuario _usarioRep;
        private readonly UsuarioValidator _usuarioValidator;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );

        public Login()
        {
            InitializeComponent();
            _usuario = new Usuario();
            _usarioRep = new UsuarioRepository(new Postgre());
            _usuarioValidator = new UsuarioValidator();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbSenha.BringToFront();
            txblogin.BringToFront();
            pictureBox1.BringToFront();
            label1.BringToFront();
            Fechar.BringToFront();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.FromArgb(45, 51, 73);
            _usuario.login = txblogin.Text;
            _usuario.senha = txbSenha.Text;

            bool verifica = false;

            foreach(Usuario user in _usarioRep.findAll())
            {
                if(user.login == _usuario.login && user.senha == _usuario.senha)
                {
                    verifica = true;
                    _usuario = user;
                }
            }

            if(verifica == true)
            {
                MessageBox.Show("Login efetuado com sucesso!");
                this.Hide();
                Main teste = new Main(_usuario);
                teste.Closed += (s, args) => { this.Close(); };
                teste.Show();
            }
            else
            {
                MessageBox.Show("Informações inválidas, verifique!");
                txblogin.Text = "";
                txbSenha.Text = "";
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
