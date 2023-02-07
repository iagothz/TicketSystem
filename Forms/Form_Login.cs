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
using TicketSystem.DB_Classes;
using static TicketSystem.DB_Classes.ConexaoDB;

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
        ConexaoDB conexao = new ConexaoDB();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ainda não implementado.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean tryLogin = false;
            //int user_id = 0;
            string login = tbox_login.Text;
            string senha = tbox_pass.Text;

            if (login.Equals("") || senha.Equals("")){
                tryLogin = false;
                MessageBox.Show("Login ou senha inválidos.");
            }
            else
            {
                try
                {
                    conexao.conn();
                    string sql = "SELECT * FROM users WHERE users_login = @login && users_pass = @senha";
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@senha", senha);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Login");
                        tryLogin = true;
                    }
                    else
                    {
                        Console.WriteLine("Miou o role");
                        tryLogin = false;
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (tryLogin == true)
                {
                    Console.WriteLine("Abrir tela");
                }
                else if(tryLogin == false)
                {
                    MessageBox.Show("Login ou senha inválidos.");
                }
            }
            
        }
    }
}
