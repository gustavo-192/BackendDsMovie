using Backend.DadosMocados;
using dsmovie.DadosMocados;
using dsmovie.Data;
using dsmovie.DTO;
using dsmovie.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Repository
{
    public class UsuarioRepository : Repository, IUsuarioRepository
    {
        private BackendContext _context;
        public UsuarioRepository(BackendContext context) : base(context)
        {
            _context = context;
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();
                string sql = "select * from tb_user order by id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();//consultas de select

                while (dr.Read())//aponta para o registro corrente
                {
                    string id = dr["id"].ToString();
                    string email = dr["email"].ToString();
                    Usuario usuario = new Usuario();
                    usuario = new Usuario(int.Parse(id), email);
                    lista.Add(usuario);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro de SQL " + e.Message);
            }
            return lista;
            
        }
        public Usuario GetById(int id)
        {
            Usuario usuario = new Usuario();

            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();
                string sql = "SELECT * FROM tb_user WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario.Id = int.Parse(dr["id"].ToString());
                    usuario.Email = dr["email"].ToString();
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL " + e.Message);
            }
            return usuario;
        }
        public void RegisterUser(Usuario usuario)
        {
            try
            {
                NpgsqlConnection conexao = Conexao.GetConexao();
                string sql = "insert into tb_user (id,email) values (@id,@email)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuario.Id;
                cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = usuario.Email;
                int valor = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL " + e.Message);
            }
        }
    }
}
