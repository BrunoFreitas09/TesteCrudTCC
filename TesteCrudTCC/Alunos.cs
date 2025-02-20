using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCrudTCC
{
    //sobre o video não se esqueça que os usuarios é igual aos seus alunos
    //usuarios == alunos

    //CAMPOS: Nome,RM,Curso,Série,Ano e escola
    internal class Alunos
    {
        private String idAluno;
        private String nome;
        private String rm;
        private String curso;
        private String serie;
        private String ano;
        private String escola;

        public string Nome { get => nome; set => nome = value; }
        public string RM { get => rm; set => rm = value; }
        public string Curso { get => curso; set => curso = value; }
        public String Serie { get => serie; set => serie = value; }
        public String Ano { get => ano; set => ano = value; }
        public string Escola { get => escola; set => escola = value; }
    }
}
