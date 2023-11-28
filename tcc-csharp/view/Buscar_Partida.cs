using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using tcc_csharp.model.dao;
using tcc_csharp.model.dao.impl;
using tcc_csharp.Data;
using tcc_csharp.model.entities;


namespace Projeto_tcc.View
{
    public partial class Buscar_Partida : Form
    {
        private readonly IFila _filaRep;
        private Fila fila;
        private Usuario _usuario;
        public Buscar_Partida(Usuario user)
        {
            InitializeComponent();
            _filaRep = new FilaRepository(new Postgre());
            fila = new Fila();
            _usuario = user;

            txbvaloraposta.TextChanged += Txbvaloraposta_TextChanged;
        }
        private void Txbvaloraposta_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string role = materialComboBox1.Text; 
            float aposta = Convert.ToInt32(txbvaloraposta.Text);

            fila.usuario = _usuario;
            fila.role = role;
            fila.valorSugerido = aposta;

            try
            {
                _filaRep.insert(fila);
                this.Hide();
                Modelo modelo = new Modelo(_usuario);
                modelo.Closed += (s, args) => { this.Close(); };
                modelo.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Modelo1_Load(object sender, EventArgs e)
        {

        }

        private void txbvaloraposta_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
