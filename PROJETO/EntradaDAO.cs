using PROJETO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO
{
    internal class EntradaDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public EntradaDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(EntradaFin colab)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO EntradaFin VALUES (@valor, @data, @descricao, @tipo)";

            Cmd.Parameters.AddWithValue("@valor", colab.Valor);
            Cmd.Parameters.AddWithValue("@data", colab.Data);
            Cmd.Parameters.AddWithValue("@descricao", colab.Descricao);
            Cmd.Parameters.AddWithValue("@tipo", colab.Tipo);


            try
            {
                //Insere a entrada
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir entrada no banco.\n"
                    + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<EntradaFin> ListarEntradas()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM EntradaFin";

            List<EntradaFin> listaDeEntrada = new List<EntradaFin>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    EntradaFin colab = new EntradaFin((int)rd["Id"], (string)rd["Valor"],
                        (string)rd["Data"], (string)rd["Descricao"], (string)rd["Tipo"]);
                    listaDeEntrada.Add(colab);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeEntrada;
        }

    }
}
