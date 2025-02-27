﻿using System;
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
        Alunos A;
        private Alunos alunos;
        public frmUsuarios()
        {
            InitializeComponent();
        }

         void LimpaControles()
        {
            
            txtCurso.Clear();
            txtEscola.Clear();
            txtNome.Clear();
            txtrm.Clear();
        }
        void carregarGrid(string pesquisa)
        {
            A = new Alunos()
            {
                nome = pesquisa
            };
            dgvAlunos.DataSource = A.Consultar();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;

            A = new Alunos()
            {
                nome = txtNome.Text,
                curso = txtCurso.Text,
                escola = txtEscola.Text,
                ano = dtpAno.Value,
                rm = double.Parse(txtrm.Text),
                

            };
            A.Incluir();

            LimpaControles();
            carregarGrid("");
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
            Banco.CriarTabelas();
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

    public static void CriarTabelas()
    {
        // Implementação da criação de tabelas

    }
}