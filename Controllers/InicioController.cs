using System;

namespace Controllers
{
    public class IndexController
    {
        public static int ListarOpcoes()
        {
            int result = 1;

            do
            {
                Console.Clear();

                Console.WriteLine("==============================");
                Console.WriteLine("======= Menu Principal =======");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Alunos");
                Console.WriteLine("2. Professores");
                Console.WriteLine("3. Disciplinas");
                Console.WriteLine("0. Sair");
                Console.WriteLine();

                int opcaoSelecionada = int.Parse(Console.ReadLine());
                switch (opcaoSelecionada)
                {
                    case 1:
                        result = AlunosController.ListarOpcoes();
                        break;
                    case 2:
                        result = ProfessoresController.ListarOpcoes();
                        break;
                    case 3:
                        result = DisciplinaController.ListarOpcoes();
                        break;
                    default:
                        result = 0;
                        break;
                }
            }
            while (result != 0);
            return result;
        }
    }
}
