using MySql.Data.MySqlClient;
using TesteCrudTCC;
using System;
using System.Data;
using System.Windows.Forms;


namespace TesteCrudTCC.Models
{
    internal class Alunos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int curso { get; set; }
        public DateTime ano { get; set; }
        public string escola { get; set; }


        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("INSERT INTO Alunos(nome,curso,ano, escola) " +
                    "VALUES (@nome, @curso, @ano, @escola)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@curso", curso);
                Banco.Comando.Parameters.AddWithValue("@ano", ano);
                Banco.Comando.Parameters.AddWithValue("@escola", escola);

                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Alterar()
        {//segue o padrao: nome ,curso ,ano,escola
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("UPDATE Alunos SET nome = @nome, curso = @curso, ano = @ano, escola = @escola WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@curso", curso);
                Banco.Comando.Parameters.AddWithValue("@ano", ano);
                Banco.Comando.Parameters.AddWithValue("@escola", escola);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Excluir()
        {
            try
            {
                Banco.Abrirconexao();
                Banco.Comando = new MySqlCommand("DELETE FROM Alunos WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Fechar_Conexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT al.*, ci.nome cidade, " +
                                                 "ci.uf FROM clientes cl INNER JOIN Cidades ci on (ci.id = cl.idCidade) " +
                                                 "WHERE cl.nome LIKE ?Nome ORDER BY cl.nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
