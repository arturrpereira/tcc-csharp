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
using tcc_csharp.model.entities;

namespace Projeto_tcc
{
   
    public partial class Main : Form
    {
        private Usuario _usuario;
        bool sideExpand;
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



        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public Main(Usuario usuario)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            _usuario = usuario;
        }

        private void main_Load(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new Inicio(_usuario));
        }
        public void AbrirNOPrincipal(object form)
        {
            if (this.Principal.Controls.Count > 0)
                this.Principal.Controls.RemoveAt(0);
            Form principal = form as Form;
            principal.TopLevel = false;
            principal.FormBorderStyle = FormBorderStyle.None;
            principal.Dock = DockStyle.Fill;
            this.Principal.Controls.Add(principal);
            this.Principal.Tag = principal;
            principal.BringToFront();
            principal.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        { 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new Inicio());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
        }

        private void btn_slide_Click(object sender, EventArgs e)
        {
            
            slidebarTimer.Start();
        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {
            sidebar.BringToFront();

        }

        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sideExpand)
            {
                sidebar.Width = -10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sideExpand = false;
                    slidebarTimer.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sideExpand = true;
                    slidebarTimer.Stop();
                }
            }
        }
    }
}
