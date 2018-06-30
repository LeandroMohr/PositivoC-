using System;
using Controllers;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;

            do
            {
                result = IndexController.ListarOpcoes();
            }
            while (result == 1);
        }
    }
}
