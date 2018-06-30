using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Disciplina
    {
        public static List<Disciplina> lista_disciplina = new List<Disciplina>();

        public List<Aluno> lista_alunos = new List<Aluno>();

        public String Nome
        {
            get; set;
        }

        public String Codigo
        {
            get; set;
        }

        public static void adicionarDisciplina(Disciplina disciplina)
        {
            lista_disciplina.Add(disciplina);
        }

        public static Disciplina GetCodigo(String codigo)
        {
            return Disciplina.lista_disciplina.FirstOrDefault(d => d.Codigo == codigo);
        }

        public static bool Remover(String codigo)
        {
            try
            {
                return Disciplina.lista_disciplina.Remove(Disciplina.GetCodigo(codigo));
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
