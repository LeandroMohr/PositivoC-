using System;
using Models;

namespace Controllers
{
    class ProfessoresController
    {
        public static int ListarOpcoes()
        {
            int result = 1;

            do
            {
                Console.Clear();

                Console.WriteLine("============================");
                Console.WriteLine("====== Menu Professor ======");
                Console.WriteLine("============================");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Editar");
                Console.WriteLine("3. Excluir");
                Console.WriteLine("4. Listar");
                Console.WriteLine("0. Sair");
                Console.WriteLine();

                int opcaoSelecionada = int.Parse(Console.ReadLine());
                switch (opcaoSelecionada)
                {
                    case 1:
                        result = AdicionarProfessor();
                        break;
                    case 2:
                        result = EditarProfessor();
                        break;
                    case 3:
                        result = ExcluirProfessor();
                        break;
                    case 4:
                        result = ListarProfessor();
                        break;
                    case 0:
                        result = 0;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção escolhida não existe! Retornando ao menu...");
                        Console.WriteLine();
                        Console.ReadKey();

                        result = ListarOpcoes();
                        break;
                }
            }
            while (result != 0);
            return 1;
        }

        public static int AdicionarProfessor()
        {
            Console.Clear();
            Professor professor = new Professor();

            Console.WriteLine("Digite o nome do professor: ");
            professor.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o CPF do professor: ");
            professor.Cpf = Console.ReadLine();
            Console.WriteLine();

            Professor.AdicionarProfessor(professor);
            return 1;
        }

        public static int ListarProfessor()
        {
            var lista = Professor.lista_professores;

            if (lista != null)
            {
                Console.Clear();
                Console.WriteLine("Lista de Professores: ");
                Console.WriteLine();

                foreach (Professor professor in Professor.lista_professores)
                {
                    Console.WriteLine("Aluno: " + professor.Nome + " - CPF: " + professor.Cpf);
                }

                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nenhum professor encontrado!");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            return 1;
        }

        public static int EditarProfessor()
        {
            Console.Clear();

            Console.WriteLine("Digite o CPF do professor que deseja alterar: ");
            String cpf = Console.ReadLine();
            Console.WriteLine();

            bool professor_encontrado = false;
            foreach (Professor professor in Professor.lista_professores)
            {
                if (professor.Cpf == cpf)
                {
                    professor_encontrado = true;
                    Console.WriteLine("Digite novo nome do professor: ");
                    professor.Nome = Console.ReadLine();
                }
            }
            if (!professor_encontrado)
            {
                Console.WriteLine("Professor não encontrado");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            return 1;
        }

        public static int ExcluirProfessor()
        {
            Console.Clear();

            Console.WriteLine("Digite o CPF do professor: ");
            String cpf = Console.ReadLine();
            Console.WriteLine();

            var sucesso = Professor.Remover(cpf);

            if (sucesso == true)
            {
                Console.WriteLine("Professor Excluido! ");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Professor não encontrado!");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            return 1;
        }

        public static bool ProfessorExiste(String cpf)
        {
            foreach (Professor professor in Professor.lista_professores)
            {
                if (professor.Cpf == cpf)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
