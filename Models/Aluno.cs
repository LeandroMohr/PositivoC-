using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Aluno
    {
        public static List<Aluno> lista_alunos = new List<Aluno>();

        public String Nome
        {
            get; set;
        }

        public int Matricula
        {
            get; set;
        }

        public static void adicionarAluno(Aluno aluno)
        {
            lista_alunos.Add(aluno);
        }

        public static Aluno GetMatricula(int matricula)
        {
            return Aluno.lista_alunos.FirstOrDefault(a => a.Matricula == matricula);
        }

        public static bool Remover(int matricula)
        {
            try
            {
                return Aluno.lista_alunos.Remove(Aluno.GetMatricula(matricula));
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
