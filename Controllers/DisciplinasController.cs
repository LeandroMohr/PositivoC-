using System;
using Models;

namespace Controllers
{
    class DisciplinaController
    {
        public static int ListarOpcoes()
        {
            int result = 1;

            do
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("======= Menu Disciplina =======");
                Console.WriteLine("================================");
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
                        result = AdicionarDisciplina();
                        break;
                    case 2:
                        result = EditarDisciplina();
                        break;
                    case 3:
                        result = ExcluirDisciplina();
                        break;
                    case 4:
                        result = ListarDisciplina();
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

        public static int AdicionarDisciplina()
        {
            Console.Clear();
            Disciplina disciplina = new Disciplina();

            Console.WriteLine("Digite o nome da disciplina: ");
            disciplina.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o código da disciplina: ");
            disciplina.Codigo = Console.ReadLine();
            Console.WriteLine();

            Disciplina.adicionarDisciplina(disciplina);
            return 1;
        }

        public static int EditarDisciplina()
        {
            Console.Clear();

            Console.WriteLine("Digite o código da disciplina: ");
            String codigo = Console.ReadLine();
            Console.WriteLine();

            bool disciplina_encontrada = false;

            foreach (Disciplina disciplina in Disciplina.lista_disciplina)
            {
                if (disciplina.Codigo == codigo)
                {
                    disciplina_encontrada = true;

                    Console.WriteLine("Digite o nome da disciplina: ");
                    Console.WriteLine();
                    disciplina.Nome = Console.ReadLine();
                }
            }
            if (disciplina_encontrada == false)
            {
                Console.WriteLine("Disciplina não encontrada");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            return 1;
        }

        public static int ExcluirDisciplina()
        {
            Console.Clear();

            Console.WriteLine("Digite o código da disciplina: ");
            String codigo = Console.ReadLine();
            Console.WriteLine();

            var sucesso = Disciplina.Remover(codigo);

            if (sucesso == true)
            {
                Console.WriteLine("Disciplina Excluido! ");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Disciplina não encontrada.");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar... ");
                Console.ReadKey();
            }
            return 1;
        }

        public static int ListarDisciplina()
        {
            Console.Clear();
            Console.WriteLine("Lista de Disciplina: ");
            Console.WriteLine();

            foreach (Disciplina disciplina in Disciplina.lista_disciplina)
            {
                Console.WriteLine("Disciplina: " + disciplina.Nome + " - Código: " + disciplina.Codigo);
            }

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            return 1;
        }

    }
}
