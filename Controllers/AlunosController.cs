using System;
using Models;

namespace Controllers
{
    class AlunosController
    {
        public static int ListarOpcoes()
        {
            int result = 1;

            do
            {
                Console.Clear();

                Console.WriteLine("===========================");
                Console.WriteLine("======= Menu Alunos =======");
                Console.WriteLine("===========================");
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
                        result = AdicionarAluno();
                        break;
                    case 2:
                        result = EditarAluno();
                        break;
                    case 3:
                        result = ExcluirAluno();
                        break;
                    case 4:
                        result = ListarAlunos();
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

        public static int AdicionarAluno()
        {
            Console.Clear();
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite a matrícula do aluno: ");
            aluno.Matricula = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Aluno.adicionarAluno(aluno);
            return 1;
        }

        public static int ListarAlunos()
        {
            var lista = Aluno.lista_alunos;

            if (lista != null)
            {
                Console.Clear();
                Console.WriteLine("Lista de Alunos: ");
                Console.WriteLine();

                foreach (Aluno aluno in Aluno.lista_alunos)
                {
                    Console.WriteLine("Aluno: " + aluno.Nome + " - Matrícula: " + aluno.Matricula);
                }

                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nenhum aluno encontrado!");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            return 1;
        }

        public static int EditarAluno()
        {
            Console.Clear();

            Console.WriteLine("Digite a matrícula do aluno que deseja alterar: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var aluno_encontrado = Aluno.GetMatricula(matricula);
            
            if (aluno_encontrado != null)
            {
                Console.WriteLine("Informe o novo nome do Aluno: ");
                aluno_encontrado.Nome = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aluno não encontrado! ");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            return 1;
        }

        public static int ExcluirAluno()
        {
            Console.Clear();

            Console.WriteLine("Digite a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var sucesso = Aluno.Remover(matricula);

            if (sucesso == true)
            {
                Console.WriteLine("Aluno Excluido! ");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            return 1;
        }

    }

}
