using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Professor
    {
        public static List<Professor> lista_professores = new List<Professor>();

        public String Nome
        {
            get; set;
        }

        public string Cpf
        {
            get; set;
        }

        public static void AdicionarProfessor(Professor professor)
        {
            lista_professores.Add(professor);
        }

        public static Professor GetCpf(String cpf)
        {
            return Professor.lista_professores.FirstOrDefault(p => p.Cpf == cpf);
        }

        public static bool Remover(string cpf)
        {
            try
            {
                return Professor.lista_professores.Remove(Professor.GetCpf(cpf));
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
