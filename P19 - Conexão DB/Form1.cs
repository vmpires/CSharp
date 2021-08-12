using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_21___Conexão_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensagem(string msg)
        {
            listBox1.Items.Add(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL Server
            //  SQL Connection
            //    Connection String
            //    Open()
            //    Close()
            
            //  SQL Command
            //      Connection
            //      CommandText
            //      ExecuteReader()
            //      ExecuteNonQuery()
            //      ExecuteScalar()
            //
            //

            //  SQL Data Reader
            //      Read() / Close()

            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=VDB;
                                    Integrated Security=True;";
            cn.Open();
            cn.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=VDB;
                                    Integrated Security=True;";         
            
            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT Nome FROM Cliente";
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nome = reader["Nome"].ToString();
                listBox1.Items.Add(nome);
            }
            reader.Close();
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=VDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Cliente(Id, Nome, Email, Telefone) VALUES (@Id, @Nome, @Email, @Telefone)";
            cmd.Parameters.AddWithValue("@Id", 3);
            cmd.Parameters.AddWithValue("@Nome", "Deby");
            cmd.Parameters.AddWithValue("@Email", "milhomedebi@uol.com.br");
            cmd.Parameters.AddWithValue("@Telefone", "989345832");

            cn.Open();
            Mensagem("Registro Incluído");
            int total = cmd.ExecuteNonQuery();
            cn.Close();
            Mensagem("Conexão fechada");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=VDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Cliente SET Nome=@Nome WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Nome", "Débora Alves Milhome");
            cmd.Parameters.AddWithValue("@Id", 3);
            cn.Open();
            Mensagem("Registro Atualizado");
            int total = cmd.ExecuteNonQuery();
            cn.Close();
            Mensagem("Conexão fechada");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=VDB;
                                    Integrated Security=True;";

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE Cliente WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", 3);
            cn.Open();
            Mensagem("Registro excluído com sucesso!");
            int total = cmd.ExecuteNonQuery();
            cn.Close();
            Mensagem("Conexão fechada");
        }
    }
}
