using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem.Forms
{
    public partial class Form_main : Form
    {
        static string frm_user_id;
        public Form_main(string user_id)
        {
            InitializeComponent();
            string frm_user_id = user_id;
            label1.Text = frm_user_id;
        }
        string connectionString = @"Data Source=DESKTOP-O4SMKJK\SQLEXPRESS;Failover Partner=DESKTOP-O4SMKJK;Initial Catalog=ticketsystem;Integrated Security=True";
        private void Form_main_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamado criado com sucesso!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
