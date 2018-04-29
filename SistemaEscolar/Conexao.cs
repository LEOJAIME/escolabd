using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SistemaEscolar
{
    class Conexao
    {
        NpgsqlConnection conn;
        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=leo;Database=SistemaEscolar;";


        public NpgsqlConnection conecta()
        {
            //Estabelecer ligação a base de dados
            try
            {
                conn = new NpgsqlConnection(connectionString);
                conn.Open();
                MessageBox.Show("conexao efetuada","sucesso");
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de ligção");
                return null;
            }
        }


    }
}
public void desconecta()
{
    conn.Close();
}