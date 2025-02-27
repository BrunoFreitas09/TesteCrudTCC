using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TesteCrudTCC.Models;

namespace TesteCrudTCC
{
    public partial class frmUsuarios : Form
    {

        private Alunos alunos;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
            Banco.CriarTabelas(); // This line was causing the error

        }
    }
}

public class Banco
{
    public static MySqlConnection Conexao;
    public static MySqlCommand Comando;
    public static MySqlDataAdapter Adaptador;
    public static DataTable datTabela;
    public static void Abrirconexao() { }
    public static void Fechar_Conexao() { }
    public static void CriarBanco() { }
    public static void CriarTabelas() { } // Added this method to fix the error
}