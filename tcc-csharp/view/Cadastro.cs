using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc_csharp.Data;
using tcc_csharp.model.dao.impl;
using tcc_csharp.model.entities;
using tcc_csharp.validators;

namespace Projeto_tcc.View
{
    public partial class Cadastro : Form
    {
        private readonly Usuario _usuario;
        private readonly UsuarioRepository _usuarioRepository;
        private readonly RiotApiRepository _riotApi;
        public Cadastro()
        {
            InitializeComponent();
            _usuario = new Usuario();
            _riotApi = new RiotApiRepository();
            _usuarioRepository = new UsuarioRepository(new Postgre());
        }

        private void materialTextBox22_Click(object sender, EventArgs e)
        {

        }

        private void txblogin_Click(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
        
        private void baixaIconeRiot(Usuario usuario)
        {
            string imageUrl = "http://ddragon.leagueoflegends.com/cdn/13.22.1/img/profileicon/" + usuario.perfilRiot.profileIconId + ".png";
            string directoryPath = "icons";
            string localPath = Path.Combine(directoryPath, usuario.perfilRiot.profileIconId + ".png");

            if (!File.Exists(localPath))
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        webClient.DownloadFile(imageUrl, localPath);
                        //MessageBox.Show("Imagem baixada com sucesso e salva");
                    }
                    catch (WebException ex)
                    {
                        //MessageBox.Show("Erro ao baixar a imagem: " + ex.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("A imagem já existe no diretório.");
            }
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            _usuario.nome = txb_nome_cadastro.Text;
            _usuario.dataNascimento = Convert.ToDateTime(txb_datanasc_cadastro.Text);
            _usuario.senha = txb_senha_cadastro.Text;
            _usuario.email = txb_email_cadastro.Text;
            _usuario.login = txb_login_cadastro.Text;
            _usuario.username = txb_username_cadastro.Text;

            if (!UsuarioValidator.ValidLogin(_usuario.login))
            {
                MessageBox.Show("Um usuário com este login já está cadastrado, verifique!");
            }
            else if (!UsuarioValidator.ValidateUsername(_usuario.username))
            {
                MessageBox.Show("Este Riot Name já foi utilizado, verifique!");
            }
            else
            {

                var teste = await _riotApi.findByUsername(_usuario.username);
                if (teste == null)
                {
                    MessageBox.Show("Usuário informado não encontrado, verifique!");
                }

                else
                {
                    _usuario.perfilRiot = teste;
                    _usuarioRepository.insert(_usuario);

                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    baixaIconeRiot(_usuario);

                    this.Hide();
                    Login login = new Login();
                    login.Closed += (s, args) => { this.Close(); };
                    login.Show();
                }
            }
        }
    }
}
