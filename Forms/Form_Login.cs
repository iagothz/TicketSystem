using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem
{
    public partial class Form_Login : Form
    {
        

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ainda não implementado.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-O4SMKJK\SQLEXPRESS;Failover Partner=DESKTOP-O4SMKJK;Initial Catalog=ticketsystem;Integrated Security=True";

            Boolean tryLogin = false;
            //int user_id = 0;
            string login = tbox_login.Text;
            string senha = tbox_pass.Text;

            if (login.Equals("") || senha.Equals(""))
            {
                tryLogin = false;
                MessageBox.Show("Login ou senha inválidos.");
            }
            else
            {
                try
                {
                    string sql = "SELECT * FROM users WHERE users_login = @login AND users_pass = @senha";
                    
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (var command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@senha", senha);

                            using (var reader = command.ExecuteReader())
                            {
                                tryLogin = reader.HasRows;
                                if (tryLogin)
                                {
                                    MessageBox.Show("Popup next window = " + tryLogin);
                                }
                                else
                                {
                                    MessageBox.Show("Login ou senha inválidos.");
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Catch: " + ex.Message);
                }
            }
        }
    }
}
