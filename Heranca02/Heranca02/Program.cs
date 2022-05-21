using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;
using ByteBank.Funcionarios;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor(5000, "159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta pedro = new GerenteDeConta("223.232.442-20");
            pedro.Nome = "Pedro";
            pedro.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(pedro, "abc");

            Console.ReadKey();

            // public static void CalcularBonificacao()
            // {
            //     // GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            //     // Funcionario pedro = new Designer("833.222.048-39");
            //     // pedro.Nome = "Pedro";

            //     // Funcionario igor = new Auxiliar("981.198.778-53");
            //     // igor.Nome = "Igor";
                        
            //     // Funcionario camila = new GerenteDeConta("326.985.628-89");
            //     // camila.Nome = "Camila";

            //     // Funcionario joao = new Desenvolvedor("123.432.234-20");
            //     // joao.Nome = "João";

            //     // gerenciadorBonificacao.Registrar(pedro);
            //     // //gerenciadorBonificacao.Registrar(roberta);
            //     // gerenciadorBonificacao.Registrar(igor);
            //     // gerenciadorBonificacao.Registrar(camila);
            //     // gerenciadorBonificacao.Registrar(joao);

            //     // Console.WriteLine("Total de bonificações do mês " +
            //     // gerenciadorBonificacao.GetTotalBonificacao());
            // }
        }
    }
}