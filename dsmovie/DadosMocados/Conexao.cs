using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.DadosMocados
{
    public class Conexao
    {
        public static NpgsqlConnection GetConexao()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234567;Database=dsmovietwo;");
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de conexão: " + e.Message);
            }
            return conexao;
        }

        public static void SetFechaConexao(NpgsqlConnection conexao)
        {
            if (conexao != null)
            {
                try
                {
                    conexao.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao fechar conexão: " + e.Message);
                }
            }
        }
    }
}
