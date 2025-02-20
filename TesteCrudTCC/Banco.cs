using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TesteCrudTCC
{
    class Banco
    {
        private String host = "localhost";
        private String nomeBanco = "TesteTCC";
        private String usuario = "root";
        private String senha = "" ;
        private MySqlConnection con;
        private MySqlCommand command;

        public Banco()
        {
            Conectar();
        }

        public void Conectar ()
        {
            String stringCon = "SERVER="+this.host+";DATABASE="+";UID" + this.usuario + "PASSWORD=" + this.senha + ";";
            this.con = new MySqlConnection (stringCon);
            this.command = this.con.CreateCommand ();
            this.con.Open ();
        }
        //Esse query é pra fazer um Insert,update e delete
        public void NonQuery(String sql)
        {
            this.command.CommandText = sql;
            this.command.ExecuteNonQuery ();
        }
        //Esse query é pra fazer um select
        public MySqlDataReader Query (String sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteReader ();
        }
    }
}
