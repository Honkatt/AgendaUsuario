using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaUsuarios.Controler;
using AgendaUsuarios.Model;

namespace AgendaUsuarios
{
    public partial class Form1 : Form
    {
        private ContatosControler controller = new ContatosControler();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string zap = txtZap.Text;
            string email = txtEmail.Text;
            string msg = controller.SaveContatos(nome, zap, email);
            MessageBox.Show(msg);
            this.RefreshDgv();
        }
        private void RefreshDgv()
        {
            List<Contatos> contatos = controller.GetAllContatos();
            dgvContatos.Visible = true;
            dgvContatos.DataSource = null;

            if ((contatos.Count * 50) <= 200)
            {
                dgvContatos.Height = contatos.Count * 50;
            }
            else
            {
                dgvContatos.Height = 200;
            }
            dgvContatos.DataSource = contatos;

        }
    }
}
